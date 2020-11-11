namespace StudentCharacter
{
    partial class Settings
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
            this.lbTables = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlUserGroups = new System.Windows.Forms.Panel();
            this.pnlNewGroup = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numStartYear = new System.Windows.Forms.NumericUpDown();
            this.numGroupId = new System.Windows.Forms.NumericUpDown();
            this.cbBase = new System.Windows.Forms.ComboBox();
            this.cbSpecialities = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlUserGroups.SuspendLayout();
            this.pnlNewGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGroupId)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTables
            // 
            this.lbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTables.FormattingEnabled = true;
            this.lbTables.ItemHeight = 20;
            this.lbTables.Location = new System.Drawing.Point(16, 48);
            this.lbTables.Name = "lbTables";
            this.lbTables.Size = new System.Drawing.Size(187, 224);
            this.lbTables.TabIndex = 0;
            this.lbTables.SelectedIndexChanged += new System.EventHandler(this.lbTables_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(57, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текущая группа";
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateTable.ForeColor = System.Drawing.Color.Lavender;
            this.btnCreateTable.Location = new System.Drawing.Point(232, 48);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTable.TabIndex = 5;
            this.btnCreateTable.Text = "Добавить";
            this.btnCreateTable.UseVisualStyleBackColor = false;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.ForeColor = System.Drawing.Color.Lavender;
            this.btnDelete.Location = new System.Drawing.Point(232, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlUserGroups
            // 
            this.pnlUserGroups.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserGroups.Controls.Add(this.lbTables);
            this.pnlUserGroups.Controls.Add(this.btnDelete);
            this.pnlUserGroups.Controls.Add(this.label1);
            this.pnlUserGroups.Controls.Add(this.btnCreateTable);
            this.pnlUserGroups.Location = new System.Drawing.Point(12, 12);
            this.pnlUserGroups.Name = "pnlUserGroups";
            this.pnlUserGroups.Size = new System.Drawing.Size(331, 297);
            this.pnlUserGroups.TabIndex = 6;
            // 
            // pnlNewGroup
            // 
            this.pnlNewGroup.BackColor = System.Drawing.Color.Transparent;
            this.pnlNewGroup.Controls.Add(this.label12);
            this.pnlNewGroup.Controls.Add(this.label13);
            this.pnlNewGroup.Controls.Add(this.label11);
            this.pnlNewGroup.Controls.Add(this.label10);
            this.pnlNewGroup.Controls.Add(this.numStartYear);
            this.pnlNewGroup.Controls.Add(this.numGroupId);
            this.pnlNewGroup.Controls.Add(this.cbBase);
            this.pnlNewGroup.Controls.Add(this.cbSpecialities);
            this.pnlNewGroup.Controls.Add(this.btnBack);
            this.pnlNewGroup.Controls.Add(this.btnApply);
            this.pnlNewGroup.Location = new System.Drawing.Point(359, 1);
            this.pnlNewGroup.Name = "pnlNewGroup";
            this.pnlNewGroup.Size = new System.Drawing.Size(337, 308);
            this.pnlNewGroup.TabIndex = 7;
            this.pnlNewGroup.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.PeachPuff;
            this.label12.Location = new System.Drawing.Point(143, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Класс";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.PeachPuff;
            this.label13.Location = new System.Drawing.Point(104, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Год начала обучения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.PeachPuff;
            this.label11.Location = new System.Drawing.Point(115, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Идентификатор";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.PeachPuff;
            this.label10.Location = new System.Drawing.Point(115, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Специальность";
            // 
            // numStartYear
            // 
            this.numStartYear.Location = new System.Drawing.Point(85, 139);
            this.numStartYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numStartYear.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numStartYear.Name = "numStartYear";
            this.numStartYear.Size = new System.Drawing.Size(142, 20);
            this.numStartYear.TabIndex = 9;
            this.numStartYear.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            // 
            // numGroupId
            // 
            this.numGroupId.Location = new System.Drawing.Point(85, 91);
            this.numGroupId.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numGroupId.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numGroupId.Name = "numGroupId";
            this.numGroupId.Size = new System.Drawing.Size(142, 20);
            this.numGroupId.TabIndex = 10;
            this.numGroupId.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // cbBase
            // 
            this.cbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBase.FormattingEnabled = true;
            this.cbBase.Items.AddRange(new object[] {
            "9",
            "11"});
            this.cbBase.Location = new System.Drawing.Point(88, 189);
            this.cbBase.Name = "cbBase";
            this.cbBase.Size = new System.Drawing.Size(142, 21);
            this.cbBase.TabIndex = 7;
            // 
            // cbSpecialities
            // 
            this.cbSpecialities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecialities.FormattingEnabled = true;
            this.cbSpecialities.Location = new System.Drawing.Point(85, 42);
            this.cbSpecialities.Name = "cbSpecialities";
            this.cbSpecialities.Size = new System.Drawing.Size(142, 21);
            this.cbSpecialities.TabIndex = 8;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnApply.ForeColor = System.Drawing.Color.Lavender;
            this.btnApply.Location = new System.Drawing.Point(118, 248);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(93, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Подтвердить";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.ForeColor = System.Drawing.Color.Lavender;
            this.btnBack.Location = new System.Drawing.Point(13, 248);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(697, 310);
            this.Controls.Add(this.pnlNewGroup);
            this.Controls.Add(this.pnlUserGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Управление группами";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Settings_Paint);
            this.pnlUserGroups.ResumeLayout(false);
            this.pnlUserGroups.PerformLayout();
            this.pnlNewGroup.ResumeLayout(false);
            this.pnlNewGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGroupId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlUserGroups;
        private System.Windows.Forms.Panel pnlNewGroup;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numStartYear;
        private System.Windows.Forms.NumericUpDown numGroupId;
        private System.Windows.Forms.ComboBox cbBase;
        private System.Windows.Forms.ComboBox cbSpecialities;
        private System.Windows.Forms.Button btnBack;
    }
}