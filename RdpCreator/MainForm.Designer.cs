namespace RdpCreator
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tRDP = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbSelect = new System.Windows.Forms.CheckBox();
            this.lbServers = new System.Windows.Forms.CheckedListBox();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.tbLogins = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNot = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbServerAtributes = new System.Windows.Forms.CheckedListBox();
            this.tbDebug = new System.Windows.Forms.ListBox();
            this.bCreateRDP = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbRdpCopyToClipboard = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tRDP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbUsers.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tRDP);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // tRDP
            // 
            this.tRDP.Controls.Add(this.splitContainer1);
            this.tRDP.Location = new System.Drawing.Point(4, 22);
            this.tRDP.Name = "tRDP";
            this.tRDP.Padding = new System.Windows.Forms.Padding(3);
            this.tRDP.Size = new System.Drawing.Size(825, 501);
            this.tRDP.TabIndex = 0;
            this.tRDP.Text = "Ярлыки RDP";
            this.tRDP.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbSelect);
            this.splitContainer1.Panel1.Controls.Add(this.lbServers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cbRdpCopyToClipboard);
            this.splitContainer1.Panel2.Controls.Add(this.gbUsers);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.tbDebug);
            this.splitContainer1.Panel2.Controls.Add(this.bCreateRDP);
            this.splitContainer1.Size = new System.Drawing.Size(819, 495);
            this.splitContainer1.SplitterDistance = 273;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbSelect
            // 
            this.cbSelect.AutoSize = true;
            this.cbSelect.Checked = true;
            this.cbSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSelect.Location = new System.Drawing.Point(0, 0);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(273, 17);
            this.cbSelect.TabIndex = 1;
            this.cbSelect.Text = "Выделить все";
            this.cbSelect.UseVisualStyleBackColor = true;
            this.cbSelect.CheckedChanged += new System.EventHandler(this.cbSelect_CheckedChanged);
            // 
            // lbServers
            // 
            this.lbServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbServers.FormattingEnabled = true;
            this.lbServers.Location = new System.Drawing.Point(0, 30);
            this.lbServers.Name = "lbServers";
            this.lbServers.Size = new System.Drawing.Size(273, 469);
            this.lbServers.TabIndex = 0;
            this.lbServers.SelectedIndexChanged += new System.EventHandler(this.lbServers_SelectedIndexChanged);
            this.lbServers.SelectedValueChanged += new System.EventHandler(this.lbServers_SelectedValueChanged);
            this.lbServers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbServers_KeyUp);
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.tbLogins);
            this.gbUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbUsers.Location = new System.Drawing.Point(0, 200);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(200, 239);
            this.gbUsers.TabIndex = 9;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Логины пользователей";
            // 
            // tbLogins
            // 
            this.tbLogins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogins.Location = new System.Drawing.Point(3, 16);
            this.tbLogins.Multiline = true;
            this.tbLogins.Name = "tbLogins";
            this.tbLogins.Size = new System.Drawing.Size(194, 220);
            this.tbLogins.TabIndex = 4;
            this.tbLogins.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbNot);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сервера без атрибутов";
            // 
            // cbNot
            // 
            this.cbNot.ColumnWidth = 160;
            this.cbNot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNot.FormattingEnabled = true;
            this.cbNot.HorizontalScrollbar = true;
            this.cbNot.Location = new System.Drawing.Point(3, 16);
            this.cbNot.MultiColumn = true;
            this.cbNot.Name = "cbNot";
            this.cbNot.Size = new System.Drawing.Size(536, 81);
            this.cbNot.TabIndex = 2;
            this.cbNot.SelectedIndexChanged += new System.EventHandler(this.lbServerAtributes_SelectedIndexChanged);
            this.cbNot.SelectedValueChanged += new System.EventHandler(this.lbServerAtributes_SelectedValueChanged);
            this.cbNot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbServerAtributes_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbServerAtributes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сервера с атрибутами";
            // 
            // lbServerAtributes
            // 
            this.lbServerAtributes.ColumnWidth = 160;
            this.lbServerAtributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbServerAtributes.FormattingEnabled = true;
            this.lbServerAtributes.HorizontalScrollbar = true;
            this.lbServerAtributes.Location = new System.Drawing.Point(3, 16);
            this.lbServerAtributes.MultiColumn = true;
            this.lbServerAtributes.Name = "lbServerAtributes";
            this.lbServerAtributes.Size = new System.Drawing.Size(536, 81);
            this.lbServerAtributes.TabIndex = 2;
            this.lbServerAtributes.SelectedIndexChanged += new System.EventHandler(this.lbServerAtributes_SelectedIndexChanged);
            this.lbServerAtributes.SelectedValueChanged += new System.EventHandler(this.lbServerAtributes_SelectedValueChanged);
            this.lbServerAtributes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbServerAtributes_KeyPress);
            // 
            // tbDebug
            // 
            this.tbDebug.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbDebug.FormattingEnabled = true;
            this.tbDebug.Location = new System.Drawing.Point(0, 439);
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.Size = new System.Drawing.Size(542, 56);
            this.tbDebug.TabIndex = 3;
            // 
            // bCreateRDP
            // 
            this.bCreateRDP.Location = new System.Drawing.Point(337, 333);
            this.bCreateRDP.Name = "bCreateRDP";
            this.bCreateRDP.Size = new System.Drawing.Size(75, 23);
            this.bCreateRDP.TabIndex = 2;
            this.bCreateRDP.Text = "Создать RDP";
            this.bCreateRDP.UseVisualStyleBackColor = true;
            this.bCreateRDP.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 530);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(833, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // StatusBar
            // 
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // cbRdpCopyToClipboard
            // 
            this.cbRdpCopyToClipboard.AutoSize = true;
            this.cbRdpCopyToClipboard.Checked = global::RdpCreator.Properties.Settings.Default.ToClipboard;
            this.cbRdpCopyToClipboard.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RdpCreator.Properties.Settings.Default, "ToClipboard", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbRdpCopyToClipboard.Location = new System.Drawing.Point(337, 231);
            this.cbRdpCopyToClipboard.Name = "cbRdpCopyToClipboard";
            this.cbRdpCopyToClipboard.Size = new System.Drawing.Size(129, 17);
            this.cbRdpCopyToClipboard.TabIndex = 11;
            this.cbRdpCopyToClipboard.Text = "Копировать в буфер";
            this.cbRdpCopyToClipboard.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 552);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Основная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tRDP.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbUsers.ResumeLayout(false);
            this.gbUsers.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tRDP;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox lbServers;
        private System.Windows.Forms.Button bCreateRDP;
        private System.Windows.Forms.ListBox tbDebug;
        private System.Windows.Forms.TextBox tbLogins;
        private System.Windows.Forms.CheckBox cbSelect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox cbNot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox lbServerAtributes;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar;
        public System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.CheckBox cbRdpCopyToClipboard;
    }
}

