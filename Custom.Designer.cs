namespace StudentCharacter
{
    partial class Custom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Custom));
            this.btnCreateWord = new System.Windows.Forms.Button();
            this.tbStudName = new System.Windows.Forms.TextBox();
            this.tbStudSurname = new System.Windows.Forms.TextBox();
            this.tbMidName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddToBase = new System.Windows.Forms.Button();
            this.btnLoadFromBase = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chbHead = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cbRelationship = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbAbilities = new System.Windows.Forms.ComboBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbLates = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbCriticism = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbDiscipline = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentTable = new System.Windows.Forms.ToolStripMenuItem();
            this.Theme = new System.Windows.Forms.ToolStripMenuItem();
            this.Light = new System.Windows.Forms.ToolStripMenuItem();
            this.Dark = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuControl = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.label18 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnPersonalQuality = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.cbGroupe = new System.Windows.Forms.ComboBox();
            this.btnGroupe = new System.Windows.Forms.Button();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.lbPersonalQuality = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chbCommercial = new System.Windows.Forms.CheckBox();
            this.numMidMark = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.btnOlympiads = new System.Windows.Forms.Button();
            this.lbOlympiads = new System.Windows.Forms.ListBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnOrders = new System.Windows.Forms.Button();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMidMark)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateWord
            // 
            this.btnCreateWord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateWord.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateWord.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateWord.ForeColor = System.Drawing.Color.Lavender;
            this.btnCreateWord.Location = new System.Drawing.Point(434, 553);
            this.btnCreateWord.Name = "btnCreateWord";
            this.btnCreateWord.Size = new System.Drawing.Size(215, 49);
            this.btnCreateWord.TabIndex = 21;
            this.btnCreateWord.Text = "Создать характеристику";
            this.btnCreateWord.UseVisualStyleBackColor = false;
            this.btnCreateWord.Click += new System.EventHandler(this.btnCreateCharacter_Click);
            // 
            // tbStudName
            // 
            this.tbStudName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStudName.ForeColor = System.Drawing.Color.Navy;
            this.tbStudName.Location = new System.Drawing.Point(175, 143);
            this.tbStudName.Name = "tbStudName";
            this.tbStudName.Size = new System.Drawing.Size(120, 20);
            this.tbStudName.TabIndex = 2;
            this.tbStudName.Text = "Иван";
            this.tbStudName.TextChanged += new System.EventHandler(this.tbGroupCode_TextChanged);
            // 
            // tbStudSurname
            // 
            this.tbStudSurname.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStudSurname.ForeColor = System.Drawing.Color.Navy;
            this.tbStudSurname.Location = new System.Drawing.Point(175, 107);
            this.tbStudSurname.Name = "tbStudSurname";
            this.tbStudSurname.Size = new System.Drawing.Size(120, 20);
            this.tbStudSurname.TabIndex = 1;
            this.tbStudSurname.Text = "Иванов";
            this.tbStudSurname.TextChanged += new System.EventHandler(this.tbGroupCode_TextChanged);
            // 
            // tbMidName
            // 
            this.tbMidName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMidName.ForeColor = System.Drawing.Color.Navy;
            this.tbMidName.Location = new System.Drawing.Point(175, 181);
            this.tbMidName.Name = "tbMidName";
            this.tbMidName.Size = new System.Drawing.Size(120, 20);
            this.tbMidName.TabIndex = 3;
            this.tbMidName.Text = "Иванович";
            this.tbMidName.TextChanged += new System.EventHandler(this.tbGroupCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(21, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(21, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчество *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.PeachPuff;
            this.label4.Location = new System.Drawing.Point(23, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата рождения *";
            // 
            // btnAddToBase
            // 
            this.btnAddToBase.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddToBase.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddToBase.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToBase.ForeColor = System.Drawing.Color.Lavender;
            this.btnAddToBase.Location = new System.Drawing.Point(227, 553);
            this.btnAddToBase.Name = "btnAddToBase";
            this.btnAddToBase.Size = new System.Drawing.Size(193, 49);
            this.btnAddToBase.TabIndex = 20;
            this.btnAddToBase.Text = "Добавить студента в группу";
            this.btnAddToBase.UseVisualStyleBackColor = false;
            this.btnAddToBase.Click += new System.EventHandler(this.btnAddToBase_Click);
            // 
            // btnLoadFromBase
            // 
            this.btnLoadFromBase.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLoadFromBase.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLoadFromBase.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadFromBase.ForeColor = System.Drawing.Color.Lavender;
            this.btnLoadFromBase.Location = new System.Drawing.Point(24, 553);
            this.btnLoadFromBase.Name = "btnLoadFromBase";
            this.btnLoadFromBase.Size = new System.Drawing.Size(186, 49);
            this.btnLoadFromBase.TabIndex = 19;
            this.btnLoadFromBase.Text = "Открыть таблицу студентов";
            this.btnLoadFromBase.UseVisualStyleBackColor = false;
            this.btnLoadFromBase.Click += new System.EventHandler(this.btnLoadFromBase_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.PeachPuff;
            this.label5.Location = new System.Drawing.Point(336, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Личные качества";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.PeachPuff;
            this.label6.Location = new System.Drawing.Point(26, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Средний балл *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.PeachPuff;
            this.label7.Location = new System.Drawing.Point(336, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Мероприятия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.PeachPuff;
            this.label8.Location = new System.Drawing.Point(23, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Группа *";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.PeachPuff;
            this.label11.Location = new System.Drawing.Point(28, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Курс *";
            // 
            // chbHead
            // 
            this.chbHead.AutoSize = true;
            this.chbHead.Location = new System.Drawing.Point(483, 475);
            this.chbHead.Name = "chbHead";
            this.chbHead.Size = new System.Drawing.Size(15, 14);
            this.chbHead.TabIndex = 17;
            this.chbHead.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.PeachPuff;
            this.label12.Location = new System.Drawing.Point(336, 474);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Староста *";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.PeachPuff;
            this.label14.Location = new System.Drawing.Point(336, 362);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Способности";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.CalendarForeColor = System.Drawing.Color.Navy;
            this.dtBirthDate.CalendarTitleForeColor = System.Drawing.Color.Navy;
            this.dtBirthDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtBirthDate.Location = new System.Drawing.Point(175, 255);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(120, 20);
            this.dtBirthDate.TabIndex = 5;
            this.dtBirthDate.Value = new System.DateTime(1995, 5, 19, 12, 5, 0, 0);
            // 
            // cbRelationship
            // 
            this.cbRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRelationship.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRelationship.FormattingEnabled = true;
            this.cbRelationship.Items.AddRange(new object[] {
            "Хорошие",
            "Плохие",
            "Нормальные"});
            this.cbRelationship.Location = new System.Drawing.Point(175, 446);
            this.cbRelationship.Name = "cbRelationship";
            this.cbRelationship.Size = new System.Drawing.Size(120, 22);
            this.cbRelationship.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.PeachPuff;
            this.label15.Location = new System.Drawing.Point(26, 446);
            this.label15.MaximumSize = new System.Drawing.Size(150, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 30);
            this.label15.TabIndex = 8;
            this.label15.Text = "Отношения с одногрупниками *";
            // 
            // cbAbilities
            // 
            this.cbAbilities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbilities.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAbilities.ForeColor = System.Drawing.Color.Navy;
            this.cbAbilities.FormattingEnabled = true;
            this.cbAbilities.Items.AddRange(new object[] {
            "Математика",
            "Документация",
            "Программирование"});
            this.cbAbilities.Location = new System.Drawing.Point(485, 362);
            this.cbAbilities.Name = "cbAbilities";
            this.cbAbilities.Size = new System.Drawing.Size(143, 22);
            this.cbAbilities.TabIndex = 9;
            // 
            // cbCourse
            // 
            this.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourse.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbCourse.Location = new System.Drawing.Point(175, 395);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(120, 22);
            this.cbCourse.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.PeachPuff;
            this.label9.Location = new System.Drawing.Point(23, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Опоздания *";
            // 
            // cbLates
            // 
            this.cbLates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLates.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbLates.FormattingEnabled = true;
            this.cbLates.Items.AddRange(new object[] {
            "Никогда",
            "Редко",
            "Часто"});
            this.cbLates.Location = new System.Drawing.Point(175, 498);
            this.cbLates.Name = "cbLates";
            this.cbLates.Size = new System.Drawing.Size(120, 22);
            this.cbLates.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.PeachPuff;
            this.label16.Location = new System.Drawing.Point(336, 402);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 15);
            this.label16.TabIndex = 13;
            this.label16.Text = "Отношение к критике *";
            // 
            // cbCriticism
            // 
            this.cbCriticism.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriticism.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCriticism.ForeColor = System.Drawing.Color.Navy;
            this.cbCriticism.FormattingEnabled = true;
            this.cbCriticism.Items.AddRange(new object[] {
            "Адекватно",
            "Безразлично"});
            this.cbCriticism.Location = new System.Drawing.Point(486, 402);
            this.cbCriticism.Name = "cbCriticism";
            this.cbCriticism.Size = new System.Drawing.Size(145, 22);
            this.cbCriticism.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.PeachPuff;
            this.label17.Location = new System.Drawing.Point(336, 439);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 15);
            this.label17.TabIndex = 13;
            this.label17.Text = "Дисциплина *";
            // 
            // cbDiscipline
            // 
            this.cbDiscipline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscipline.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDiscipline.ForeColor = System.Drawing.Color.Navy;
            this.cbDiscipline.FormattingEnabled = true;
            this.cbDiscipline.Items.AddRange(new object[] {
            "Хорошо",
            "Плохо",
            "Нормально"});
            this.cbDiscipline.Location = new System.Drawing.Point(486, 439);
            this.cbDiscipline.Name = "cbDiscipline";
            this.cbDiscipline.Size = new System.Drawing.Size(145, 22);
            this.cbDiscipline.TabIndex = 16;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblStatus.Location = new System.Drawing.Point(439, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 17);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "lblConnect";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblTable);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Location = new System.Drawing.Point(24, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 44);
            this.panel1.TabIndex = 21;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTable.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTable.Location = new System.Drawing.Point(186, 11);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(58, 17);
            this.lblTable.TabIndex = 20;
            this.lblTable.Text = "lblTable";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUser.Location = new System.Drawing.Point(11, 11);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(52, 17);
            this.lblUser.TabIndex = 20;
            this.lblUser.Text = "lblUser";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentTable,
            this.Theme,
            this.MenuControl,
            this.ChangeUser});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // CurrentTable
            // 
            this.CurrentTable.Name = "CurrentTable";
            this.CurrentTable.Size = new System.Drawing.Size(200, 22);
            this.CurrentTable.Text = "Текущая таблица";
            // 
            // Theme
            // 
            this.Theme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Light,
            this.Dark});
            this.Theme.Name = "Theme";
            this.Theme.Size = new System.Drawing.Size(200, 22);
            this.Theme.Text = "Тема";
            // 
            // Light
            // 
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(118, 22);
            this.Light.Text = "Светлая";
            this.Light.Click += new System.EventHandler(this.LightTheme_click);
            // 
            // Dark
            // 
            this.Dark.Name = "Dark";
            this.Dark.Size = new System.Drawing.Size(118, 22);
            this.Dark.Text = "Темная";
            this.Dark.Click += new System.EventHandler(this.Dark_Click);
            // 
            // MenuControl
            // 
            this.MenuControl.Name = "MenuControl";
            this.MenuControl.Size = new System.Drawing.Size(200, 22);
            this.MenuControl.Text = "Управление";
            this.MenuControl.Click += new System.EventHandler(this.MenuControl_Click);
            // 
            // ChangeUser
            // 
            this.ChangeUser.Name = "ChangeUser";
            this.ChangeUser.Size = new System.Drawing.Size(200, 22);
            this.ChangeUser.Text = "Сменить пользователя";
            this.ChangeUser.Click += new System.EventHandler(this.ChangeUser_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.PeachPuff;
            this.label18.Location = new System.Drawing.Point(26, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 15);
            this.label18.TabIndex = 3;
            this.label18.Text = "Пол *";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.cbGender.Location = new System.Drawing.Point(175, 218);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(120, 21);
            this.cbGender.TabIndex = 4;
            // 
            // btnPersonalQuality
            // 
            this.btnPersonalQuality.Location = new System.Drawing.Point(629, 234);
            this.btnPersonalQuality.Name = "btnPersonalQuality";
            this.btnPersonalQuality.Size = new System.Drawing.Size(20, 56);
            this.btnPersonalQuality.TabIndex = 24;
            this.btnPersonalQuality.Text = "+";
            this.btnPersonalQuality.UseVisualStyleBackColor = true;
            this.btnPersonalQuality.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(629, 107);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(20, 56);
            this.btnEvents.TabIndex = 24;
            this.btnEvents.Text = "+";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // cbGroupe
            // 
            this.cbGroupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupe.FormattingEnabled = true;
            this.cbGroupe.Location = new System.Drawing.Point(175, 296);
            this.cbGroupe.Name = "cbGroupe";
            this.cbGroupe.Size = new System.Drawing.Size(120, 21);
            this.cbGroupe.TabIndex = 12;
            // 
            // btnGroupe
            // 
            this.btnGroupe.Location = new System.Drawing.Point(301, 296);
            this.btnGroupe.Name = "btnGroupe";
            this.btnGroupe.Size = new System.Drawing.Size(20, 21);
            this.btnGroupe.TabIndex = 24;
            this.btnGroupe.Text = "+";
            this.btnGroupe.UseVisualStyleBackColor = true;
            this.btnGroupe.Click += new System.EventHandler(this.btnGroupe_Click);
            // 
            // lbEvents
            // 
            this.lbEvents.ForeColor = System.Drawing.Color.Navy;
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.HorizontalScrollbar = true;
            this.lbEvents.Location = new System.Drawing.Point(483, 107);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(145, 56);
            this.lbEvents.TabIndex = 11;
            // 
            // lbPersonalQuality
            // 
            this.lbPersonalQuality.ForeColor = System.Drawing.Color.Navy;
            this.lbPersonalQuality.FormattingEnabled = true;
            this.lbPersonalQuality.HorizontalScrollbar = true;
            this.lbPersonalQuality.Location = new System.Drawing.Point(483, 234);
            this.lbPersonalQuality.Name = "lbPersonalQuality";
            this.lbPersonalQuality.Size = new System.Drawing.Size(145, 56);
            this.lbPersonalQuality.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.PeachPuff;
            this.label10.Location = new System.Drawing.Point(336, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Коммерческий *";
            // 
            // chbCommercial
            // 
            this.chbCommercial.AutoSize = true;
            this.chbCommercial.Location = new System.Drawing.Point(483, 501);
            this.chbCommercial.Name = "chbCommercial";
            this.chbCommercial.Size = new System.Drawing.Size(15, 14);
            this.chbCommercial.TabIndex = 18;
            this.chbCommercial.UseVisualStyleBackColor = true;
            // 
            // numMidMark
            // 
            this.numMidMark.DecimalPlaces = 1;
            this.numMidMark.ForeColor = System.Drawing.Color.Navy;
            this.numMidMark.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMidMark.Location = new System.Drawing.Point(175, 348);
            this.numMidMark.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            this.numMidMark.Name = "numMidMark";
            this.numMidMark.Size = new System.Drawing.Size(120, 20);
            this.numMidMark.TabIndex = 8;
            this.numMidMark.Value = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.PeachPuff;
            this.label19.Location = new System.Drawing.Point(336, 172);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 15);
            this.label19.TabIndex = 11;
            this.label19.Text = "Олимпиады";
            // 
            // btnOlympiads
            // 
            this.btnOlympiads.Location = new System.Drawing.Point(629, 172);
            this.btnOlympiads.Name = "btnOlympiads";
            this.btnOlympiads.Size = new System.Drawing.Size(20, 56);
            this.btnOlympiads.TabIndex = 24;
            this.btnOlympiads.Text = "+";
            this.btnOlympiads.UseVisualStyleBackColor = true;
            this.btnOlympiads.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // lbOlympiads
            // 
            this.lbOlympiads.ForeColor = System.Drawing.Color.Navy;
            this.lbOlympiads.FormattingEnabled = true;
            this.lbOlympiads.HorizontalScrollbar = true;
            this.lbOlympiads.Location = new System.Drawing.Point(483, 173);
            this.lbOlympiads.Name = "lbOlympiads";
            this.lbOlympiads.Size = new System.Drawing.Size(145, 56);
            this.lbOlympiads.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.PeachPuff;
            this.label20.Location = new System.Drawing.Point(333, 295);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 15);
            this.label20.TabIndex = 7;
            this.label20.Text = "Приказы";
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(629, 296);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(20, 56);
            this.btnOrders.TabIndex = 24;
            this.btnOrders.Text = "+";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // lbOrders
            // 
            this.lbOrders.ForeColor = System.Drawing.Color.Navy;
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.HorizontalScrollbar = true;
            this.lbOrders.Location = new System.Drawing.Point(483, 295);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(145, 56);
            this.lbOrders.TabIndex = 7;
            // 
            // Custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 624);
            this.Controls.Add(this.numMidMark);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.lbPersonalQuality);
            this.Controls.Add(this.lbOlympiads);
            this.Controls.Add(this.lbEvents);
            this.Controls.Add(this.cbGroupe);
            this.Controls.Add(this.btnOlympiads);
            this.Controls.Add(this.btnGroupe);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnPersonalQuality);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbLates);
            this.Controls.Add(this.cbDiscipline);
            this.Controls.Add(this.cbCriticism);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.cbAbilities);
            this.Controls.Add(this.cbRelationship);
            this.Controls.Add(this.dtBirthDate);
            this.Controls.Add(this.chbCommercial);
            this.Controls.Add(this.chbHead);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLoadFromBase);
            this.Controls.Add(this.btnAddToBase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMidName);
            this.Controls.Add(this.tbStudSurname);
            this.Controls.Add(this.tbStudName);
            this.Controls.Add(this.btnCreateWord);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Custom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Custom_FormClosing);
            this.Load += new System.EventHandler(this.Custom_Load);
            this.SizeChanged += new System.EventHandler(this.Custom_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Custom_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMidMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddToBase;
        private System.Windows.Forms.Button btnLoadFromBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox tbStudName;
        public System.Windows.Forms.TextBox tbStudSurname;
        public System.Windows.Forms.TextBox tbMidName;
        public System.Windows.Forms.DateTimePicker dtBirthDate;
        public System.Windows.Forms.ComboBox cbRelationship;
        public System.Windows.Forms.ComboBox cbAbilities;
        public System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cbLates;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.ComboBox cbCriticism;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.ComboBox cbDiscipline;
        public System.Windows.Forms.CheckBox chbHead;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripMenuItem Theme;
        private System.Windows.Forms.ToolStripMenuItem Light;
        private System.Windows.Forms.ToolStripMenuItem Dark;
        private System.Windows.Forms.ToolStripMenuItem MenuControl;
        private System.Windows.Forms.ToolStripMenuItem ChangeUser;
        public System.Windows.Forms.Label lblTable;
        public System.Windows.Forms.ToolStripMenuItem CurrentTable;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnPersonalQuality;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnGroupe;
        public System.Windows.Forms.ComboBox cbGroupe;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.CheckBox chbCommercial;
        public System.Windows.Forms.NumericUpDown numMidMark;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnOlympiads;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnOrders;
        public System.Windows.Forms.ListBox lbEvents;
        public System.Windows.Forms.ListBox lbPersonalQuality;
        public System.Windows.Forms.ListBox lbOlympiads;
        public System.Windows.Forms.ListBox lbOrders;
    }
}

