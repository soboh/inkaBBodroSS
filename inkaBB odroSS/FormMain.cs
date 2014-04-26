using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace inkaBB_odroSS
{
    public partial class FormMain : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", EntryPoint = "GetWindowText", CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowCaption(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        public delegate bool EnumDelegate(IntPtr hWnd, int lParam);

        [DllImport("user32.dll", EntryPoint = "EnumDesktopWindows",
         ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDesktopWindows(IntPtr hDesktop, EnumDelegate lpEnumCallbackFunction, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "GetWindowText",
         ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpWindowText, int nMaxCount);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MINIMIZE = 0xF020;

        StringBuilder window_title = new StringBuilder(256 + 1);



        public FormMain()
        {
            InitializeComponent();
        }



        private void timerForegroundWindow_Tick(object sender, System.EventArgs e)
        {
            IntPtr fg = GetForegroundWindow();
            IntPtr x = GetWindowCaption(fg, window_title, 256);
            textBox1.Text = window_title.ToString();
            if (/*textBox1.Text != "inkaBB odroSS" &&*/
                !(listBoxIncludedPrograms.Items.Contains(textBox1.Text)) &&
                (listBoxExcludedPrograms.Items.Contains(textBox1.Text)))
                SendMessage((int)fg, WM_SYSCOMMAND, SC_MINIMIZE, 0);

        }

        private void updateListOfOpenedWindows()
        {
            listBoxExcludedPrograms.Items.Clear();
            var collection = new List<string>();
            FormMain.EnumDelegate filter = delegate(IntPtr hWnd, int lParam)
            {
                StringBuilder strbTitle = new StringBuilder(255);
                int nLength = FormMain.GetWindowText(hWnd, strbTitle, strbTitle.Capacity + 1);
                string strTitle = strbTitle.ToString();

                if (FormMain.IsWindowVisible(hWnd) && string.IsNullOrEmpty(strTitle) == false)
                {
                    collection.Add(strTitle);
                }
                return true;
            };

            if (FormMain.EnumDesktopWindows(IntPtr.Zero, filter, IntPtr.Zero))
            {
                foreach (var item in collection)
                {
                    if (!listBoxIncludedPrograms.Items.Contains(item))
                    {
                        listBoxExcludedPrograms.Items.Add(item);
                    }
                }
            }
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            updateListOfOpenedWindows();
        }

        private void toolStripButtonAbout_Click(object sender, System.EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void timerMain_Tick(object sender, System.EventArgs e)
        {
            timerForegroundWindow.Enabled = false;
            toolStripButtonStart.Enabled = true;
            timerMain.Enabled = false;
            listBoxExcludedPrograms.Enabled = true;
            listBoxIncludedPrograms.Enabled = true;
        }

        private void toolStripButtonStart_Click(object sender, System.EventArgs e)
        {
            int hours = (toolStripTextBoxHour.Text == "") ? 0 : Convert.ToInt32(toolStripTextBoxHour.Text);
            int minutes = (toolStripTextBoxMinute.Text == "") ? 0 : Convert.ToInt32(toolStripTextBoxMinute.Text);
            int seconds = (toolStripTextBoxSecond.Text == "") ? 0 : Convert.ToInt32(toolStripTextBoxSecond.Text);
            timerMain.Interval = (hours * 60 * 60 + minutes * 60 + seconds) * 1000;
            timerMain.Enabled = true;
            timerForegroundWindow.Enabled = true;
            toolStripButtonStart.Enabled = false;
            listBoxExcludedPrograms.Enabled = false;
            listBoxIncludedPrograms.Enabled = false;
            toolStripButtonRight.Enabled = false;
            toolStripButtonLeft.Enabled = false;
        }

        private void toolStripButtonRight_Click(object sender, EventArgs e)
        {
            if (listBoxExcludedPrograms.SelectedIndex == -1)
                return;
            listBoxIncludedPrograms.Items.Add(listBoxExcludedPrograms.Items[listBoxExcludedPrograms.SelectedIndex]);
            listBoxExcludedPrograms.Items.RemoveAt(listBoxExcludedPrograms.SelectedIndex);
        }

        private void listBoxExcludedPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripButtonRight.Enabled = true;
            toolStripButtonLeft.Enabled = false;
        }

        private void listBoxIncludedPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripButtonRight.Enabled = false;
            toolStripButtonLeft.Enabled = true;
        }

        private void toolStripButtonLeft_Click(object sender, EventArgs e)
        {
            if (listBoxIncludedPrograms.SelectedIndex == -1)
                return;
            listBoxExcludedPrograms.Items.Add(listBoxIncludedPrograms.Items[listBoxIncludedPrograms.SelectedIndex]);
            listBoxIncludedPrograms.Items.RemoveAt(listBoxIncludedPrograms.SelectedIndex);
        }

        private void timerUpdateListOfWindows_Tick(object sender, EventArgs e)
        {
            updateListOfOpenedWindows();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timerMain.Enabled == true)
            {
                e.Cancel = true;
            }
        }


    }
}
