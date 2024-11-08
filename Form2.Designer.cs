namespace t
{
    partial class Form2
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.numGrade = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBoxGrades = new System.Windows.Forms.ListBox();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(38, 372);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // numGrade
            // 
            this.numGrade.Location = new System.Drawing.Point(170, 373);
            this.numGrade.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numGrade.Name = "numGrade";
            this.numGrade.Size = new System.Drawing.Size(98, 22);
            this.numGrade.TabIndex = 1;
            this.numGrade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(300, 373);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(168, 22);
            this.dateTimePicker.TabIndex = 2;
            // 
            // listBoxGrades
            // 
            this.listBoxGrades.FormattingEnabled = true;
            this.listBoxGrades.ItemHeight = 16;
            this.listBoxGrades.Location = new System.Drawing.Point(38, 58);
            this.listBoxGrades.Name = "listBoxGrades";
            this.listBoxGrades.ScrollAlwaysVisible = true;
            this.listBoxGrades.Size = new System.Drawing.Size(430, 260);
            this.listBoxGrades.TabIndex = 3;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(487, 371);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(99, 23);
            this.btnAddGrade.TabIndex = 4;
            this.btnAddGrade.Text = "Добавить";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click_1);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(487, 67);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(99, 23);
            this.btnAnalyze.TabIndex = 5;
            this.btnAnalyze.Text = "Рейтинг";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnAddGrade);
            this.Controls.Add(this.listBoxGrades);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.numGrade);
            this.Controls.Add(this.txtName);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numGrade;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListBox listBoxGrades;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button button1;
    }
}