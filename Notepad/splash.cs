using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = BackgroundImage.Size;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            this.Close();
        }
    }
}
