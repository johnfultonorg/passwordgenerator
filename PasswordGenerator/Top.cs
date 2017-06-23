﻿using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Top : Form
    {
        public Top()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Password newPassword = new Password();
            Password.PasswordType thisType;
            if (rbSimple.Checked)
            {
                thisType = Password.PasswordType.Simple;
            }
            else if (rbPronouncable.Checked)
            {
                thisType = Password.PasswordType.Pronouncable;
            }
            else
            {
                thisType = Password.PasswordType.Xkcd;
            }


            string result = newPassword.getPassword(thisType, cbNumber.Checked,
                cbCap.Checked, cbSpecial.Checked);

            tbDisplay.AppendText(result + "\r\n");
            tbDisplay.ScrollToCaret();

            tbThis.Text = result;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(tbThis.Text);
        }

        private void Top_Load(object sender, EventArgs e)
        {
            rbXkcd.Select();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAbout = new About();
            frmAbout.ShowDialog(); 
        }

    }
}

