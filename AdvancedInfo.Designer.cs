namespace StudentCharacter
{
    partial class AdvancedInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedInfo));
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbApply = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblInfoType = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblTextDate = new System.Windows.Forms.Label();
            this.dgvBase = new System.Windows.Forms.DataGridView();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(374, 244);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(310, 46);
            this.tbName.TabIndex = 1;
            // 
            // tbApply
            // 
            this.tbApply.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbApply.ForeColor = System.Drawing.Color.Lavender;
            this.tbApply.Location = new System.Drawing.Point(597, 299);
            this.tbApply.Name = "tbApply";
            this.tbApply.Size = new System.Drawing.Size(87, 41);
            this.tbApply.TabIndex = 2;
            this.tbApply.Text = "Добавить";
            this.tbApply.UseVisualStyleBackColor = false;
            this.tbApply.Click += new System.EventHandler(this.tbApply_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.Color.PeachPuff;
            this.lblName.Location = new System.Drawing.Point(22, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(371, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Коллекция";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTransfer.ForeColor = System.Drawing.Color.Lavender;
            this.btnTransfer.Location = new System.Drawing.Point(329, 102);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(35, 28);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "<";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblInfoType
            // 
            this.lblInfoType.AutoSize = true;
            this.lblInfoType.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoType.ForeColor = System.Drawing.Color.PeachPuff;
            this.lblInfoType.Location = new System.Drawing.Point(374, 224);
            this.lblInfoType.Name = "lblInfoType";
            this.lblInfoType.Size = new System.Drawing.Size(120, 13);
            this.lblInfoType.TabIndex = 4;
            this.lblInfoType.Text = "Меропритие/качество";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(374, 320);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 20);
            this.dtDate.TabIndex = 5;
            // 
            // lblTextDate
            // 
            this.lblTextDate.AutoSize = true;
            this.lblTextDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTextDate.ForeColor = System.Drawing.Color.PeachPuff;
            this.lblTextDate.Location = new System.Drawing.Point(374, 299);
            this.lblTextDate.Name = "lblTextDate";
            this.lblTextDate.Size = new System.Drawing.Size(33, 13);
            this.lblTextDate.TabIndex = 4;
            this.lblTextDate.Text = "Дата";
            // 
            // dgvBase
            // 
            this.dgvBase.AllowUserToAddRows = false;
            this.dgvBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBase.BackgroundColor = System.Drawing.Color.White;
            this.dgvBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBase.GridColor = System.Drawing.Color.White;
            this.dgvBase.Location = new System.Drawing.Point(374, 31);
            this.dgvBase.Name = "dgvBase";
            this.dgvBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBase.Size = new System.Drawing.Size(310, 190);
            this.dgvBase.TabIndex = 6;
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.GridColor = System.Drawing.Color.White;
            this.dgvStudent.Location = new System.Drawing.Point(12, 31);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(310, 309);
            this.dgvStudent.TabIndex = 6;
            // 
            // AdvancedInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(708, 374);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.dgvBase);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.lblTextDate);
            this.Controls.Add(this.lblInfoType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.tbApply);
            this.Controls.Add(this.tbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvancedInfo";
            this.ShowIcon = false;
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.Personal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AdvancedInfo_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button tbApply;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblInfoType;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblTextDate;
        private System.Windows.Forms.DataGridView dgvBase;
        private System.Windows.Forms.DataGridView dgvStudent;
    }
}