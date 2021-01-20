using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KIT_Manager_v2.UI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://facebook.com/Yoshino.Akii");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
