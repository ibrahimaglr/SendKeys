using SendKeys.BLL.ActiveWindow;
using SendKeys.Common;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SendKeys.BLL
{
    public static class WindowAPI
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public static void SetActiveWindow(IntPtr windowHandle) => SetForegroundWindow(windowHandle);

        public static Option<ActiveWindowModel> GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
                return Option<ActiveWindowModel>.Some(ActiveWindowModel.Create(handle, Buff.ToString()));

            return Option<ActiveWindowModel>.None();
        }

        public static void SendKeys(IntPtr windowHandle, string key)
        {
            if (SetForegroundWindow(windowHandle))
                foreach (char c in key)
                {
                    if (Form1.resultInject)
                    {
                        Form1.resultInject = false;
                        break;
                    }
                    else
                    {
                        if (c.ToString() == "(")
                            System.Windows.Forms.SendKeys.SendWait("{(}");
                        else if (c.ToString() == ")")
                            System.Windows.Forms.SendKeys.SendWait("{)}");
                        else if (c.ToString() == "^")
                            System.Windows.Forms.SendKeys.SendWait("{^}");
                        else if (c.ToString() == "+")
                            System.Windows.Forms.SendKeys.SendWait("{+}");
                        else if (c.ToString() == "%")
                            System.Windows.Forms.SendKeys.SendWait("{%}");
                        else if (c.ToString() == "~")
                            System.Windows.Forms.SendKeys.SendWait("{~}");
                        else if (c.ToString() == "{")
                            System.Windows.Forms.SendKeys.SendWait("{{}");
                        else if (c.ToString() == "}")
                            System.Windows.Forms.SendKeys.SendWait("{}}");
                        else if (c.ToString() == "\n")
                            System.Windows.Forms.SendKeys.SendWait("+{ENTER}");
                        else if (c.ToString() == "\r")
                            Console.WriteLine("");
                        else
                            System.Windows.Forms.SendKeys.SendWait(c.ToString());
                    }
                }
        }
    }
}
