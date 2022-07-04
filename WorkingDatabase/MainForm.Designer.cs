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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 423);
            this.Controls.Add(this.btnGenTabels);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGenTabels;
    }
}