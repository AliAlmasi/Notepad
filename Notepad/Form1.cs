using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialogfore.ShowDialog();
            textBox1.ForeColor = colorDialogfore.Color;
        }

        private void backgroudColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialogback.ShowDialog();
            textBox1.BackColor = colorDialogback.Color;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Notepad - Almasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savefile()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(textBox1.Text);
                sw.Close();
                MessageBox.Show("Saved successfully.\n" + saveFileDialog1.FileName, "Notepad - Almasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Text = saveFileDialog1.FileName;
            }
        }

        private void saveTXTFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savefile();
        }

        private void fontChangaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            textBox1.Font = fontDialog.Font;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                savefile();
            }

            if (e.Control && e.KeyCode == Keys.O)
            {
                loadfile();
            }

            if (e.Alt && e.KeyCode == Keys.X)
            {
                this.Close();
            }
        }

        private void aboutThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AliAlmasi/Notepad");
        }

        private void loadfile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Load a Text File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = false
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string text;
                var fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    text = streamReader.ReadToEnd();
                    textBox1.Text = text;
                    this.Text = openFileDialog1.FileName;
                }
            }
        }

        private void loadTXTFileCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadfile();
        }

        private void Form1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string File in FileList)
            {
                string droptext;
                var fileStream = new FileStream(FileList[0], FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    droptext = streamReader.ReadToEnd();
                    textBox1.Text = droptext;
                    this.Text = FileList[0];
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.WordWrap == true)
            {
                textBox1.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                textBox1.ScrollBars = ScrollBars.Both;
            }
        }

        private void wordWrapToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == true)
            {
                textBox1.WordWrap = true;
            }
            else
            {
                textBox1.WordWrap = false;
            }
        }
    }
}


