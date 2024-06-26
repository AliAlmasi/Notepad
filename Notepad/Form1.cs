﻿using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Notepad {
    public partial class Form1: Form {
        
        string[] _args;
        public Form1(string[] args) {
            InitializeComponent();
            _args = args;
        }

        private void Form1_Load(object sender, EventArgs e) {
            if (_args.Length > 0) {
                if (File.Exists(_args[0])) {
                    textBox1.Text = File.ReadAllText(_args[0]);
                }
            }
            toolStripStatusLabel4.Text = "";
            if (Control.IsKeyLocked(Keys.CapsLock)) toolStripStatusLabel6.Visible = true;
            if (Control.IsKeyLocked(Keys.NumLock)) toolStripStatusLabel8.Visible = true;
        }

        private void backgroudColorToolStripMenuItem_Click(object sender, EventArgs e) {
            colorDialogback.ShowDialog();
            textBox1.BackColor = colorDialogback.Color;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Are you sure to quit?", "Notepad - Almasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void savefile() {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog {
                InitialDirectory = Path.Combine(Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal)), "Documents"),
                Title = "Save file",
                CheckFileExists = false,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Text file|*.txt",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(textBox1.Text);
                sw.Close();
                MessageBox.Show("Saved successfully.\nFile name: " + saveFileDialog1.FileName, "Notepad - Almasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Text = saveFileDialog1.FileName;
            }
        }

        private void saveTXTFileToolStripMenuItem_Click(object sender, EventArgs e) {
            savefile();
        }

        private void fontChangaToolStripMenuItem_Click(object sender, EventArgs e) {
            fontDialog.ShowDialog();
            textBox1.Font = fontDialog.Font;
            textBox1.ForeColor = fontDialog.Color;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.S) savefile();
            if (e.Control && e.KeyCode == Keys.O) loadfile();
            if (e.Control && e.KeyCode == Keys.Q) this.Close();
            if (Control.IsKeyLocked(Keys.CapsLock)) toolStripStatusLabel6.Visible = true;
            if (Control.IsKeyLocked(Keys.NumLock)) toolStripStatusLabel8.Visible = true;
        }

        private void aboutThisToolStripMenuItem_Click(object sender, EventArgs e) {
            string msg = "This is " + Notepad.Program.appVersion + ".\nMake sure to check for newer versions.\nIf there were a newer version, uninstall this version and then install the new one.";
            DialogResult msgbox = MessageBox.Show(msg, "Check for new version", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (msgbox == DialogResult.OK) System.Diagnostics.Process.Start("https://github.com/AliAlmasi/Notepad/releases/latest");
        }

        private void loadfile() {
            OpenFileDialog openFileDialog1 = new OpenFileDialog {
                InitialDirectory = Path.Combine(Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal)), "Documents"),
                Title = "Load a File",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Text files|*.txt|All files|*",
                FilterIndex = 1,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = false
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string text;
                var fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8)) {
                    text = streamReader.ReadToEnd();
                    textBox1.Text = text;
                    this.Text = openFileDialog1.FileName;
                }
            }
        }

        private void loadTXTFileCtrlOToolStripMenuItem_Click(object sender, EventArgs e) {
            loadfile();
        }

        private void Form1_DragOver(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e) {
            string[] FileList = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string File in FileList) {
                string droptext;
                var fileStream = new FileStream(FileList[0], FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8)) {
                    droptext = streamReader.ReadToEnd();
                    textBox1.Text = droptext;
                    this.Text = FileList[0];
                }
            }
        }

        private void wordWrapToolStripMenuItem_CheckedChanged(object sender, EventArgs e) {
            if (wordWrapToolStripMenuItem.Checked == true) {
                textBox1.WordWrap = true;
                textBox1.ScrollBars = ScrollBars.Vertical;
                toolStripStatusLabel1.Visible = true;
            } else {
                textBox1.WordWrap = false;
                textBox1.ScrollBars = ScrollBars.Both;
                toolStripStatusLabel1.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Text.Replace("\r\n", "\n");
            toolStripStatusLabel4.Visible = true;
            toolStripStatusLabel4.Text = textBox1.TextLength.ToString();

            if (toolStripStatusLabel4.Text == "0") toolStripStatusLabel4.Visible = false;
        }

        private void darkMode() {
            this.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.ForeColor = SystemColors.Control;
            textBox1.BackColor = Color.FromArgb(53, 53, 53);
            textBox1.ForeColor = Color.White;
            statusStrip1.BackColor = Color.FromArgb(63, 63, 63);
            statusStrip1.ForeColor = SystemColors.Control;
        }

        private void lightMode() {
            menuStrip1.ForeColor = Color.Black;
            textBox1.BackColor = SystemColors.Control;
            textBox1.ForeColor = SystemColors.WindowText;
            statusStrip1.BackColor = SystemColors.Control;
            statusStrip1.ForeColor = Color.Black;
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e) {
            if (darkModeToolStripMenuItem.Checked == true) darkMode();
            else lightMode();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) {
            if (!(Control.IsKeyLocked(Keys.CapsLock))) {
                toolStripStatusLabel6.Visible = false;
            }
            if (!(Control.IsKeyLocked(Keys.NumLock))) {
                toolStripStatusLabel8.Visible = false;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }
    }
}


