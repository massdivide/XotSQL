namespace XtoSQL
{
    partial class XtoSQLForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            LogBox = new ListBox();
            ConvertSQLBUTTON = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.None;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(45, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += XtoSQLForm_Open;
            openToolStripMenuItem.DoubleClick += XtoSQLForm_Open;
            // 
            // LogBox
            // 
            LogBox.FormattingEnabled = true;
            LogBox.ItemHeight = 15;
            LogBox.Location = new Point(8, 38);
            LogBox.Name = "LogBox";
            LogBox.Size = new Size(780, 304);
            LogBox.TabIndex = 1;
            LogBox.SelectedIndexChanged += LogBox_SelectedIndexChanged;
            // 
            // ConvertSQLBUTTON
            // 
            ConvertSQLBUTTON.Location = new Point(38, 348);
            ConvertSQLBUTTON.Name = "ConvertSQLBUTTON";
            ConvertSQLBUTTON.Size = new Size(708, 90);
            ConvertSQLBUTTON.TabIndex = 2;
            ConvertSQLBUTTON.Text = "Convert";
            ConvertSQLBUTTON.UseVisualStyleBackColor = true;
            ConvertSQLBUTTON.Click += ConvertSQLBUTTON_Click;
            // 
            // XtoSQLForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ConvertSQLBUTTON);
            Controls.Add(LogBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "XtoSQLForm";
            Text = "XtoSQL - By MassDivide";
            Load += XtoSQLForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ListBox LogBox;
        private Button ConvertSQLBUTTON;
    }
}
