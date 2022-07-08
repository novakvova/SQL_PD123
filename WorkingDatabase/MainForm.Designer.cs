namespace WorkingDatabase
{
    partial class MainForm
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
            this.btnGenTabels = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenTabels
            // 
            this.btnGenTabels.Location = new System.Drawing.Point(641, 32);
            this.btnGenTabels.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenTabels.Name = "btnGenTabels";
            this.btnGenTabels.Size = new System.Drawing.Size(184, 74);
            this.btnGenTabels.TabIndex = 0;
            this.btnGenTabels.Text = "Генерація таблиць в БД";
            this.btnGenTabels.UseVisualStyleBackColor = true;
            this.btnGenTabels.Click += new System.EventHandler(this.btnGenTabels_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColEmail,
            this.ColPhone});
            this.dgvUsers.Location = new System.Drawing.Point(12, 32);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.Size = new System.Drawing.Size(622, 379);
            this.dgvUsers.TabIndex = 1;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.Visible = false;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.HeaderText = "Ім\'я";
            this.ColName.Name = "ColName";
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Пошта";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Width = 150;
            // 
            // ColPhone
            // 
            this.ColPhone.HeaderText = "Телефон";
            this.ColPhone.Name = "ColPhone";
            this.ColPhone.Width = 150;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(640, 113);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 45);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 423);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnGenTabels);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGenTabels;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColEmail;
        private DataGridViewTextBoxColumn ColPhone;
        private Button btnSearch;
    }
}