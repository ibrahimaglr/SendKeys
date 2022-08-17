using SendKeys.BLL;
using SendKeys.BLL.ActiveWindow;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SendKeys
{
    public partial class Form1 : Form
    {
        private ActiveWindowWatcher activeWindowWatcher;
        private ActiveWindowModel activeWindow = ActiveWindowModel.CreateEmpty();
        public static bool resultInject = false;
        private bool lockbtn = false;
        public Form1()
        {
            InitializeComponent();
            activeWindowWatcher = new ActiveWindowWatcher(TimeSpan.FromSeconds(1));
            activeWindowWatcher.ActiveWindowChanged += ActiveWindowWatcher_ActiveWindowChanged;
            activeWindowWatcher.Start();
        }
        private void ActiveWindowWatcher_ActiveWindowChanged(object sender, ActiveWindowChangedEventArgs e)
        {
            activeWindow = ActiveWindowModel.Create(e.WindowHandle, e.WindowTitle);
            toolStripStatusLabel1.Text = $"{e.WindowTitle}";
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (!lockbtn)
            {
                activeWindowWatcher.Stop();
                txtActiveWindow.Text = activeWindow.WindowTitle;
                txtWindowHandle.Text = activeWindow.WindowHandle.ToString();
                btnLock.Text = "Stop Lock";
                lockbtn = true;
            }
            else
            {
                activeWindowWatcher.Start();
                txtActiveWindow.Clear();
                txtWindowHandle.Clear();
                btnLock.Text = "Lock Window";
                lockbtn = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtText.Text != "")
            {
                resultInject = false;
                btnLock.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = true;
                WindowAPI.SendKeys(activeWindow.WindowHandle, txtText.Text.ToString());
                WindowAPI.SetActiveWindow(Process.GetCurrentProcess().MainWindowHandle);
                btnLock.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button4.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(button1, "TextBox Empty");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtText.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultInject = true;
            btnLock.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider1.SetIconAlignment(this.button1, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);

        }
    }
}