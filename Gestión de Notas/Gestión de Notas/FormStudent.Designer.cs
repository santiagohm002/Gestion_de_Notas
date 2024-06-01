namespace Gestión_de_Notas
{
    partial class FormStudent
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Grades = new System.Windows.Forms.ComboBox();
            this.dtg_Student = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Consult = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(776, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "Grado:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(536, 37);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(145, 22);
            this.txt_Id.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Identificacion:";
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(286, 37);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(145, 22);
            this.txt_Surname.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Apellido:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(46, 37);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(145, 22);
            this.txt_Name.TabIndex = 53;
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
            this.txt_Grades.Location = new System.Drawing.Point(779, 37);
            this.txt_Grades.Name = "txt_Grades";
            this.txt_Grades.Size = new System.Drawing.Size(145, 24);
            this.txt_Grades.TabIndex = 61;
            // 
            // dtg_Student
            // 
            this.dtg_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Student.Location = new System.Drawing.Point(46, 87);
            this.dtg_Student.Name = "dtg_Student";
            this.dtg_Student.RowHeadersWidth = 51;
            this.dtg_Student.RowTemplate.Height = 24;
            this.dtg_Student.Size = new System.Drawing.Size(878, 291);
            this.dtg_Student.TabIndex = 62;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(286, 419);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(145, 55);
            this.btn_Add.TabIndex = 63;
            this.btn_Add.Text = "Nuevo Estudiante";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(536, 419);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(145, 55);
            this.btn_Update.TabIndex = 64;
            this.btn_Update.Text = "Modificar Estudiante";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(779, 419);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(145, 55);
            this.btn_Delete.TabIndex = 65;
            this.btn_Delete.Text = "Eliminar Estudiante";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Consult
            // 
            this.btn_Consult.Location = new System.Drawing.Point(46, 419);
            this.btn_Consult.Name = "btn_Consult";
            this.btn_Consult.Size = new System.Drawing.Size(145, 55);
            this.btn_Consult.TabIndex = 66;
            this.btn_Consult.Text = "Consultar Estudiante";
            this.btn_Consult.UseVisualStyleBackColor = true;
            this.btn_Consult.Click += new System.EventHandler(this.btn_Consult_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(855, 492);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(99, 32);
            this.btn_Close.TabIndex = 67;
            this.btn_Close.Text = "Cerrar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 536);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Consult);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dtg_Student);
            this.Controls.Add(this.txt_Grades);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Name = "FormStudent";
            this.Text = "Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.ComboBox txt_Grades;
        private System.Windows.Forms.DataGridView dtg_Student;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Consult;
        private System.Windows.Forms.Button btn_Close;
    }
}