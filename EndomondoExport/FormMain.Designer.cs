namespace EndomondoExport
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnListWorkouts = new System.Windows.Forms.Button();
            this.btnGetWorkouts = new System.Windows.Forms.Button();
            this.dataGridList = new System.Windows.Forms.DataGridView();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.folderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChooseOutput = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.txtMaxWorkouts = new System.Windows.Forms.TextBox();
            this.cmbSportType = new System.Windows.Forms.ComboBox();
            this.chkOriginals = new System.Windows.Forms.CheckBox();
            this.rbtnGPX = new System.Windows.Forms.RadioButton();
            this.rbtnTCX = new System.Windows.Forms.RadioButton();
            this.bgWorkerList = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerDownload = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerSelectAll = new System.ComponentModel.BackgroundWorker();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stepsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distancekmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationsecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedkmhavgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).BeginInit();
            this.grpLogin.SuspendLayout();
            this.grpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workoutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(97, 82);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 23);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(124, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(198, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 26);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(101, 17);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email address:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(17, 54);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Controls.Add(this.lblDisplayName);
            this.grpUserInfo.Controls.Add(this.txtDisplayName);
            this.grpUserInfo.Controls.Add(this.lblUserId);
            this.grpUserInfo.Controls.Add(this.txtUserId);
            this.grpUserInfo.Location = new System.Drawing.Point(346, 12);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Size = new System.Drawing.Size(331, 112);
            this.grpUserInfo.TabIndex = 5;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "User information:";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(17, 52);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(99, 17);
            this.lblDisplayName.TabIndex = 3;
            this.lblDisplayName.Text = "Display Name:";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(128, 49);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.ReadOnly = true;
            this.txtDisplayName.Size = new System.Drawing.Size(197, 22);
            this.txtDisplayName.TabIndex = 2;
            this.txtDisplayName.TabStop = false;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(17, 24);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(57, 17);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "User Id:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(128, 21);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(197, 22);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.TabStop = false;
            // 
            // btnListWorkouts
            // 
            this.btnListWorkouts.Location = new System.Drawing.Point(142, 22);
            this.btnListWorkouts.Name = "btnListWorkouts";
            this.btnListWorkouts.Size = new System.Drawing.Size(114, 23);
            this.btnListWorkouts.TabIndex = 6;
            this.btnListWorkouts.Text = "List Workouts";
            this.btnListWorkouts.UseVisualStyleBackColor = true;
            this.btnListWorkouts.Click += new System.EventHandler(this.btnListWorkouts_Click);
            // 
            // btnGetWorkouts
            // 
            this.btnGetWorkouts.Location = new System.Drawing.Point(142, 79);
            this.btnGetWorkouts.Name = "btnGetWorkouts";
            this.btnGetWorkouts.Size = new System.Drawing.Size(99, 23);
            this.btnGetWorkouts.TabIndex = 7;
            this.btnGetWorkouts.Text = "Download";
            this.btnGetWorkouts.UseVisualStyleBackColor = true;
            this.btnGetWorkouts.Click += new System.EventHandler(this.btnGetWorkouts_Click);
            // 
            // dataGridList
            // 
            this.dataGridList.AllowUserToAddRows = false;
            this.dataGridList.AutoGenerateColumns = false;
            this.dataGridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.starttimeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sportDataGridViewTextBoxColumn,
            this.distancekmDataGridViewTextBoxColumn,
            this.durationsecDataGridViewTextBoxColumn,
            this.stepsDataGridViewTextBoxColumn,
            this.speedkmhavgDataGridViewTextBoxColumn,
            this.routeidDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridList.DataSource = this.workoutBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridList.Location = new System.Drawing.Point(0, 159);
            this.dataGridList.Name = "dataGridList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridList.RowHeadersVisible = false;
            this.dataGridList.RowTemplate.Height = 24;
            this.dataGridList.Size = new System.Drawing.Size(1084, 502);
            this.dataGridList.TabIndex = 9;
            this.dataGridList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridList_CellFormatting);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(16, 56);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(88, 21);
            this.chkSelectAll.TabIndex = 10;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // btnChooseOutput
            // 
            this.btnChooseOutput.Location = new System.Drawing.Point(9, 130);
            this.btnChooseOutput.Name = "btnChooseOutput";
            this.btnChooseOutput.Size = new System.Drawing.Size(114, 23);
            this.btnChooseOutput.TabIndex = 11;
            this.btnChooseOutput.Text = "Output Folder";
            this.btnChooseOutput.UseVisualStyleBackColor = true;
            this.btnChooseOutput.Click += new System.EventHandler(this.btnChooseOutput_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(129, 130);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.ReadOnly = true;
            this.txtOutputFolder.Size = new System.Drawing.Size(548, 22);
            this.txtOutputFolder.TabIndex = 6;
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.lblEmail);
            this.grpLogin.Controls.Add(this.btnConnect);
            this.grpLogin.Controls.Add(this.txtEmail);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Location = new System.Drawing.Point(9, 10);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(331, 114);
            this.grpLogin.TabIndex = 6;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login:";
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.txtMaxWorkouts);
            this.grpActions.Controls.Add(this.cmbSportType);
            this.grpActions.Controls.Add(this.chkOriginals);
            this.grpActions.Controls.Add(this.rbtnGPX);
            this.grpActions.Controls.Add(this.rbtnTCX);
            this.grpActions.Controls.Add(this.btnListWorkouts);
            this.grpActions.Controls.Add(this.btnGetWorkouts);
            this.grpActions.Controls.Add(this.chkSelectAll);
            this.grpActions.Location = new System.Drawing.Point(683, 10);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(343, 112);
            this.grpActions.TabIndex = 6;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions:";
            // 
            // txtMaxWorkouts
            // 
            this.txtMaxWorkouts.Location = new System.Drawing.Point(16, 23);
            this.txtMaxWorkouts.Name = "txtMaxWorkouts";
            this.txtMaxWorkouts.Size = new System.Drawing.Size(120, 22);
            this.txtMaxWorkouts.TabIndex = 5;
            this.txtMaxWorkouts.Text = "10";
            // 
            // cmbSportType
            // 
            this.cmbSportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSportType.FormattingEnabled = true;
            this.cmbSportType.Location = new System.Drawing.Point(142, 51);
            this.cmbSportType.Name = "cmbSportType";
            this.cmbSportType.Size = new System.Drawing.Size(176, 24);
            this.cmbSportType.TabIndex = 14;
            this.cmbSportType.SelectedIndexChanged += new System.EventHandler(this.cmbSportType_SelectedIndexChanged);
            // 
            // chkOriginals
            // 
            this.chkOriginals.AutoSize = true;
            this.chkOriginals.Location = new System.Drawing.Point(245, 81);
            this.chkOriginals.Name = "chkOriginals";
            this.chkOriginals.Size = new System.Drawing.Size(86, 21);
            this.chkOriginals.TabIndex = 13;
            this.chkOriginals.Text = "Originals";
            this.chkOriginals.UseVisualStyleBackColor = true;
            // 
            // rbtnGPX
            // 
            this.rbtnGPX.AutoSize = true;
            this.rbtnGPX.Location = new System.Drawing.Point(78, 80);
            this.rbtnGPX.Name = "rbtnGPX";
            this.rbtnGPX.Size = new System.Drawing.Size(58, 21);
            this.rbtnGPX.TabIndex = 12;
            this.rbtnGPX.Text = "GPX";
            this.rbtnGPX.UseVisualStyleBackColor = true;
            // 
            // rbtnTCX
            // 
            this.rbtnTCX.AutoSize = true;
            this.rbtnTCX.Checked = true;
            this.rbtnTCX.Location = new System.Drawing.Point(16, 80);
            this.rbtnTCX.Name = "rbtnTCX";
            this.rbtnTCX.Size = new System.Drawing.Size(56, 21);
            this.rbtnTCX.TabIndex = 11;
            this.rbtnTCX.TabStop = true;
            this.rbtnTCX.Text = "TCX";
            this.rbtnTCX.UseVisualStyleBackColor = true;
            // 
            // bgWorkerList
            // 
            this.bgWorkerList.WorkerReportsProgress = true;
            this.bgWorkerList.WorkerSupportsCancellation = true;
            this.bgWorkerList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerList_DoWork);
            this.bgWorkerList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerList_RunWorkerCompleted);
            // 
            // bgWorkerDownload
            // 
            this.bgWorkerDownload.WorkerReportsProgress = true;
            this.bgWorkerDownload.WorkerSupportsCancellation = true;
            this.bgWorkerDownload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerDownload_DoWork);
            this.bgWorkerDownload.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerDownload_RunWorkerCompleted);
            // 
            // bgWorkerSelectAll
            // 
            this.bgWorkerSelectAll.WorkerReportsProgress = true;
            this.bgWorkerSelectAll.WorkerSupportsCancellation = true;
            this.bgWorkerSelectAll.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerSelectAll_DoWork);
            this.bgWorkerSelectAll.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerSelectAll_RunWorkerCompleted);
            // 
            // Select
            // 
            this.Select.FalseValue = "false";
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.TrueValue = "true";
            this.Select.Width = 53;
            // 
            // stepsDataGridViewTextBoxColumn
            // 
            this.stepsDataGridViewTextBoxColumn.DataPropertyName = "steps";
            this.stepsDataGridViewTextBoxColumn.HeaderText = "Steps";
            this.stepsDataGridViewTextBoxColumn.Name = "stepsDataGridViewTextBoxColumn";
            this.stepsDataGridViewTextBoxColumn.ReadOnly = true;
            this.stepsDataGridViewTextBoxColumn.Width = 69;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 5;
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "Date";
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            this.starttimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.starttimeDataGridViewTextBoxColumn.Width = 63;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Title";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // sportDataGridViewTextBoxColumn
            // 
            this.sportDataGridViewTextBoxColumn.DataPropertyName = "sport";
            this.sportDataGridViewTextBoxColumn.HeaderText = "Sport";
            this.sportDataGridViewTextBoxColumn.Name = "sportDataGridViewTextBoxColumn";
            this.sportDataGridViewTextBoxColumn.ReadOnly = true;
            this.sportDataGridViewTextBoxColumn.Width = 67;
            // 
            // distancekmDataGridViewTextBoxColumn
            // 
            this.distancekmDataGridViewTextBoxColumn.DataPropertyName = "distance_km";
            this.distancekmDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distancekmDataGridViewTextBoxColumn.Name = "distancekmDataGridViewTextBoxColumn";
            this.distancekmDataGridViewTextBoxColumn.ReadOnly = true;
            this.distancekmDataGridViewTextBoxColumn.Width = 88;
            // 
            // durationsecDataGridViewTextBoxColumn
            // 
            this.durationsecDataGridViewTextBoxColumn.DataPropertyName = "duration_sec";
            this.durationsecDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationsecDataGridViewTextBoxColumn.Name = "durationsecDataGridViewTextBoxColumn";
            this.durationsecDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationsecDataGridViewTextBoxColumn.Width = 87;
            // 
            // speedkmhavgDataGridViewTextBoxColumn
            // 
            this.speedkmhavgDataGridViewTextBoxColumn.DataPropertyName = "speed_kmh_avg";
            this.speedkmhavgDataGridViewTextBoxColumn.HeaderText = "Avg. Speed";
            this.speedkmhavgDataGridViewTextBoxColumn.Name = "speedkmhavgDataGridViewTextBoxColumn";
            this.speedkmhavgDataGridViewTextBoxColumn.ReadOnly = true;
            this.speedkmhavgDataGridViewTextBoxColumn.Width = 97;
            // 
            // routeidDataGridViewTextBoxColumn
            // 
            this.routeidDataGridViewTextBoxColumn.DataPropertyName = "route_id";
            this.routeidDataGridViewTextBoxColumn.HeaderText = "Route";
            this.routeidDataGridViewTextBoxColumn.Name = "routeidDataGridViewTextBoxColumn";
            this.routeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.routeidDataGridViewTextBoxColumn.Width = 71;
            // 
            // workoutBindingSource
            // 
            this.workoutBindingSource.DataSource = typeof(EndomondoExport.Workout);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.btnChooseOutput);
            this.Controls.Add(this.dataGridList);
            this.Controls.Add(this.grpUserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endomondo Export Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).EndInit();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workoutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Button btnListWorkouts;
        private System.Windows.Forms.Button btnGetWorkouts;
        private System.Windows.Forms.DataGridView dataGridList;
        private System.Windows.Forms.BindingSource workoutBindingSource;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.FolderBrowserDialog folderDlg;
        private System.Windows.Forms.Button btnChooseOutput;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.RadioButton rbtnGPX;
        private System.Windows.Forms.RadioButton rbtnTCX;
        private System.Windows.Forms.CheckBox chkOriginals;
        private System.Windows.Forms.ComboBox cmbSportType;
        private System.ComponentModel.BackgroundWorker bgWorkerList;
        private System.ComponentModel.BackgroundWorker bgWorkerDownload;
        private System.Windows.Forms.TextBox txtMaxWorkouts;
        private System.ComponentModel.BackgroundWorker bgWorkerSelectAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distancekmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationsecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedkmhavgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}

