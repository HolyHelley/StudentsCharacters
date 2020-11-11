namespace StudentCharacter
{
    partial class Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToConst = new System.Windows.Forms.Button();
            this.btnCreateAllChar = new System.Windows.Forms.Button();
            this.lblTableUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chbBirthDate = new System.Windows.Forms.CheckBox();
            this.chbGender = new System.Windows.Forms.CheckBox();
            this.chbFamily = new System.Windows.Forms.CheckBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.dtYearLast = new System.Windows.Forms.DateTimePicker();
            this.dtYear = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlMarksFind = new System.Windows.Forms.Panel();
            this.numMark = new System.Windows.Forms.NumericUpDown();
            this.chbPassSearch = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.chbPass = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chbMark = new System.Windows.Forms.CheckBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.chbSubject = new System.Windows.Forms.CheckBox();
            this.llCloseSearch = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.studentsTable = new System.Windows.Forms.DataGridView();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.llOpenSearch = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSubjects = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextView = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlMarksFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMark)).BeginInit();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextSelectAll,
            this.ContextDelete,
            this.ContextView});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // ContextSelectAll
            // 
            this.ContextSelectAll.Name = "ContextSelectAll";
            this.ContextSelectAll.Size = new System.Drawing.Size(180, 22);
            this.ContextSelectAll.Text = "Выбрать все";
            this.ContextSelectAll.Click += new System.EventHandler(this.ContextSelectAll_Click);
            // 
            // ContextDelete
            // 
            this.ContextDelete.Name = "ContextDelete";
            this.ContextDelete.Size = new System.Drawing.Size(180, 22);
            this.ContextDelete.Text = "Удалить";
            this.ContextDelete.Click += new System.EventHandler(this.ContextDelete_Click);
            // 
            // btnToConst
            // 
            this.btnToConst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnToConst.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnToConst.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToConst.ForeColor = System.Drawing.Color.Lavender;
            this.btnToConst.Location = new System.Drawing.Point(153, 276);
            this.btnToConst.Name = "btnToConst";
            this.btnToConst.Size = new System.Drawing.Size(120, 41);
            this.btnToConst.TabIndex = 3;
            this.btnToConst.Text = "В конструктор";
            this.btnToConst.UseVisualStyleBackColor = false;
            this.btnToConst.Click += new System.EventHandler(this.btnLoadToCustom_Click);
            // 
            // btnCreateAllChar
            // 
            this.btnCreateAllChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateAllChar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateAllChar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateAllChar.ForeColor = System.Drawing.Color.Lavender;
            this.btnCreateAllChar.Location = new System.Drawing.Point(13, 276);
            this.btnCreateAllChar.Name = "btnCreateAllChar";
            this.btnCreateAllChar.Size = new System.Drawing.Size(134, 41);
            this.btnCreateAllChar.TabIndex = 5;
            this.btnCreateAllChar.Text = "Создать выбранные характеристики";
            this.btnCreateAllChar.UseVisualStyleBackColor = false;
            this.btnCreateAllChar.Click += new System.EventHandler(this.btnCreateAll_Click);
            // 
            // lblTableUser
            // 
            this.lblTableUser.AutoSize = true;
            this.lblTableUser.BackColor = System.Drawing.Color.Transparent;
            this.lblTableUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTableUser.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTableUser.Location = new System.Drawing.Point(31, 6);
            this.lblTableUser.Name = "lblTableUser";
            this.lblTableUser.Size = new System.Drawing.Size(88, 17);
            this.lblTableUser.TabIndex = 7;
            this.lblTableUser.Text = "lblTableUser";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblTableUser);
            this.panel1.Location = new System.Drawing.Point(13, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 48);
            this.panel1.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblStatus.Location = new System.Drawing.Point(31, 25);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 17);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "lblStatus";
            // 
            // chbBirthDate
            // 
            this.chbBirthDate.AutoSize = true;
            this.chbBirthDate.Location = new System.Drawing.Point(14, 127);
            this.chbBirthDate.Name = "chbBirthDate";
            this.chbBirthDate.Size = new System.Drawing.Size(15, 14);
            this.chbBirthDate.TabIndex = 29;
            this.chbBirthDate.UseVisualStyleBackColor = true;
            // 
            // chbGender
            // 
            this.chbGender.AutoSize = true;
            this.chbGender.Location = new System.Drawing.Point(14, 91);
            this.chbGender.Name = "chbGender";
            this.chbGender.Size = new System.Drawing.Size(15, 14);
            this.chbGender.TabIndex = 28;
            this.chbGender.UseVisualStyleBackColor = true;
            // 
            // chbFamily
            // 
            this.chbFamily.AutoSize = true;
            this.chbFamily.Location = new System.Drawing.Point(14, 59);
            this.chbFamily.Name = "chbFamily";
            this.chbFamily.Size = new System.Drawing.Size(15, 14);
            this.chbFamily.TabIndex = 27;
            this.chbFamily.UseVisualStyleBackColor = true;
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.cbGender.Location = new System.Drawing.Point(147, 88);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(98, 21);
            this.cbGender.TabIndex = 26;
            // 
            // dtYearLast
            // 
            this.dtYearLast.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtYearLast.Location = new System.Drawing.Point(147, 147);
            this.dtYearLast.Name = "dtYearLast";
            this.dtYearLast.Size = new System.Drawing.Size(121, 20);
            this.dtYearLast.TabIndex = 23;
            this.dtYearLast.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dtYear
            // 
            this.dtYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtYear.Location = new System.Drawing.Point(147, 121);
            this.dtYear.Name = "dtYear";
            this.dtYear.Size = new System.Drawing.Size(121, 20);
            this.dtYear.TabIndex = 25;
            this.dtYear.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(35, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Год рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.PeachPuff;
            this.label5.Location = new System.Drawing.Point(119, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "До";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.PeachPuff;
            this.label4.Location = new System.Drawing.Point(119, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "От";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(35, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Пол";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Фамилия";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClearSearch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearSearch.ForeColor = System.Drawing.Color.Lavender;
            this.btnClearSearch.Location = new System.Drawing.Point(170, 311);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(75, 23);
            this.btnClearSearch.TabIndex = 15;
            this.btnClearSearch.Text = "Сбросить";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFind.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.ForeColor = System.Drawing.Color.Lavender;
            this.btnFind.Location = new System.Drawing.Point(38, 311);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Поиск";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(147, 59);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(98, 20);
            this.tbName.TabIndex = 14;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearch.Controls.Add(this.pnlMarksFind);
            this.pnlSearch.Controls.Add(this.llCloseSearch);
            this.pnlSearch.Controls.Add(this.label7);
            this.pnlSearch.Controls.Add(this.btnClearSearch);
            this.pnlSearch.Controls.Add(this.btnFind);
            this.pnlSearch.Controls.Add(this.chbBirthDate);
            this.pnlSearch.Controls.Add(this.label3);
            this.pnlSearch.Controls.Add(this.chbGender);
            this.pnlSearch.Controls.Add(this.tbName);
            this.pnlSearch.Controls.Add(this.chbFamily);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Controls.Add(this.cbGender);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.label4);
            this.pnlSearch.Controls.Add(this.dtYearLast);
            this.pnlSearch.Controls.Add(this.label5);
            this.pnlSearch.Controls.Add(this.dtYear);
            this.pnlSearch.Location = new System.Drawing.Point(481, 27);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(283, 357);
            this.pnlSearch.TabIndex = 31;
            this.pnlSearch.Visible = false;
            // 
            // pnlMarksFind
            // 
            this.pnlMarksFind.Controls.Add(this.numMark);
            this.pnlMarksFind.Controls.Add(this.chbPassSearch);
            this.pnlMarksFind.Controls.Add(this.label8);
            this.pnlMarksFind.Controls.Add(this.cbSubject);
            this.pnlMarksFind.Controls.Add(this.chbPass);
            this.pnlMarksFind.Controls.Add(this.label6);
            this.pnlMarksFind.Controls.Add(this.chbMark);
            this.pnlMarksFind.Controls.Add(this.lblSubject);
            this.pnlMarksFind.Controls.Add(this.chbSubject);
            this.pnlMarksFind.Location = new System.Drawing.Point(3, 176);
            this.pnlMarksFind.Name = "pnlMarksFind";
            this.pnlMarksFind.Size = new System.Drawing.Size(265, 111);
            this.pnlMarksFind.TabIndex = 33;
            this.pnlMarksFind.Visible = false;
            // 
            // numMark
            // 
            this.numMark.Location = new System.Drawing.Point(144, 42);
            this.numMark.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMark.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numMark.Name = "numMark";
            this.numMark.Size = new System.Drawing.Size(98, 20);
            this.numMark.TabIndex = 30;
            this.numMark.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // chbPassSearch
            // 
            this.chbPassSearch.AutoSize = true;
            this.chbPassSearch.Location = new System.Drawing.Point(144, 74);
            this.chbPassSearch.Name = "chbPassSearch";
            this.chbPassSearch.Size = new System.Drawing.Size(15, 14);
            this.chbPassSearch.TabIndex = 29;
            this.chbPassSearch.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.PeachPuff;
            this.label8.Location = new System.Drawing.Point(32, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Зачет";
            // 
            // cbSubject
            // 
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(144, 11);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(98, 21);
            this.cbSubject.TabIndex = 26;
            // 
            // chbPass
            // 
            this.chbPass.AutoSize = true;
            this.chbPass.Location = new System.Drawing.Point(11, 74);
            this.chbPass.Name = "chbPass";
            this.chbPass.Size = new System.Drawing.Size(15, 14);
            this.chbPass.TabIndex = 28;
            this.chbPass.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.PeachPuff;
            this.label6.Location = new System.Drawing.Point(32, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Оценка";
            // 
            // chbMark
            // 
            this.chbMark.AutoSize = true;
            this.chbMark.Location = new System.Drawing.Point(11, 44);
            this.chbMark.Name = "chbMark";
            this.chbMark.Size = new System.Drawing.Size(15, 14);
            this.chbMark.TabIndex = 28;
            this.chbMark.UseVisualStyleBackColor = true;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.ForeColor = System.Drawing.Color.PeachPuff;
            this.lblSubject.Location = new System.Drawing.Point(32, 14);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(52, 13);
            this.lblSubject.TabIndex = 18;
            this.lblSubject.Text = "Предмет";
            // 
            // chbSubject
            // 
            this.chbSubject.AutoSize = true;
            this.chbSubject.Location = new System.Drawing.Point(11, 14);
            this.chbSubject.Name = "chbSubject";
            this.chbSubject.Size = new System.Drawing.Size(15, 14);
            this.chbSubject.TabIndex = 28;
            this.chbSubject.UseVisualStyleBackColor = true;
            // 
            // llCloseSearch
            // 
            this.llCloseSearch.AutoSize = true;
            this.llCloseSearch.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.llCloseSearch.Location = new System.Drawing.Point(11, 20);
            this.llCloseSearch.Name = "llCloseSearch";
            this.llCloseSearch.Size = new System.Drawing.Size(51, 13);
            this.llCloseSearch.TabIndex = 32;
            this.llCloseSearch.TabStop = true;
            this.llCloseSearch.Text = "Закрыть";
            this.llCloseSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CloseSearch_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.PeachPuff;
            this.label7.Location = new System.Drawing.Point(91, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Форма поиска";
            // 
            // pnlTable
            // 
            this.pnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTable.BackColor = System.Drawing.Color.Transparent;
            this.pnlTable.Controls.Add(this.studentsTable);
            this.pnlTable.Controls.Add(this.btnSwitch);
            this.pnlTable.Controls.Add(this.llOpenSearch);
            this.pnlTable.Controls.Add(this.btnToConst);
            this.pnlTable.Controls.Add(this.btnCreateAllChar);
            this.pnlTable.Controls.Add(this.panel1);
            this.pnlTable.Location = new System.Drawing.Point(0, 27);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(468, 357);
            this.pnlTable.TabIndex = 8;
            // 
            // studentsTable
            // 
            this.studentsTable.AllowUserToAddRows = false;
            this.studentsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.studentsTable.BackgroundColor = System.Drawing.Color.White;
            this.studentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsTable.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentsTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.studentsTable.Location = new System.Drawing.Point(13, 61);
            this.studentsTable.Name = "studentsTable";
            this.studentsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsTable.ShowEditingIcon = false;
            this.studentsTable.Size = new System.Drawing.Size(437, 209);
            this.studentsTable.TabIndex = 34;
            this.studentsTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsTable_CellEndEdit);
            this.studentsTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsTable_CellValueChanged);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSwitch.ForeColor = System.Drawing.Color.Lavender;
            this.btnSwitch.Location = new System.Drawing.Point(279, 279);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(171, 33);
            this.btnSwitch.TabIndex = 33;
            this.btnSwitch.Text = "↔ Оценки";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnMarks_Click);
            // 
            // llOpenSearch
            // 
            this.llOpenSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llOpenSearch.AutoSize = true;
            this.llOpenSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llOpenSearch.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.llOpenSearch.Location = new System.Drawing.Point(276, 323);
            this.llOpenSearch.Name = "llOpenSearch";
            this.llOpenSearch.Size = new System.Drawing.Size(174, 18);
            this.llOpenSearch.TabIndex = 32;
            this.llOpenSearch.TabStop = true;
            this.llOpenSearch.Text = "Открыть форму поиска";
            this.llOpenSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenSearch_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuGroups,
            this.MenuSubjects,
            this.MenuData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuGroups
            // 
            this.MenuGroups.Name = "MenuGroups";
            this.MenuGroups.Size = new System.Drawing.Size(58, 20);
            this.MenuGroups.Text = "Группа";
            // 
            // MenuSubjects
            // 
            this.MenuSubjects.Name = "MenuSubjects";
            this.MenuSubjects.Size = new System.Drawing.Size(76, 20);
            this.MenuSubjects.Text = "Предметы";
            this.MenuSubjects.Click += new System.EventHandler(this.MenuSubjects_Click);
            // 
            // MenuData
            // 
            this.MenuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExport,
            this.MenuImport});
            this.MenuData.Name = "MenuData";
            this.MenuData.Size = new System.Drawing.Size(62, 20);
            this.MenuData.Text = "Данные";
            // 
            // MenuExport
            // 
            this.MenuExport.Name = "MenuExport";
            this.MenuExport.Size = new System.Drawing.Size(180, 22);
            this.MenuExport.Text = "Экспорт";
            this.MenuExport.Click += new System.EventHandler(this.MenuExport_Click);
            // 
            // MenuImport
            // 
            this.MenuImport.Name = "MenuImport";
            this.MenuImport.Size = new System.Drawing.Size(180, 22);
            this.MenuImport.Text = "Импорт студентов";
            this.MenuImport.Click += new System.EventHandler(this.MenuImport_Click);
            // 
            // ContextView
            // 
            this.ContextView.Name = "ContextView";
            this.ContextView.Size = new System.Drawing.Size(180, 22);
            this.ContextView.Text = "Вид";
            this.ContextView.Visible = false;
            this.ContextView.Click += new System.EventHandler(this.ContextView_Click);
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(785, 396);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.pnlSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(747, 406);
            this.Name = "Base";
            this.Load += new System.EventHandler(this.Base_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Base_Paint);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlMarksFind.ResumeLayout(false);
            this.pnlMarksFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMark)).EndInit();
            this.pnlTable.ResumeLayout(false);
            this.pnlTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnToConst;
        private System.Windows.Forms.Button btnCreateAllChar;
        private System.Windows.Forms.Label lblTableUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chbBirthDate;
        private System.Windows.Forms.CheckBox chbGender;
        private System.Windows.Forms.CheckBox chbFamily;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker dtYearLast;
        private System.Windows.Forms.DateTimePicker dtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.LinkLabel llCloseSearch;
        private System.Windows.Forms.LinkLabel llOpenSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ContextSelectAll;
        private System.Windows.Forms.ToolStripMenuItem ContextDelete;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.DataGridView studentsTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuGroups;
        private System.Windows.Forms.ToolStripMenuItem MenuSubjects;
        private System.Windows.Forms.CheckBox chbSubject;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Panel pnlMarksFind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbMark;
        private System.Windows.Forms.CheckBox chbPassSearch;
        private System.Windows.Forms.NumericUpDown numMark;
        private System.Windows.Forms.ToolStripMenuItem MenuData;
        private System.Windows.Forms.ToolStripMenuItem MenuExport;
        private System.Windows.Forms.ToolStripMenuItem MenuImport;
        private System.Windows.Forms.ToolStripMenuItem ContextView;
    }
}