using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Notepad {
    partial class AboutBox1: Form {
        public AboutBox1() {
            InitializeComponent();
        }

        private void AboutBox1_Load(object sender, EventArgs e) {
            this.Text += " - " + Notepad.Program.appVersion;
        }

        private void AboutBox1_FormClosing(object sender, FormClosingEventArgs e) {
            AboutBox1 ab = new AboutBox1();
            ab.Close();
        }
    }
}
