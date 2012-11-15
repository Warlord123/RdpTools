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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tRDP = new System.Windows.Forms.TabPage();
            this.cbSelect = new System.Windows.Forms.CheckBox();
            this.lbServers = new System.Windows.Forms.CheckedListBox();
            this.cbRdpCopyToClipboard = new System.Windows.Forms.CheckBox();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.tbDebug = new System.Windows.Forms.ListBox();
            this.bCreateRDP = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.scMainLeft = new System.Windows.Forms.SplitContainer();
            this.gbServerFilters = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbLogins = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNot = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbServerAtributes = new System.Windows.Forms.CheckedListBox();
            this.scServerFilters = new System.Windows.Forms.SplitContainer();
            this.cbFilters = new System.Windows.Forms.CheckBox();
            this.tCreateUser = new System.Windows.Forms.TabPage();
            this.tcMain.SuspendLayout();
            this.tRDP.SuspendLayout();
            this.gbUsers.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMainLeft)).BeginInit();
            this.scMainLeft.Panel1.SuspendLayout();
            this.scMainLeft.Panel2.SuspendLayout();
            this.scMainLeft.SuspendLayout();
            this.gbServerFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scServerFilters)).BeginInit();
            this.scServerFilters.Panel1.SuspendLayout();
            this.scServerFilters.Panel2.SuspendLayout();
            this.scServerFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tCreateUser);
            this.tcMain.Controls.Add(this.tRDP);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(600, 395);
            this.tcMain.TabIndex = 0;
            // 
            // tRDP
            // 
            this.tRDP.Controls.Add(this.panel1);
            this.tRDP.Controls.Add(this.gbUsers);
            this.tRDP.Location = new System.Drawing.Point(4, 22);
            this.tRDP.Name = "tRDP";
            this.tRDP.Padding = new System.Windows.Forms.Padding(3);
            this.tRDP.Size = new System.Drawing.Size(592, 369);
            this.tRDP.TabIndex = 0;
            this.tRDP.Text = "Ярлыки RDP";
            this.tRDP.UseVisualStyleBackColor = true;
            // 
            // cbSelect
            // 
            this.cbSelect.AutoSize = true;
            this.cbSelect.Checked = true;
            this.cbSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSelect.Location = new System.Drawing.Point(0, 3);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(97, 17);
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
            this.lbServers.Location = new System.Drawing.Point(3, 31);
            this.lbServers.Name = "lbServers";
            this.lbServers.Size = new System.Drawing.Size(240, 514);
            this.lbServers.TabIndex = 0;
            this.lbServers.SelectedIndexChanged += new System.EventHandler(this.lbServers_SelectedIndexChanged);
            this.lbServers.SelectedValueChanged += new System.EventHandler(this.lbServers_SelectedValueChanged);
            this.lbServers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbServers_KeyUp);
            // 
            // cbRdpCopyToClipboard
            // 
            this.cbRdpCopyToClipboard.AutoSize = true;
            this.cbRdpCopyToClipboard.Checked = global::RdpCreator.Properties.Settings.Default.ToClipboard;
            this.cbRdpCopyToClipboard.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RdpCreator.Properties.Settings.Default, "ToClipboard", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbRdpCopyToClipboard.Location = new System.Drawing.Point(130, 5);
            this.cbRdpCopyToClipboard.Name = "cbRdpCopyToClipboard";
            this.cbRdpCopyToClipboard.Size = new System.Drawing.Size(129, 17);
            this.cbRdpCopyToClipboard.TabIndex = 11;
            this.cbRdpCopyToClipboard.Text = "Копировать в буфер";
            this.cbRdpCopyToClipboard.UseVisualStyleBackColor = true;
            // 
            // gbUsers
            // 
            this.gbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUsers.Controls.Add(this.tbLogins);
            this.gbUsers.Location = new System.Drawing.Point(6, 6);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(586, 333);
            this.gbUsers.TabIndex = 9;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Логины пользователей";
            // 
            // tbDebug
            // 
            this.tbDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDebug.FormattingEnabled = true;
            this.tbDebug.Location = new System.Drawing.Point(0, 0);
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.Size = new System.Drawing.Size(600, 26);
            this.tbDebug.TabIndex = 3;
            // 
            // bCreateRDP
            // 
            this.bCreateRDP.Location = new System.Drawing.Point(29, 5);
            this.bCreateRDP.Name = "bCreateRDP";
            this.bCreateRDP.Size = new System.Drawing.Size(75, 19);
            this.bCreateRDP.TabIndex = 2;
            this.bCreateRDP.Text = "Создать RDP";
            this.bCreateRDP.UseVisualStyleBackColor = true;
            this.bCreateRDP.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 549);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(850, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // StatusBar
            // 
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cbFilters);
            this.splitContainer2.Panel1.Controls.Add(this.cbSelect);
            this.splitContainer2.Panel1.Controls.Add(this.lbServers);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.scMainLeft);
            this.splitContainer2.Size = new System.Drawing.Size(850, 549);
            this.splitContainer2.SplitterDistance = 246;
            this.splitContainer2.TabIndex = 2;
            // 
            // scMainLeft
            // 
            this.scMainLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMainLeft.Location = new System.Drawing.Point(0, 0);
            this.scMainLeft.Name = "scMainLeft";
            this.scMainLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMainLeft.Panel1
            // 
            this.scMainLeft.Panel1.Controls.Add(this.gbServerFilters);
            // 
            // scMainLeft.Panel2
            // 
            this.scMainLeft.Panel2.Controls.Add(this.splitContainer3);
            this.scMainLeft.Size = new System.Drawing.Size(600, 549);
            this.scMainLeft.SplitterDistance = 120;
            this.scMainLeft.TabIndex = 0;
            // 
            // gbServerFilters
            // 
            this.gbServerFilters.Controls.Add(this.scServerFilters);
            this.gbServerFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbServerFilters.Location = new System.Drawing.Point(0, 0);
            this.gbServerFilters.Name = "gbServerFilters";
            this.gbServerFilters.Size = new System.Drawing.Size(600, 120);
            this.gbServerFilters.TabIndex = 0;
            this.gbServerFilters.TabStop = false;
            this.gbServerFilters.Text = "Фильтры серверов";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tcMain);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tbDebug);
            this.splitContainer3.Size = new System.Drawing.Size(600, 425);
            this.splitContainer3.SplitterDistance = 395;
            this.splitContainer3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bCreateRDP);
            this.panel1.Controls.Add(this.cbRdpCopyToClipboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 27);
            this.panel1.TabIndex = 12;
            // 
            // tbLogins
            // 
            this.tbLogins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogins.Location = new System.Drawing.Point(3, 16);
            this.tbLogins.Multiline = true;
            this.tbLogins.Name = "tbLogins";
            this.tbLogins.Size = new System.Drawing.Size(580, 314);
            this.tbLogins.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbNot);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 52);
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
            this.cbNot.Size = new System.Drawing.Size(588, 33);
            this.cbNot.TabIndex = 2;
            this.cbNot.SelectedIndexChanged += new System.EventHandler(this.lbServerAtributes_SelectedIndexChanged);
            this.cbNot.SelectedValueChanged += new System.EventHandler(this.lbServerAtributes_SelectedValueChanged);
            this.cbNot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbServerAtributes_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbServerAtributes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 45);
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
            this.lbServerAtributes.Size = new System.Drawing.Size(588, 26);
            this.lbServerAtributes.TabIndex = 2;
            this.lbServerAtributes.SelectedIndexChanged += new System.EventHandler(this.lbServerAtributes_SelectedIndexChanged);
            this.lbServerAtributes.SelectedValueChanged += new System.EventHandler(this.lbServerAtributes_SelectedValueChanged);
            this.lbServerAtributes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbServerAtributes_KeyPress);
            // 
            // scServerFilters
            // 
            this.scServerFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scServerFilters.Location = new System.Drawing.Point(3, 16);
            this.scServerFilters.Name = "scServerFilters";
            this.scServerFilters.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scServerFilters.Panel1
            // 
            this.scServerFilters.Panel1.Controls.Add(this.groupBox1);
            // 
            // scServerFilters.Panel2
            // 
            this.scServerFilters.Panel2.Controls.Add(this.groupBox2);
            this.scServerFilters.Size = new System.Drawing.Size(594, 101);
            this.scServerFilters.SplitterDistance = 45;
            this.scServerFilters.TabIndex = 0;
            // 
            // cbFilters
            // 
            this.cbFilters.AutoSize = true;
            this.cbFilters.Location = new System.Drawing.Point(146, 3);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(66, 17);
            this.cbFilters.TabIndex = 2;
            this.cbFilters.Text = "Фильтр";
            this.cbFilters.UseVisualStyleBackColor = true;
            this.cbFilters.CheckedChanged += new System.EventHandler(this.cbFilters_CheckedChanged);
            // 
            // tCreateUser
            // 
            this.tCreateUser.Location = new System.Drawing.Point(4, 22);
            this.tCreateUser.Name = "tCreateUser";
            this.tCreateUser.Padding = new System.Windows.Forms.Padding(3);
            this.tCreateUser.Size = new System.Drawing.Size(592, 369);
            this.tCreateUser.TabIndex = 1;
            this.tCreateUser.Text = "Регистрация пользователя";
            this.tCreateUser.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 571);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.statusStrip);
            this.Name = "MainForm";
            this.Text = "Основная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMain.ResumeLayout(false);
            this.tRDP.ResumeLayout(false);
            this.gbUsers.ResumeLayout(false);
            this.gbUsers.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.scMainLeft.Panel1.ResumeLayout(false);
            this.scMainLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMainLeft)).EndInit();
            this.scMainLeft.ResumeLayout(false);
            this.gbServerFilters.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.scServerFilters.Panel1.ResumeLayout(false);
            this.scServerFilters.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scServerFilters)).EndInit();
            this.scServerFilters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tRDP;
        private System.Windows.Forms.CheckedListBox lbServers;
        private System.Windows.Forms.Button bCreateRDP;
        private System.Windows.Forms.ListBox tbDebug;
        private System.Windows.Forms.CheckBox cbSelect;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar;
        public System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.CheckBox cbRdpCopyToClipboard;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbServerFilters;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbLogins;
        private System.Windows.Forms.SplitContainer scServerFilters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox lbServerAtributes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox cbNot;
        private System.Windows.Forms.SplitContainer scMainLeft;
        private System.Windows.Forms.CheckBox cbFilters;
        private System.Windows.Forms.TabPage tCreateUser;
    }
}

