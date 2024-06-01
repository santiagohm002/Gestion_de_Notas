namespace Gestión_de_Notas
{
    partial class FormAssigTeach
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Consult = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dtg_Assignments = new System.Windows.Forms.DataGridView();
            this.cbx_Subject = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_Grade = new System.Windows.Forms.ComboBox();
            this.cbx_Teacher = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Assignments)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(840, 490);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(99, 32);
            this.btn_Close.TabIndex = 95;
            this.btn_Close.Text = "Cerrar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Consult
            // 
            this.btn_Consult.Location = new System.Drawing.Point(31, 417);
            this.btn_Consult.Name = "btn_Consult";
            this.btn_Consult.Size = new System.Drawing.Size(145, 55);
            this.btn_Consult.TabIndex = 94;
            this.btn_Consult.Text = "Consultar por Grado";
            this.btn_Consult.UseVisualStyleBackColor = true;
            this.btn_Consult.Click += new System.EventHandler(this.btn_Consult_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(764, 417);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(145, 55);
            this.btn_Delete.TabIndex = 93;
            this.btn_Delete.Text = "Eliminar Docente";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(373, 417);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(145, 55);
            this.btn_Add.TabIndex = 91;
            this.btn_Add.Text = "Asignar Docente";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dtg_Assignments
            // 
            this.dtg_Assignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Assignments.Location = new System.Drawing.Point(31, 85);
            this.dtg_Assignments.Name = "dtg_Assignments";
            this.dtg_Assignments.RowHeadersWidth = 51;
            this.dtg_Assignments.RowTemplate.Height = 24;
            this.dtg_Assignments.Size = new System.Drawing.Size(878, 291);
            this.dtg_Assignments.TabIndex = 90;
            // 
            // cbx_Subject
            // 
            this.cbx_Subject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_Subject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Subject.FormattingEnabled = true;
            this.cbx_Subject.Items.AddRange(new object[] {
            "Matemáticas",
            "Español",
            "Inglés",
            "Naturales",
            "Sociales",
            "Química",
            "Física",
            "Educación Física"});
            this.cbx_Subject.Location = new System.Drawing.Point(764, 35);
            this.cbx_Subject.Name = "cbx_Subject";
            this.cbx_Subject.Size = new System.Drawing.Size(145, 24);
            this.cbx_Subject.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 88;
            this.label8.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(761, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 87;
            this.label7.Text = "Materia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 85;
            this.label5.Text = "Grado:";
            // 
            // cbx_Grade
            // 
            this.cbx_Grade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_Grade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Grade.FormattingEnabled = true;
            this.cbx_Grade.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cbx_Grade.Location = new System.Drawing.Point(373, 35);
            this.cbx_Grade.Name = "cbx_Grade";
            this.cbx_Grade.Size = new System.Drawing.Size(145, 24);
            this.cbx_Grade.TabIndex = 96;
            // 
            // cbx_Teacher
            // 
            this.cbx_Teacher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_Teacher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Teacher.FormattingEnabled = true;
            this.cbx_Teacher.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cbx_Teacher.Location = new System.Drawing.Point(31, 35);
            this.cbx_Teacher.Name = "cbx_Teacher";
            this.cbx_Teacher.Size = new System.Drawing.Size(145, 24);
            this.cbx_Teacher.TabIndex = 97;
            // 
            // FormAssigTeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 536);
            this.Controls.Add(this.cbx_Teacher);
            this.Controls.Add(this.cbx_Grade);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Consult);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dtg_Assignments);
            this.Controls.Add(this.cbx_Subject);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Name = "FormAssigTeach";
            this.Text = "FormAssigTeach";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Assignments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Consult;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dtg_Assignments;
        private System.Windows.Forms.ComboBox cbx_Subject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_Grade;
        private System.Windows.Forms.ComboBox cbx_Teacher;
    }
}