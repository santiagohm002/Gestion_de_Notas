namespace Gestion_de_Notas
{
    partial class FormSubject
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
            this.txt_Roomname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dtg_Teachers = new System.Windows.Forms.DataGridView();
            this.txt_Fullname = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dtg_Subjects = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Subjectname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtg_Classrooms = new System.Windows.Forms.DataGridView();
            this.btn_SearchBySpecialty = new System.Windows.Forms.Button();
            this.btn_SearchByRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Subjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Classrooms)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Roomname
            // 
            this.txt_Roomname.Location = new System.Drawing.Point(414, 40);
            this.txt_Roomname.Name = "txt_Roomname";
            this.txt_Roomname.Size = new System.Drawing.Size(154, 22);
            this.txt_Roomname.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 127;
            this.label1.Text = "Salón:";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(576, 434);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(179, 55);
            this.btn_Update.TabIndex = 126;
            this.btn_Update.Text = "Modificar Asignación";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(761, 434);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(179, 55);
            this.btn_Delete.TabIndex = 125;
            this.btn_Delete.Text = "Eliminar Asignación";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dtg_Teachers
            // 
            this.dtg_Teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Teachers.Location = new System.Drawing.Point(37, 68);
            this.dtg_Teachers.Name = "dtg_Teachers";
            this.dtg_Teachers.RowHeadersWidth = 51;
            this.dtg_Teachers.RowTemplate.Height = 24;
            this.dtg_Teachers.Size = new System.Drawing.Size(442, 177);
            this.dtg_Teachers.TabIndex = 121;
            // 
            // txt_Fullname
            // 
            this.txt_Fullname.Location = new System.Drawing.Point(37, 40);
            this.txt_Fullname.Name = "txt_Fullname";
            this.txt_Fullname.Size = new System.Drawing.Size(302, 22);
            this.txt_Fullname.TabIndex = 119;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(848, 495);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(99, 32);
            this.btn_Close.TabIndex = 118;
            this.btn_Close.Text = "Cerrar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(23, 434);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(179, 55);
            this.btn_Add.TabIndex = 117;
            this.btn_Add.Text = "Asignar Docente";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dtg_Subjects
            // 
            this.dtg_Subjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Subjects.Location = new System.Drawing.Point(485, 68);
            this.dtg_Subjects.Name = "dtg_Subjects";
            this.dtg_Subjects.RowHeadersWidth = 51;
            this.dtg_Subjects.RowTemplate.Height = 24;
            this.dtg_Subjects.Size = new System.Drawing.Size(442, 360);
            this.dtg_Subjects.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 16);
            this.label7.TabIndex = 115;
            this.label7.Text = "Nombre Completo del Docente:";
            // 
            // txt_Subjectname
            // 
            this.txt_Subjectname.Location = new System.Drawing.Point(749, 40);
            this.txt_Subjectname.Name = "txt_Subjectname";
            this.txt_Subjectname.Size = new System.Drawing.Size(154, 22);
            this.txt_Subjectname.TabIndex = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(746, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 129;
            this.label3.Text = "Materia:";
            // 
            // dtg_Classrooms
            // 
            this.dtg_Classrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Classrooms.Location = new System.Drawing.Point(37, 251);
            this.dtg_Classrooms.Name = "dtg_Classrooms";
            this.dtg_Classrooms.RowHeadersWidth = 51;
            this.dtg_Classrooms.RowTemplate.Height = 24;
            this.dtg_Classrooms.Size = new System.Drawing.Size(442, 177);
            this.dtg_Classrooms.TabIndex = 131;
            // 
            // btn_SearchBySpecialty
            // 
            this.btn_SearchBySpecialty.Location = new System.Drawing.Point(208, 434);
            this.btn_SearchBySpecialty.Name = "btn_SearchBySpecialty";
            this.btn_SearchBySpecialty.Size = new System.Drawing.Size(179, 55);
            this.btn_SearchBySpecialty.TabIndex = 132;
            this.btn_SearchBySpecialty.Text = "Consultar Docente por Especialidad";
            this.btn_SearchBySpecialty.UseVisualStyleBackColor = true;
            this.btn_SearchBySpecialty.Click += new System.EventHandler(this.btn_SearchBySpecialty_Click);
            // 
            // btn_SearchByRoom
            // 
            this.btn_SearchByRoom.Location = new System.Drawing.Point(391, 434);
            this.btn_SearchByRoom.Name = "btn_SearchByRoom";
            this.btn_SearchByRoom.Size = new System.Drawing.Size(179, 55);
            this.btn_SearchByRoom.TabIndex = 133;
            this.btn_SearchByRoom.Text = "Consultar Asignación por Salón";
            this.btn_SearchByRoom.UseVisualStyleBackColor = true;
            this.btn_SearchByRoom.Click += new System.EventHandler(this.btn_SearchByRoom_Click);
            // 
            // FormSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 536);
            this.Controls.Add(this.btn_SearchByRoom);
            this.Controls.Add(this.btn_SearchBySpecialty);
            this.Controls.Add(this.dtg_Classrooms);
            this.Controls.Add(this.txt_Subjectname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Roomname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dtg_Teachers);
            this.Controls.Add(this.txt_Fullname);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dtg_Subjects);
            this.Controls.Add(this.label7);
            this.Name = "FormSubject";
            this.Text = "FormSubject";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Teachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Subjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Classrooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Roomname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dtg_Teachers;
        private System.Windows.Forms.TextBox txt_Fullname;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dtg_Subjects;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Subjectname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtg_Classrooms;
        private System.Windows.Forms.Button btn_SearchBySpecialty;
        private System.Windows.Forms.Button btn_SearchByRoom;
    }
}