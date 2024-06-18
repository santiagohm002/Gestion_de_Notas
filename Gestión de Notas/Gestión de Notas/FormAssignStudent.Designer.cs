namespace Gestión_de_Notas
{
    partial class FormAssignStudent
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
            this.txt_RoomName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_AssignedStudents = new System.Windows.Forms.DataGridView();
            this.btn_ViewAssignedStudents = new System.Windows.Forms.Button();
            this.txt_StudentName = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_AssignStudent = new System.Windows.Forms.Button();
            this.dtg_Room = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dtg_Students = new System.Windows.Forms.DataGridView();
            this.btn_DeleteAssignment = new System.Windows.Forms.Button();
            this.btn_UpdateAssignment = new System.Windows.Forms.Button();
            this.txt_NewRoomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AssignedStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Room)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_RoomName
            // 
            this.txt_RoomName.Location = new System.Drawing.Point(30, 29);
            this.txt_RoomName.Name = "txt_RoomName";
            this.txt_RoomName.Size = new System.Drawing.Size(154, 22);
            this.txt_RoomName.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 108;
            this.label2.Text = "Salón:";
            // 
            // dtg_AssignedStudents
            // 
            this.dtg_AssignedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_AssignedStudents.Location = new System.Drawing.Point(30, 246);
            this.dtg_AssignedStudents.Name = "dtg_AssignedStudents";
            this.dtg_AssignedStudents.RowHeadersWidth = 51;
            this.dtg_AssignedStudents.RowTemplate.Height = 24;
            this.dtg_AssignedStudents.Size = new System.Drawing.Size(398, 183);
            this.dtg_AssignedStudents.TabIndex = 107;
            // 
            // btn_ViewAssignedStudents
            // 
            this.btn_ViewAssignedStudents.Location = new System.Drawing.Point(264, 435);
            this.btn_ViewAssignedStudents.Name = "btn_ViewAssignedStudents";
            this.btn_ViewAssignedStudents.Size = new System.Drawing.Size(179, 55);
            this.btn_ViewAssignedStudents.TabIndex = 106;
            this.btn_ViewAssignedStudents.Text = "Ver Lista del Salón";
            this.btn_ViewAssignedStudents.UseVisualStyleBackColor = true;
            this.btn_ViewAssignedStudents.Click += new System.EventHandler(this.btn_ViewStudentsInRoom_Click);
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.Location = new System.Drawing.Point(620, 29);
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.Size = new System.Drawing.Size(302, 22);
            this.txt_StudentName.TabIndex = 103;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(855, 496);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(99, 32);
            this.btn_Close.TabIndex = 102;
            this.btn_Close.Text = "Cerrar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_AssignStudent
            // 
            this.btn_AssignStudent.Location = new System.Drawing.Point(30, 435);
            this.btn_AssignStudent.Name = "btn_AssignStudent";
            this.btn_AssignStudent.Size = new System.Drawing.Size(179, 55);
            this.btn_AssignStudent.TabIndex = 101;
            this.btn_AssignStudent.Text = "Asignar Estudiante";
            this.btn_AssignStudent.UseVisualStyleBackColor = true;
            this.btn_AssignStudent.Click += new System.EventHandler(this.btn_AssignStudent_Click);
            // 
            // dtg_Room
            // 
            this.dtg_Room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Room.Location = new System.Drawing.Point(30, 57);
            this.dtg_Room.Name = "dtg_Room";
            this.dtg_Room.RowHeadersWidth = 51;
            this.dtg_Room.RowTemplate.Height = 24;
            this.dtg_Room.Size = new System.Drawing.Size(398, 183);
            this.dtg_Room.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 16);
            this.label7.TabIndex = 99;
            this.label7.Text = "Nombre Completo del Estudiante:";
            // 
            // dtg_Students
            // 
            this.dtg_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Students.Location = new System.Drawing.Point(434, 57);
            this.dtg_Students.Name = "dtg_Students";
            this.dtg_Students.RowHeadersWidth = 51;
            this.dtg_Students.RowTemplate.Height = 24;
            this.dtg_Students.Size = new System.Drawing.Size(488, 372);
            this.dtg_Students.TabIndex = 110;
            // 
            // btn_DeleteAssignment
            // 
            this.btn_DeleteAssignment.Location = new System.Drawing.Point(502, 435);
            this.btn_DeleteAssignment.Name = "btn_DeleteAssignment";
            this.btn_DeleteAssignment.Size = new System.Drawing.Size(179, 55);
            this.btn_DeleteAssignment.TabIndex = 111;
            this.btn_DeleteAssignment.Text = "Eliminar Asignación";
            this.btn_DeleteAssignment.UseVisualStyleBackColor = true;
            this.btn_DeleteAssignment.Click += new System.EventHandler(this.btn_DeleteAssignment_Click);
            // 
            // btn_UpdateAssignment
            // 
            this.btn_UpdateAssignment.Location = new System.Drawing.Point(743, 435);
            this.btn_UpdateAssignment.Name = "btn_UpdateAssignment";
            this.btn_UpdateAssignment.Size = new System.Drawing.Size(179, 55);
            this.btn_UpdateAssignment.TabIndex = 112;
            this.btn_UpdateAssignment.Text = "Modificar Asignación";
            this.btn_UpdateAssignment.UseVisualStyleBackColor = true;
            this.btn_UpdateAssignment.Click += new System.EventHandler(this.btn_UpdateAssignment_Click);
            // 
            // txt_NewRoomName
            // 
            this.txt_NewRoomName.Location = new System.Drawing.Point(319, 29);
            this.txt_NewRoomName.Name = "txt_NewRoomName";
            this.txt_NewRoomName.Size = new System.Drawing.Size(154, 22);
            this.txt_NewRoomName.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 113;
            this.label1.Text = "Nuevo Salón:";
            // 
            // FormAssignStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 536);
            this.Controls.Add(this.txt_NewRoomName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_UpdateAssignment);
            this.Controls.Add(this.btn_DeleteAssignment);
            this.Controls.Add(this.dtg_Students);
            this.Controls.Add(this.txt_RoomName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtg_AssignedStudents);
            this.Controls.Add(this.btn_ViewAssignedStudents);
            this.Controls.Add(this.txt_StudentName);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_AssignStudent);
            this.Controls.Add(this.dtg_Room);
            this.Controls.Add(this.label7);
            this.Name = "FormAssignStudent";
            this.Text = "FormAssignStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AssignedStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Room)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_RoomName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtg_AssignedStudents;
        private System.Windows.Forms.Button btn_ViewAssignedStudents;
        private System.Windows.Forms.TextBox txt_StudentName;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_AssignStudent;
        private System.Windows.Forms.DataGridView dtg_Room;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtg_Students;
        private System.Windows.Forms.Button btn_DeleteAssignment;
        private System.Windows.Forms.Button btn_UpdateAssignment;
        private System.Windows.Forms.TextBox txt_NewRoomName;
        private System.Windows.Forms.Label label1;
    }
}