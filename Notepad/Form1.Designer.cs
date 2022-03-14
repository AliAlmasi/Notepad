﻿namespace Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.colorDialogfore = new System.Windows.Forms.ColorDialog();
            this.colorDialogback = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.saveTXTFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTXTFileCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontChangaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroudColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(560, 422);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.fontColorToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTXTFileToolStripMenuItem,
            this.loadTXTFileCtrlOToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.saveToolStripMenuItem.Text = "&File";
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontChangaToolStripMenuItem,
            this.fontColorToolStripMenuItem1,
            this.backgroudColorToolStripMenuItem});
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.fontColorToolStripMenuItem.Text = "&Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutThisToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem,
            this.toolStripTextBox1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.toolStripTextBox1.Font = new System.Drawing.Font("Pokémon DS Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(120, 24);
            this.toolStripTextBox1.Text = "Ali Almasi - 2022";
            this.toolStripTextBox1.ToolTipText = "Notepad - Redesigned by Ali Almasi 2022";
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic);
            this.fontDialog.FontMustExist = true;
            this.fontDialog.MaxSize = 16;
            this.fontDialog.MinSize = 9;
            // 
            // saveTXTFileToolStripMenuItem
            // 
            this.saveTXTFileToolStripMenuItem.Image = global::Notepad.Properties.Resources.black_save_icon_2;
            this.saveTXTFileToolStripMenuItem.Name = "saveTXTFileToolStripMenuItem";
            this.saveTXTFileToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.saveTXTFileToolStripMenuItem.Text = "&Save TXT file (Ctrl+S)";
            this.saveTXTFileToolStripMenuItem.Click += new System.EventHandler(this.saveTXTFileToolStripMenuItem_Click);
            // 
            // loadTXTFileCtrlOToolStripMenuItem
            // 
            this.loadTXTFileCtrlOToolStripMenuItem.Image = global::Notepad.Properties.Resources._296_2969762_all_photo_png_clipart_open_file_icon_png;
            this.loadTXTFileCtrlOToolStripMenuItem.Name = "loadTXTFileCtrlOToolStripMenuItem";
            this.loadTXTFileCtrlOToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.loadTXTFileCtrlOToolStripMenuItem.Text = "&Load TXT file (Ctrl+O)";
            this.loadTXTFileCtrlOToolStripMenuItem.Click += new System.EventHandler(this.loadTXTFileCtrlOToolStripMenuItem_Click);
            // 
            // fontChangaToolStripMenuItem
            // 
            this.fontChangaToolStripMenuItem.Image = global::Notepad.Properties.Resources.bd22db5697d828c3fb0562827e5a2676;
            this.fontChangaToolStripMenuItem.Name = "fontChangaToolStripMenuItem";
            this.fontChangaToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.fontChangaToolStripMenuItem.Text = "Change &Font";
            this.fontChangaToolStripMenuItem.Click += new System.EventHandler(this.fontChangaToolStripMenuItem_Click);
            // 
            // fontColorToolStripMenuItem1
            // 
            this.fontColorToolStripMenuItem1.Image = global::Notepad.Properties.Resources.bd22db5697d828c3fb0562827e5a2676_2;
            this.fontColorToolStripMenuItem1.Name = "fontColorToolStripMenuItem1";
            this.fontColorToolStripMenuItem1.Size = new System.Drawing.Size(250, 22);
            this.fontColorToolStripMenuItem1.Text = "Change Font &Color";
            this.fontColorToolStripMenuItem1.Click += new System.EventHandler(this.fontColorToolStripMenuItem1_Click);
            // 
            // backgroudColorToolStripMenuItem
            // 
            this.backgroudColorToolStripMenuItem.Image = global::Notepad.Properties.Resources.kisspng_font_awesome_computer_icons_editing_font_report_border_5ae0ba2530e032_2703211515246771572002;
            this.backgroudColorToolStripMenuItem.Name = "backgroudColorToolStripMenuItem";
            this.backgroudColorToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.backgroudColorToolStripMenuItem.Text = "Change &Backgroud Color";
            this.backgroudColorToolStripMenuItem.Click += new System.EventHandler(this.backgroudColorToolStripMenuItem_Click);
            // 
            // aboutThisToolStripMenuItem
            // 
            this.aboutThisToolStripMenuItem.Image = global::Notepad.Properties.Resources._5847f98fcef1014c0b5e48c0;
            this.aboutThisToolStripMenuItem.Name = "aboutThisToolStripMenuItem";
            this.aboutThisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutThisToolStripMenuItem.Text = "&Github";
            this.aboutThisToolStripMenuItem.Click += new System.EventHandler(this.aboutThisToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = global::Notepad.Properties.Resources.img_266983;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "&Quit (Alt+X)";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notepad - Almasi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTXTFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backgroudColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialogfore;
        private System.Windows.Forms.ColorDialog colorDialogback;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontChangaToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem loadTXTFileCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}
