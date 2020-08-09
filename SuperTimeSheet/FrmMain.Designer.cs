namespace SuperTimeSheet
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridTasks = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClearTaskDuration = new System.Windows.Forms.Button();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.dtTaskDate = new System.Windows.Forms.DateTimePicker();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblTotalDuration = new System.Windows.Forms.Label();
            this.lblTaskDuration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaskDuration = new System.Windows.Forms.TextBox();
            this.radioDurationMinutes = new System.Windows.Forms.RadioButton();
            this.lblTaskDate = new System.Windows.Forms.Label();
            this.radioDurationHours = new System.Windows.Forms.RadioButton();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuNewTimeSheet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMainMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timerForTask = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cboTaskPrefix = new System.Windows.Forms.ComboBox();
            this.colTaskDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrefixDescription = new System.Windows.Forms.Label();
            this.txtPrefixDescription = new System.Windows.Forms.TextBox();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).BeginInit();
            this.panelTop.SuspendLayout();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1140, 655);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1140, 683);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripMainContainer";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.mnuMainMenu);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.gridTasks, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1140, 655);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // gridTasks
            // 
            this.gridTasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTaskDate,
            this.colTaskName,
            this.colTaskDuration,
            this.colTaskProject});
            this.gridTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTasks.Location = new System.Drawing.Point(3, 329);
            this.gridTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridTasks.Name = "gridTasks";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTasks.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridTasks.RowTemplate.Height = 24;
            this.gridTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTasks.Size = new System.Drawing.Size(1134, 324);
            this.gridTasks.TabIndex = 4;
            this.gridTasks.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.GridTasks_CellBeginEdit);
            this.gridTasks.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTasks_CellEndEdit);
            this.gridTasks.SelectionChanged += new System.EventHandler(this.GridTasks_SelectionChanged);
            this.gridTasks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridTasks_KeyDown);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnUpdateTask);
            this.panelTop.Controls.Add(this.txtPrefixDescription);
            this.panelTop.Controls.Add(this.lblPrefixDescription);
            this.panelTop.Controls.Add(this.cboTaskPrefix);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.btnClearTaskDuration);
            this.panelTop.Controls.Add(this.btnStartTimer);
            this.panelTop.Controls.Add(this.cboProject);
            this.panelTop.Controls.Add(this.lblProject);
            this.panelTop.Controls.Add(this.dtTaskDate);
            this.panelTop.Controls.Add(this.lblTaskName);
            this.panelTop.Controls.Add(this.btnRemoveSelected);
            this.panelTop.Controls.Add(this.txtTaskName);
            this.panelTop.Controls.Add(this.lblTotalDuration);
            this.panelTop.Controls.Add(this.lblTaskDuration);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.txtTaskDuration);
            this.panelTop.Controls.Add(this.radioDurationMinutes);
            this.panelTop.Controls.Add(this.lblTaskDate);
            this.panelTop.Controls.Add(this.radioDurationHours);
            this.panelTop.Controls.Add(this.btnAddTask);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 2);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1134, 323);
            this.panelTop.TabIndex = 12;
            // 
            // btnClearTaskDuration
            // 
            this.btnClearTaskDuration.Location = new System.Drawing.Point(404, 158);
            this.btnClearTaskDuration.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearTaskDuration.Name = "btnClearTaskDuration";
            this.btnClearTaskDuration.Size = new System.Drawing.Size(41, 32);
            this.btnClearTaskDuration.TabIndex = 14;
            this.btnClearTaskDuration.Text = "X";
            this.btnClearTaskDuration.UseVisualStyleBackColor = true;
            this.btnClearTaskDuration.Click += new System.EventHandler(this.BtnClearTaskDuration_Click);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartTimer.Location = new System.Drawing.Point(603, 157);
            this.btnStartTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(211, 33);
            this.btnStartTimer.TabIndex = 13;
            this.btnStartTimer.Text = "&Запустить таймер";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.BtnStartTimer_Click);
            // 
            // cboProject
            // 
            this.cboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(116, 282);
            this.cboProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(1009, 28);
            this.cboProject.TabIndex = 12;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(50, 288);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(60, 17);
            this.lblProject.TabIndex = 11;
            this.lblProject.Text = "Проект:";
            // 
            // dtTaskDate
            // 
            this.dtTaskDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtTaskDate.Location = new System.Drawing.Point(178, 204);
            this.dtTaskDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtTaskDate.Name = "dtTaskDate";
            this.dtTaskDate.Size = new System.Drawing.Size(219, 27);
            this.dtTaskDate.TabIndex = 7;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(43, 124);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(127, 17);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Название задачи:";
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveSelected.Location = new System.Drawing.Point(808, 240);
            this.btnRemoveSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(317, 33);
            this.btnRemoveSelected.TabIndex = 8;
            this.btnRemoveSelected.Text = "&Удалить выбранные задачи";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.BtnRemoveSelected_Click);
            // 
            // txtTaskName
            // 
            this.txtTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTaskName.Location = new System.Drawing.Point(178, 118);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(947, 27);
            this.txtTaskName.TabIndex = 0;
            // 
            // lblTotalDuration
            // 
            this.lblTotalDuration.AutoSize = true;
            this.lblTotalDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalDuration.ForeColor = System.Drawing.Color.Red;
            this.lblTotalDuration.Location = new System.Drawing.Point(178, 246);
            this.lblTotalDuration.Name = "lblTotalDuration";
            this.lblTotalDuration.Size = new System.Drawing.Size(21, 22);
            this.lblTotalDuration.TabIndex = 10;
            this.lblTotalDuration.Text = "0";
            // 
            // lblTaskDuration
            // 
            this.lblTaskDuration.AutoSize = true;
            this.lblTaskDuration.Location = new System.Drawing.Point(13, 166);
            this.lblTaskDuration.Name = "lblTaskDuration";
            this.lblTaskDuration.Size = new System.Drawing.Size(157, 17);
            this.lblTaskDuration.TabIndex = 2;
            this.lblTaskDuration.Text = "Длительность задачи:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Всего часов:";
            // 
            // txtTaskDuration
            // 
            this.txtTaskDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTaskDuration.Location = new System.Drawing.Point(178, 160);
            this.txtTaskDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaskDuration.Name = "txtTaskDuration";
            this.txtTaskDuration.Size = new System.Drawing.Size(219, 27);
            this.txtTaskDuration.TabIndex = 1;
            // 
            // radioDurationMinutes
            // 
            this.radioDurationMinutes.AutoSize = true;
            this.radioDurationMinutes.Checked = true;
            this.radioDurationMinutes.Location = new System.Drawing.Point(468, 167);
            this.radioDurationMinutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioDurationMinutes.Name = "radioDurationMinutes";
            this.radioDurationMinutes.Size = new System.Drawing.Size(54, 21);
            this.radioDurationMinutes.TabIndex = 2;
            this.radioDurationMinutes.TabStop = true;
            this.radioDurationMinutes.Text = "мин";
            this.radioDurationMinutes.UseVisualStyleBackColor = true;
            // 
            // lblTaskDate
            // 
            this.lblTaskDate.AutoSize = true;
            this.lblTaskDate.Location = new System.Drawing.Point(73, 212);
            this.lblTaskDate.Name = "lblTaskDate";
            this.lblTaskDate.Size = new System.Drawing.Size(97, 17);
            this.lblTaskDate.TabIndex = 6;
            this.lblTaskDate.Text = "Дата задачи:";
            // 
            // radioDurationHours
            // 
            this.radioDurationHours.AutoSize = true;
            this.radioDurationHours.Location = new System.Drawing.Point(533, 168);
            this.radioDurationHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioDurationHours.Name = "radioDurationHours";
            this.radioDurationHours.Size = new System.Drawing.Size(52, 21);
            this.radioDurationHours.TabIndex = 3;
            this.radioDurationHours.Text = "час";
            this.radioDurationHours.UseVisualStyleBackColor = true;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTask.Location = new System.Drawing.Point(388, 240);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(209, 33);
            this.btnAddTask.TabIndex = 5;
            this.btnAddTask.Text = "&Добавить задачу";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuFile});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(1140, 28);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuMainMenuFile
            // 
            this.mnuMainMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuNewTimeSheet,
            this.mnuMainMenuOpen,
            this.mnuMainMenuSave,
            this.mnuMainMenuSaveAs,
            this.toolStripMenuItem1,
            this.mnuMainMenuExit});
            this.mnuMainMenuFile.Name = "mnuMainMenuFile";
            this.mnuMainMenuFile.Size = new System.Drawing.Size(57, 24);
            this.mnuMainMenuFile.Text = "&Файл";
            // 
            // mnuMainMenuNewTimeSheet
            // 
            this.mnuMainMenuNewTimeSheet.Name = "mnuMainMenuNewTimeSheet";
            this.mnuMainMenuNewTimeSheet.Size = new System.Drawing.Size(216, 26);
            this.mnuMainMenuNewTimeSheet.Text = "&Новый таймшит";
            this.mnuMainMenuNewTimeSheet.Click += new System.EventHandler(this.MnuMainMenuNewTimeSheet_Click);
            // 
            // mnuMainMenuOpen
            // 
            this.mnuMainMenuOpen.Name = "mnuMainMenuOpen";
            this.mnuMainMenuOpen.Size = new System.Drawing.Size(216, 26);
            this.mnuMainMenuOpen.Text = "&Открыть...";
            this.mnuMainMenuOpen.Click += new System.EventHandler(this.MnuMainMenuOpen_Click);
            // 
            // mnuMainMenuSave
            // 
            this.mnuMainMenuSave.Name = "mnuMainMenuSave";
            this.mnuMainMenuSave.Size = new System.Drawing.Size(216, 26);
            this.mnuMainMenuSave.Text = "&Сохранить";
            this.mnuMainMenuSave.Click += new System.EventHandler(this.MnuMainMenuSave_Click);
            // 
            // mnuMainMenuSaveAs
            // 
            this.mnuMainMenuSaveAs.Name = "mnuMainMenuSaveAs";
            this.mnuMainMenuSaveAs.Size = new System.Drawing.Size(216, 26);
            this.mnuMainMenuSaveAs.Text = "&Сохранить как...";
            this.mnuMainMenuSaveAs.Click += new System.EventHandler(this.MnuMainMenuSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // mnuMainMenuExit
            // 
            this.mnuMainMenuExit.Name = "mnuMainMenuExit";
            this.mnuMainMenuExit.Size = new System.Drawing.Size(216, 26);
            this.mnuMainMenuExit.Text = "&Выход";
            this.mnuMainMenuExit.Click += new System.EventHandler(this.MnuMainMenuExit_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Все файлы|*.*|Файлы SuperTimeSheet|*.supts";
            // 
            // timerForTask
            // 
            this.timerForTask.Interval = 1000;
            this.timerForTask.Tick += new System.EventHandler(this.TimerForTask_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Префикс для задачи:";
            // 
            // cboTaskPrefix
            // 
            this.cboTaskPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTaskPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboTaskPrefix.FormattingEnabled = true;
            this.cboTaskPrefix.Location = new System.Drawing.Point(178, 19);
            this.cboTaskPrefix.Name = "cboTaskPrefix";
            this.cboTaskPrefix.Size = new System.Drawing.Size(947, 28);
            this.cboTaskPrefix.TabIndex = 16;
            this.cboTaskPrefix.SelectedIndexChanged += new System.EventHandler(this.CboTaskPrefix_SelectedIndexChanged);
            // 
            // colTaskDate
            // 
            this.colTaskDate.HeaderText = "Дата";
            this.colTaskDate.Name = "colTaskDate";
            // 
            // colTaskName
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colTaskName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTaskName.HeaderText = "Задача";
            this.colTaskName.Name = "colTaskName";
            this.colTaskName.Width = 400;
            // 
            // colTaskDuration
            // 
            this.colTaskDuration.HeaderText = "Длительность";
            this.colTaskDuration.Name = "colTaskDuration";
            this.colTaskDuration.Width = 200;
            // 
            // colTaskProject
            // 
            this.colTaskProject.HeaderText = "Проект";
            this.colTaskProject.Name = "colTaskProject";
            this.colTaskProject.Width = 600;
            // 
            // lblPrefixDescription
            // 
            this.lblPrefixDescription.AutoSize = true;
            this.lblPrefixDescription.Location = new System.Drawing.Point(20, 67);
            this.lblPrefixDescription.Name = "lblPrefixDescription";
            this.lblPrefixDescription.Size = new System.Drawing.Size(147, 17);
            this.lblPrefixDescription.TabIndex = 17;
            this.lblPrefixDescription.Text = "Описание префикса:";
            // 
            // txtPrefixDescription
            // 
            this.txtPrefixDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrefixDescription.Location = new System.Drawing.Point(178, 62);
            this.txtPrefixDescription.Multiline = true;
            this.txtPrefixDescription.Name = "txtPrefixDescription";
            this.txtPrefixDescription.ReadOnly = true;
            this.txtPrefixDescription.Size = new System.Drawing.Size(947, 51);
            this.txtPrefixDescription.TabIndex = 18;
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateTask.Location = new System.Drawing.Point(603, 240);
            this.btnUpdateTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(199, 33);
            this.btnUpdateTask.TabIndex = 19;
            this.btnUpdateTask.Text = "&Обновить задачу";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.BtnUpdateTask_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnAddTask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 683);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperTimeSheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView gridTasks;
        private System.Windows.Forms.Label lblTaskDuration;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.RadioButton radioDurationHours;
        private System.Windows.Forms.RadioButton radioDurationMinutes;
        private System.Windows.Forms.TextBox txtTaskDuration;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.DateTimePicker dtTaskDate;
        private System.Windows.Forms.Label lblTaskDate;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Label lblTotalDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuExit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuSaveAs;
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuNewTimeSheet;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Timer timerForTask;
        private System.Windows.Forms.Button btnClearTaskDuration;
        private System.Windows.Forms.ComboBox cboTaskPrefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskProject;
        private System.Windows.Forms.Label lblPrefixDescription;
        private System.Windows.Forms.TextBox txtPrefixDescription;
        private System.Windows.Forms.Button btnUpdateTask;
    }
}

