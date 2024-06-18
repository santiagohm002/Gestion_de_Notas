namespace Gestión_de_Notas
{
    partial class FormTeacher
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Adress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dtg_Teacher = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Fullname = new System.Windows.Forms.TextBox();
            this.txt_Specialty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Teacher)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 92;
            this.label4.Text = "Especialidad:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(632, 87);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(277, 22);
            this.txt_Email.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 90;
            this.label3.Text = "Correo Electrónico:";
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(339, 87);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(145, 22);
            this.txt_Tel.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 88;
            this.label2.Text = "Telefono:";
            // 
            // txt_Adress
            // 
            this.txt_Adress.Location = new System.Drawing.Point(31, 87);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(145, 22);
            this.txt_Adress.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "Direccion:";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(840, 490);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(99, 32);
            this.btn_Close.TabIndex = 85;
            this.btn_Close.Text = "Cerrar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(764, 433);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(145, 39);
            this.btn_Delete.TabIndex = 83;
            this.btn_Delete.Text = "Eliminar Docente";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(400, 433);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(145, 39);
            this.btn_Update.TabIndex = 82;
            this.btn_Update.Text = "Modificar Docente";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(31, 433);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(145, 39);
            this.btn_Add.TabIndex = 81;
            this.btn_Add.Text = "Nuevo Docente";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dtg_Teacher
            // 
            this.dtg_Teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Teacher.Location = new System.Drawing.Point(31, 128);
            this.dtg_Teacher.Name = "dtg_Teacher";
            this.dtg_Teacher.RowHeadersWidth = 51;
            this.dtg_Teacher.RowTemplate.Height = 24;
            this.dtg_Teacher.Size = new System.Drawing.Size(878, 279);
            this.dtg_Teacher.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 79;
            this.label8.Text = "Nombre Completo:";
            // 
            // txt_DNI
            // 
            this.txt_DNI.Location = new System.Drawing.Point(339, 35);
            this.txt_DNI.Name = "txt_DNI";
            this.txt_DNI.Size = new System.Drawing.Size(145, 22);
            this.txt_DNI.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 77;
            this.label5.Text = "Identificacion:";
            // 
            // txt_Fullname
            // 
            this.txt_Fullname.Location = new System.Drawing.Point(31, 35);
            this.txt_Fullname.Name = "txt_Fullname";
            this.txt_Fullname.Size = new System.Drawing.Size(277, 22);
            this.txt_Fullname.TabIndex = 76;
            // 
            // txt_Specialty
            // 
            this.txt_Specialty.Location = new System.Drawing.Point(632, 34);
            this.txt_Specialty.Name = "txt_Specialty";
            this.txt_Specialty.Size = new System.Drawing.Size(177, 22);
            this.txt_Specialty.TabIndex = 93;
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 536);
            this.Controls.Add(this.txt_Specialty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Adress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dtg_Teacher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_DNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Fullname);
            this.Name = "FormTeacher";
            this.ShowInTaskbar = false;
            this.Text = "Docentes";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Teacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Adress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dtg_Teacher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Fullname;
        private System.Windows.Forms.TextBox txt_Specialty;
    }
}