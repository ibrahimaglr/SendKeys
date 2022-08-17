
namespace SendKeys
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCurrentlyActiveWindow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLock = new System.Windows.Forms.Button();
            this.lblActiveWindow = new System.Windows.Forms.Label();
            this.txtActiveWindow = new System.Windows.Forms.TextBox();
            this.txtWindowHandle = new System.Windows.Forms.TextBox();
            this.lblActiveWindowHandle = new System.Windows.Forms.Label();
            this.grpKeys = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            this.grpKeys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentlyActiveWindow,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(425, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCurrentlyActiveWindow
            // 
            this.lblCurrentlyActiveWindow.Name = "lblCurrentlyActiveWindow";
            this.lblCurrentlyActiveWindow.Size = new System.Drawing.Size(90, 17);
            this.lblCurrentlyActiveWindow.Text = "Active Window:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(305, 12);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(110, 23);
            this.btnLock.TabIndex = 1;
            this.btnLock.Text = "Lock Window";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // lblActiveWindow
            // 
            this.lblActiveWindow.AutoSize = true;
            this.lblActiveWindow.Location = new System.Drawing.Point(13, 17);
            this.lblActiveWindow.Name = "lblActiveWindow";
            this.lblActiveWindow.Size = new System.Drawing.Size(82, 13);
            this.lblActiveWindow.TabIndex = 2;
            this.lblActiveWindow.Text = "Active Window:";
            // 
            // txtActiveWindow
            // 
            this.txtActiveWindow.Location = new System.Drawing.Point(101, 14);
            this.txtActiveWindow.Name = "txtActiveWindow";
            this.txtActiveWindow.Size = new System.Drawing.Size(198, 20);
            this.txtActiveWindow.TabIndex = 3;
            // 
            // txtWindowHandle
            // 
            this.txtWindowHandle.Location = new System.Drawing.Point(101, 40);
            this.txtWindowHandle.Name = "txtWindowHandle";
            this.txtWindowHandle.Size = new System.Drawing.Size(72, 20);
            this.txtWindowHandle.TabIndex = 4;
            // 
            // lblActiveWindowHandle
            // 
            this.lblActiveWindowHandle.AutoSize = true;
            this.lblActiveWindowHandle.Location = new System.Drawing.Point(9, 43);
            this.lblActiveWindowHandle.Name = "lblActiveWindowHandle";
            this.lblActiveWindowHandle.Size = new System.Drawing.Size(86, 13);
            this.lblActiveWindowHandle.TabIndex = 5;
            this.lblActiveWindowHandle.Text = "Window Handle:";
            // 
            // grpKeys
            // 
            this.grpKeys.Controls.Add(this.button4);
            this.grpKeys.Controls.Add(this.button2);
            this.grpKeys.Controls.Add(this.button1);
            this.grpKeys.Controls.Add(this.txtText);
            this.grpKeys.Location = new System.Drawing.Point(12, 66);
            this.grpKeys.Name = "grpKeys";
            this.grpKeys.Size = new System.Drawing.Size(403, 325);
            this.grpKeys.TabIndex = 6;
            this.grpKeys.TabStop = false;
            this.grpKeys.Text = "Send Keys";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Enabled = false;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(309, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "KILL TASK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 24);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear TextBox";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.errorProvider1.SetIconAlignment(this.button1, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(309, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 69);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inject Text";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(6, 19);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtText.Size = new System.Drawing.Size(391, 192);
            this.txtText.TabIndex = 6;
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 416);
            this.Controls.Add(this.grpKeys);
            this.Controls.Add(this.lblActiveWindowHandle);
            this.Controls.Add(this.txtWindowHandle);
            this.Controls.Add(this.txtActiveWindow);
            this.Controls.Add(this.lblActiveWindow);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SendKeys";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpKeys.ResumeLayout(false);
            this.grpKeys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentlyActiveWindow;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Label lblActiveWindow;
        private System.Windows.Forms.TextBox txtActiveWindow;
        private System.Windows.Forms.TextBox txtWindowHandle;
        private System.Windows.Forms.Label lblActiveWindowHandle;
        private System.Windows.Forms.GroupBox grpKeys;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

