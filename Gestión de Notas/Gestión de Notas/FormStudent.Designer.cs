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
            this.txt_DNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Fullname = new System.Windows.Forms.TextBox();
            this.dtg_Student = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Consult = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.txt_Adress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_Birthdate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "Nombre Completo:";
            // 
            // txt_DNI
            // 
            this.txt_DNI.Location = new System.Drawing.Point(354, 37);
            this.txt_DNI.Name = "txt_DNI";
            this.txt_DNI.Size = new System.Drawing.Size(145, 22);
            this.txt_DNI.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Identificacion:";
            // 
            // txt_Fullname
            // 
            this.txt_Fullname.Location = new System.Drawing.Point(46, 37);
            this.txt_Fullname.Name = "txt_Fullname";
            this.txt_Fullname.Size = new System.Drawing.Size(277, 22);
            this.txt_Fullname.TabIndex = 53;
            // 
            // dtg_Student
            // 
            this.dtg_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Student.Location = new System.Drawing.Point(46, 130);
            this.dtg_Student.Name = "dtg_Student";
            this.dtg_Student.RowHeadersWidth = 51;
            this.dtg_Student.RowTemplate.Height = 24;
            this.dtg_Student.Size = new System.Drawing.Size(878, 279);
            this.dtg_Student.TabIndex = 62;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(286, 435);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(145, 39);
            this.btn_Add.TabIndex = 63;
            this.btn_Add.Text = "Nuevo Estudiante";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(536, 435);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(145, 39);
            this.btn_Update.TabIndex = 64;
            this.btn_Update.Text = "Modificar Estudiante";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(779, 435);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(145, 39);
            this.btn_Delete.TabIndex = 65;
            this.btn_Delete.Text = "Eliminar Estudiante";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Consult
            // 
            this.btn_Consult.Location = new System.Drawing.Point(46, 435);
            this.btn_Consult.Name = "btn_Consult";
            this.btn_Consult.Size = new System.Drawing.Size(160, 39);
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
            // txt_Adress
            // 
            this.txt_Adress.Location = new System.Drawing.Point(46, 89);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(145, 22);
            this.txt_Adress.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Direccion:";
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(354, 89);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(145, 22);
            this.txt_Tel.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Telefono:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(647, 89);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(277, 22);
            this.txt_Email.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Correo Electrónico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // dt_Birthdate
            // 
            this.dt_Birthdate.Checked = false;
            this.dt_Birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Birthdate.Location = new System.Drawing.Point(647, 37);
            this.dt_Birthdate.Name = "dt_Birthdate";
            this.dt_Birthdate.Size = new System.Drawing.Size(277, 22);
            this.dt_Birthdate.TabIndex = 75;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 536);
            this.Controls.Add(this.dt_Birthdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Adress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Consult);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dtg_Student);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_DNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Fullname);
            this.Name = "FormStudent";
            this.Text = "Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Fullname;
        private System.Windows.Forms.DataGridView dtg_Student;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Consult;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox txt_Adress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_Birthdate;
    }
}