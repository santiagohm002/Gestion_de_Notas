namespace Gestión_de_Notas
{
    partial class FormGrades
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
            this.dtg_Student = new System.Windows.Forms.DataGridView();
            this.txt_Grades = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Consult = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Student
            // 
            this.dtg_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Student.Location = new System.Drawing.Point(37, 95);
            this.dtg_Student.Name = "dtg_Student";
            this.dtg_Student.RowHeadersWidth = 51;
            this.dtg_Student.RowTemplate.Height = 24;
            this.dtg_Student.Size = new System.Drawing.Size(878, 291);
            this.dtg_Student.TabIndex = 65;
            // 
            // txt_Grades
            // 
            this.txt_Grades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Grades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_Grades.FormattingEnabled = true;
            this.txt_Grades.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.txt_Grades.Location = new System.Drawing.Point(92, 56);
            this.txt_Grades.Name = "txt_Grades";
            this.txt_Grades.Size = new System.Drawing.Size(203, 24);
            this.txt_Grades.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 63;
            this.label7.Text = "Grado:";
            // 
            // btn_Consult
            // 
            this.btn_Consult.Location = new System.Drawing.Point(37, 408);
            this.btn_Consult.Name = "btn_Consult";
            this.btn_Consult.Size = new System.Drawing.Size(249, 55);
            this.btn_Consult.TabIndex = 81;
            this.btn_Consult.Text = "Consultar por Especialidad";
            this.btn_Consult.UseVisualStyleBackColor = true;
            this.btn_Consult.Click += new System.EventHandler(this.btn_Consult_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(816, 492);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(99, 32);
            this.btn_Close.TabIndex = 82;
            this.btn_Close.Text = "Cerrar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // FormGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 536);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Consult);
            this.Controls.Add(this.dtg_Student);
            this.Controls.Add(this.txt_Grades);
            this.Controls.Add(this.label7);
            this.Name = "FormGrades";
            this.Text = "FormGrades";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Student;
        private System.Windows.Forms.ComboBox txt_Grades;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Consult;
        private System.Windows.Forms.Button btn_Close;
    }
}