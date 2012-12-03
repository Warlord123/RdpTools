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
            this.components = new System.ComponentModel.Container();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tCreateUser = new System.Windows.Forms.TabPage();
            this.gbNewUserDefault = new System.Windows.Forms.GroupBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.button2 = new System.Windows.Forms.Button();
            this.gvNewUsers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tRDP = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCreateRDP = new System.Windows.Forms.Button();
            this.cbRdpCopyToClipboard = new System.Windows.Forms.CheckBox();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.tbLogins = new System.Windows.Forms.TextBox();
            this.cbSelect = new System.Windows.Forms.CheckBox();
            this.lbServers = new System.Windows.Forms.CheckedListBox();
            this.tbDebug = new System.Windows.Forms.ListBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cbFilters = new System.Windows.Forms.CheckBox();
            this.scMainLeft = new System.Windows.Forms.SplitContainer();
            this.gbServerFilters = new System.Windows.Forms.GroupBox();
            this.scServerFilters = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbServerAtributes = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNot = new System.Windows.Forms.CheckedListBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tServerList = new System.Windows.Forms.TabPage();
            this.bCreateList = new System.Windows.Forms.Button();
            this.cmtbDebug = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsSaveToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordExpiredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNewUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tcMain.SuspendLayout();
            this.tCreateUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNewUsers)).BeginInit();
            this.tRDP.SuspendLayout();
            this.panel1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.scServerFilters)).BeginInit();
            this.scServerFilters.Panel1.SuspendLayout();
            this.scServerFilters.Panel2.SuspendLayout();
            this.scServerFilters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tServerList.SuspendLayout();
            this.cmtbDebug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tNewUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tCreateUser);
            this.tcMain.Controls.Add(this.tRDP);
            this.tcMain.Controls.Add(this.tServerList);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(801, 490);
            this.tcMain.TabIndex = 0;
            // 
            // tCreateUser
            // 
            this.tCreateUser.Controls.Add(this.gbNewUserDefault);
            this.tCreateUser.Controls.Add(this.propertyGrid1);
            this.tCreateUser.Controls.Add(this.button2);
            this.tCreateUser.Controls.Add(this.gvNewUsers);
            this.tCreateUser.Controls.Add(this.button1);
            this.tCreateUser.Location = new System.Drawing.Point(4, 25);
            this.tCreateUser.Margin = new System.Windows.Forms.Padding(4);
            this.tCreateUser.Name = "tCreateUser";
            this.tCreateUser.Padding = new System.Windows.Forms.Padding(4);
            this.tCreateUser.Size = new System.Drawing.Size(793, 461);
            this.tCreateUser.TabIndex = 1;
            this.tCreateUser.Text = "Регистрация пользователя";
            this.tCreateUser.UseVisualStyleBackColor = true;
            // 
            // gbNewUserDefault
            // 
            this.gbNewUserDefault.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbNewUserDefault.Location = new System.Drawing.Point(4, 216);
            this.gbNewUserDefault.Margin = new System.Windows.Forms.Padding(4);
            this.gbNewUserDefault.Name = "gbNewUserDefault";
            this.gbNewUserDefault.Padding = new System.Windows.Forms.Padding(4);
            this.gbNewUserDefault.Size = new System.Drawing.Size(785, 63);
            this.gbNewUserDefault.TabIndex = 4;
            this.gbNewUserDefault.TabStop = false;
            this.gbNewUserDefault.Text = "По умолчанию";
            this.gbNewUserDefault.Enter += new System.EventHandler(this.gbNewUserDefault_Enter);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(347, 293);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.propertyGrid1.Size = new System.Drawing.Size(439, 158);
            this.propertyGrid1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 363);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gvNewUsers
            // 
            this.gvNewUsers.AutoGenerateColumns = false;
            this.gvNewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvNewUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gvNewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.passwordExpiredDataGridViewCheckBoxColumn,
            this.groupDataGridViewTextBoxColumn});
            this.gvNewUsers.DataSource = this.tNewUserBindingSource;
            this.gvNewUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvNewUsers.Location = new System.Drawing.Point(4, 4);
            this.gvNewUsers.Margin = new System.Windows.Forms.Padding(4);
            this.gvNewUsers.Name = "gvNewUsers";
            this.gvNewUsers.RowHeadersWidth = 12;
            this.gvNewUsers.RowTemplate.Height = 24;
            this.gvNewUsers.Size = new System.Drawing.Size(785, 212);
            this.gvNewUsers.TabIndex = 1;
            this.gvNewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvNewUsers_CellClick);
            this.gvNewUsers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvNewUsers_CellEndEdit);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tRDP
            // 
            this.tRDP.Controls.Add(this.panel1);
            this.tRDP.Controls.Add(this.gbUsers);
            this.tRDP.Location = new System.Drawing.Point(4, 25);
            this.tRDP.Margin = new System.Windows.Forms.Padding(4);
            this.tRDP.Name = "tRDP";
            this.tRDP.Padding = new System.Windows.Forms.Padding(4);
            this.tRDP.Size = new System.Drawing.Size(793, 461);
            this.tRDP.TabIndex = 0;
            this.tRDP.Text = "Ярлыки RDP";
            this.tRDP.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bCreateRDP);
            this.panel1.Controls.Add(this.cbRdpCopyToClipboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 424);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 33);
            this.panel1.TabIndex = 12;
            // 
            // bCreateRDP
            // 
            this.bCreateRDP.Location = new System.Drawing.Point(39, 6);
            this.bCreateRDP.Margin = new System.Windows.Forms.Padding(4);
            this.bCreateRDP.Name = "bCreateRDP";
            this.bCreateRDP.Size = new System.Drawing.Size(100, 23);
            this.bCreateRDP.TabIndex = 2;
            this.bCreateRDP.Text = "Создать RDP";
            this.bCreateRDP.UseVisualStyleBackColor = true;
            this.bCreateRDP.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbRdpCopyToClipboard
            // 
            this.cbRdpCopyToClipboard.AutoSize = true;
            this.cbRdpCopyToClipboard.Checked = global::RdpCreator.Properties.Settings.Default.ToClipboard;
            this.cbRdpCopyToClipboard.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RdpCreator.Properties.Settings.Default, "ToClipboard", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbRdpCopyToClipboard.Location = new System.Drawing.Point(173, 6);
            this.cbRdpCopyToClipboard.Margin = new System.Windows.Forms.Padding(4);
            this.cbRdpCopyToClipboard.Name = "cbRdpCopyToClipboard";
            this.cbRdpCopyToClipboard.Size = new System.Drawing.Size(165, 21);
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
            this.gbUsers.Location = new System.Drawing.Point(8, 7);
            this.gbUsers.Margin = new System.Windows.Forms.Padding(4);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Padding = new System.Windows.Forms.Padding(4);
            this.gbUsers.Size = new System.Drawing.Size(781, 410);
            this.gbUsers.TabIndex = 9;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Логины пользователей";
            // 
            // tbLogins
            // 
            this.tbLogins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogins.Location = new System.Drawing.Point(4, 19);
            this.tbLogins.Margin = new System.Windows.Forms.Padding(4);
            this.tbLogins.Multiline = true;
            this.tbLogins.Name = "tbLogins";
            this.tbLogins.Size = new System.Drawing.Size(773, 387);
            this.tbLogins.TabIndex = 0;
            // 
            // cbSelect
            // 
            this.cbSelect.AutoSize = true;
            this.cbSelect.Checked = true;
            this.cbSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSelect.Location = new System.Drawing.Point(0, 4);
            this.cbSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(121, 21);
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
            this.lbServers.Location = new System.Drawing.Point(4, 38);
            this.lbServers.Margin = new System.Windows.Forms.Padding(4);
            this.lbServers.Name = "lbServers";
            this.lbServers.Size = new System.Drawing.Size(318, 616);
            this.lbServers.TabIndex = 0;
            this.lbServers.SelectedIndexChanged += new System.EventHandler(this.lbServers_SelectedIndexChanged);
            this.lbServers.SelectedValueChanged += new System.EventHandler(this.lbServers_SelectedValueChanged);
            this.lbServers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbServers_KeyUp);
            // 
            // tbDebug
            // 
            this.tbDebug.ContextMenuStrip = this.cmtbDebug;
            this.tbDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDebug.FormattingEnabled = true;
            this.tbDebug.ItemHeight = 16;
            this.tbDebug.Location = new System.Drawing.Point(0, 0);
            this.tbDebug.Margin = new System.Windows.Forms.Padding(4);
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.Size = new System.Drawing.Size(801, 33);
            this.tbDebug.TabIndex = 3;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 681);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1133, 22);
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
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
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
            this.splitContainer2.Size = new System.Drawing.Size(1133, 681);
            this.splitContainer2.SplitterDistance = 327;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 2;
            // 
            // cbFilters
            // 
            this.cbFilters.AutoSize = true;
            this.cbFilters.Location = new System.Drawing.Point(195, 4);
            this.cbFilters.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(81, 21);
            this.cbFilters.TabIndex = 2;
            this.cbFilters.Text = "Фильтр";
            this.cbFilters.UseVisualStyleBackColor = true;
            this.cbFilters.CheckedChanged += new System.EventHandler(this.cbFilters_CheckedChanged);
            // 
            // scMainLeft
            // 
            this.scMainLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMainLeft.Location = new System.Drawing.Point(0, 0);
            this.scMainLeft.Margin = new System.Windows.Forms.Padding(4);
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
            this.scMainLeft.Size = new System.Drawing.Size(801, 681);
            this.scMainLeft.SplitterDistance = 148;
            this.scMainLeft.SplitterWidth = 5;
            this.scMainLeft.TabIndex = 0;
            // 
            // gbServerFilters
            // 
            this.gbServerFilters.Controls.Add(this.scServerFilters);
            this.gbServerFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbServerFilters.Location = new System.Drawing.Point(0, 0);
            this.gbServerFilters.Margin = new System.Windows.Forms.Padding(4);
            this.gbServerFilters.Name = "gbServerFilters";
            this.gbServerFilters.Padding = new System.Windows.Forms.Padding(4);
            this.gbServerFilters.Size = new System.Drawing.Size(801, 148);
            this.gbServerFilters.TabIndex = 0;
            this.gbServerFilters.TabStop = false;
            this.gbServerFilters.Text = "Фильтры серверов";
            // 
            // scServerFilters
            // 
            this.scServerFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scServerFilters.Location = new System.Drawing.Point(4, 19);
            this.scServerFilters.Margin = new System.Windows.Forms.Padding(4);
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
            this.scServerFilters.Size = new System.Drawing.Size(793, 125);
            this.scServerFilters.SplitterDistance = 54;
            this.scServerFilters.SplitterWidth = 5;
            this.scServerFilters.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbServerAtributes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(793, 54);
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
            this.lbServerAtributes.Location = new System.Drawing.Point(4, 19);
            this.lbServerAtributes.Margin = new System.Windows.Forms.Padding(4);
            this.lbServerAtributes.MultiColumn = true;
            this.lbServerAtributes.Name = "lbServerAtributes";
            this.lbServerAtributes.Size = new System.Drawing.Size(785, 31);
            this.lbServerAtributes.TabIndex = 2;
            this.lbServerAtributes.SelectedIndexChanged += new System.EventHandler(this.lbServerAtributes_SelectedIndexChanged);
            this.lbServerAtributes.SelectedValueChanged += new System.EventHandler(this.lbServerAtributes_SelectedValueChanged);
            this.lbServerAtributes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbServerAtributes_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbNot);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(793, 66);
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
            this.cbNot.Location = new System.Drawing.Point(4, 19);
            this.cbNot.Margin = new System.Windows.Forms.Padding(4);
            this.cbNot.MultiColumn = true;
            this.cbNot.Name = "cbNot";
            this.cbNot.Size = new System.Drawing.Size(785, 43);
            this.cbNot.TabIndex = 2;
            this.cbNot.SelectedIndexChanged += new System.EventHandler(this.lbServerAtributes_SelectedIndexChanged);
            this.cbNot.SelectedValueChanged += new System.EventHandler(this.lbServerAtributes_SelectedValueChanged);
            this.cbNot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbServerAtributes_KeyPress);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
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
            this.splitContainer3.Size = new System.Drawing.Size(801, 528);
            this.splitContainer3.SplitterDistance = 490;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // tServerList
            // 
            this.tServerList.Controls.Add(this.bCreateList);
            this.tServerList.Location = new System.Drawing.Point(4, 25);
            this.tServerList.Name = "tServerList";
            this.tServerList.Padding = new System.Windows.Forms.Padding(3);
            this.tServerList.Size = new System.Drawing.Size(793, 461);
            this.tServerList.TabIndex = 2;
            this.tServerList.Text = "Списки серверов";
            this.tServerList.UseVisualStyleBackColor = true;
            // 
            // bCreateList
            // 
            this.bCreateList.Location = new System.Drawing.Point(19, 33);
            this.bCreateList.Name = "bCreateList";
            this.bCreateList.Size = new System.Drawing.Size(119, 51);
            this.bCreateList.TabIndex = 0;
            this.bCreateList.Text = "Создать список";
            this.bCreateList.UseVisualStyleBackColor = true;
            this.bCreateList.Click += new System.EventHandler(this.bCreateList_Click);
            // 
            // cmtbDebug
            // 
            this.cmtbDebug.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSaveToFile});
            this.cmtbDebug.Name = "cmtbDebug";
            this.cmtbDebug.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmtbDebug.Size = new System.Drawing.Size(204, 26);
            this.cmtbDebug.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmtbDebug_ItemClicked);
            // 
            // tsSaveToFile
            // 
            this.tsSaveToFile.Name = "tsSaveToFile";
            this.tsSaveToFile.Size = new System.Drawing.Size(203, 22);
            this.tsSaveToFile.Text = "Сохранить в файл";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // passwordExpiredDataGridViewCheckBoxColumn
            // 
            this.passwordExpiredDataGridViewCheckBoxColumn.DataPropertyName = "PasswordExpired";
            this.passwordExpiredDataGridViewCheckBoxColumn.HeaderText = "PasswordExpired";
            this.passwordExpiredDataGridViewCheckBoxColumn.Name = "passwordExpiredDataGridViewCheckBoxColumn";
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            // 
            // tNewUserBindingSource
            // 
            this.tNewUserBindingSource.AllowNew = true;
            this.tNewUserBindingSource.DataSource = typeof(RdpCreator.TNewUser);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 703);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.statusStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Основная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMain.ResumeLayout(false);
            this.tCreateUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvNewUsers)).EndInit();
            this.tRDP.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
            this.scServerFilters.Panel1.ResumeLayout(false);
            this.scServerFilters.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scServerFilters)).EndInit();
            this.scServerFilters.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tServerList.ResumeLayout(false);
            this.cmtbDebug.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tNewUserBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gvNewUsers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.BindingSource tNewUserBindingSource;
        private System.Windows.Forms.GroupBox gbNewUserDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn passwordExpiredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tServerList;
        private System.Windows.Forms.Button bCreateList;
        private System.Windows.Forms.ContextMenuStrip cmtbDebug;
        private System.Windows.Forms.ToolStripMenuItem tsSaveToFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

