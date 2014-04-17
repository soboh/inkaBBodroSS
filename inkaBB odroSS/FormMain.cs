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
        [DllImport("user32.dll", CharSet=CharSet.Auto, SetLastError=true)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", EntryPoint="GetWindowText",CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowCaption(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

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
            if (textBox1.Text != "inkaBB odroSS" && !(listBoxIncludedPrograms.Items.Contains(textBox1.Text)))
                SendMessage((int)fg, WM_SYSCOMMAND, SC_MINIMIZE, 0);

        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                IntPtr handle = process.MainWindowHandle;
                handle = GetWindowCaption(handle, window_title, 256);
                string title = window_title.ToString();
                if (!String.IsNullOrEmpty(title))
                {
                    listBoxExcludedPrograms.Items.Add(title);
                }
            }

        }

        private void toolStripButtonAbout_Click(object sender, System.EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void timerMain_Tick(object sender, System.EventArgs e)
        {
            timerForegroundWindow.Enabled = false;
            timerMain.Enabled = false;
        }

        private void toolStripButtonStart_Click(object sender, System.EventArgs e)
        {
            int hours = (toolStripTextBoxHour.Text == "") ? 0 : Convert.ToInt32(toolStripTextBoxHour.Text);
            int minutes = (toolStripTextBoxMinute.Text == "") ? 0 : Convert.ToInt32(toolStripTextBoxMinute.Text);
            int seconds = (toolStripTextBoxSecond.Text == "") ? 0 : Convert.ToInt32(toolStripTextBoxSecond.Text);
            timerMain.Interval = (hours * 60 * 60 + minutes * 60 + seconds) * 1000;
            timerMain.Enabled = true;
            timerForegroundWindow.Enabled = true;

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

        
    }
}
