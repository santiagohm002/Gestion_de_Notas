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
            this.dtg_Grades = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_AddGrade = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.txt_Grades = new System.Windows.Forms.TextBox();
            this.txt_LevelEd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DeleteGrad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Grades)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Grades
            // 
            this.dtg_Grades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Grades.Location = new System.Drawing.Point(37, 95);
            this.dtg_Grades.Name = "dtg_Grades";
            this.dtg_Grades.RowHeadersWidth = 51;
            this.dtg_Grades.RowTemplate.Height = 24;
            this.dtg_Grades.Size = new System.Drawing.Size(487, 291);
            this.dtg_Grades.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 63;
            this.label7.Text = "Nombre de Grado";
            // 
            // btn_AddGrade
            // 
            this.btn_AddGrade.Location = new System.Drawing.Point(37, 408);
            this.btn_AddGrade.Name = "btn_AddGrade";
            this.btn_AddGrade.Size = new System.Drawing.Size(213, 55);
            this.btn_AddGrade.TabIndex = 81;
            this.btn_AddGrade.Text = "Agregar Grado";
            this.btn_AddGrade.UseVisualStyleBackColor = true;
            this.btn_AddGrade.Click += new System.EventHandler(this.btn_AddGrade_Click);
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
            // txt_Grades
            // 
            this.txt_Grades.Location = new System.Drawing.Point(37, 46);
            this.txt_Grades.Name = "txt_Grades";
            this.txt_Grades.Size = new System.Drawing.Size(154, 22);
            this.txt_Grades.TabIndex = 83;
            // 
            // txt_LevelEd
            // 
            this.txt_LevelEd.Location = new System.Drawing.Point(370, 46);
            this.txt_LevelEd.Name = "txt_LevelEd";
            this.txt_LevelEd.ReadOnly = true;
            this.txt_LevelEd.Size = new System.Drawing.Size(154, 22);
            this.txt_LevelEd.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = "Nivel Educativo";
            // 
            // btn_DeleteGrad
            // 
            this.btn_DeleteGrad.Location = new System.Drawing.Point(311, 408);
            this.btn_DeleteGrad.Name = "btn_DeleteGrad";
            this.btn_DeleteGrad.Size = new System.Drawing.Size(213, 55);
            this.btn_DeleteGrad.TabIndex = 86;
            this.btn_DeleteGrad.Text = "Eliminar Grado";
            this.btn_DeleteGrad.UseVisualStyleBackColor = true;
            this.btn_DeleteGrad.Click += new System.EventHandler(this.btn_DeleteGrad_Click);
            // 
            // FormGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 536);
            this.Controls.Add(this.btn_DeleteGrad);
            this.Controls.Add(this.txt_LevelEd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Grades);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_AddGrade);
            this.Controls.Add(this.dtg_Grades);
            this.Controls.Add(this.label7);
            this.Name = "FormGrades";
            this.Text = "FormGrades";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Grades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Grades;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_AddGrade;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox txt_Grades;
        private System.Windows.Forms.TextBox txt_LevelEd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DeleteGrad;
    }
}