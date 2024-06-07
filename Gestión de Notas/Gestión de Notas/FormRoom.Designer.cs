namespace Gestión_de_Notas
{
    partial class FormRoom
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
            this.btn_DeleteRoom = new System.Windows.Forms.Button();
            this.txt_LevelEd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Room = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_AddRoom = new System.Windows.Forms.Button();
            this.dtg_Grades = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dtg_Room = new System.Windows.Forms.DataGridView();
            this.txt_Grades = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Grades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Room)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DeleteRoom
            // 
            this.btn_DeleteRoom.Location = new System.Drawing.Point(528, 405);
            this.btn_DeleteRoom.Name = "btn_DeleteRoom";
            this.btn_DeleteRoom.Size = new System.Drawing.Size(380, 55);
            this.btn_DeleteRoom.TabIndex = 95;
            this.btn_DeleteRoom.Text = "Eliminar Salón";
            this.btn_DeleteRoom.UseVisualStyleBackColor = true;
            this.btn_DeleteRoom.Click += new System.EventHandler(this.btn_DeleteRoom_Click);
            // 
            // txt_LevelEd
            // 
            this.txt_LevelEd.Location = new System.Drawing.Point(290, 48);
            this.txt_LevelEd.Name = "txt_LevelEd";
            this.txt_LevelEd.ReadOnly = true;
            this.txt_LevelEd.Size = new System.Drawing.Size(154, 22);
            this.txt_LevelEd.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 93;
            this.label1.Text = "Nivel Educativo";
            // 
            // txt_Room
            // 
            this.txt_Room.Location = new System.Drawing.Point(528, 48);
            this.txt_Room.Name = "txt_Room";
            this.txt_Room.Size = new System.Drawing.Size(154, 22);
            this.txt_Room.TabIndex = 92;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(809, 481);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(99, 32);
            this.btn_Close.TabIndex = 91;
            this.btn_Close.Text = "Cerrar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_AddRoom
            // 
            this.btn_AddRoom.Location = new System.Drawing.Point(64, 405);
            this.btn_AddRoom.Name = "btn_AddRoom";
            this.btn_AddRoom.Size = new System.Drawing.Size(380, 55);
            this.btn_AddRoom.TabIndex = 90;
            this.btn_AddRoom.Text = "Agregar Salón";
            this.btn_AddRoom.UseVisualStyleBackColor = true;
            this.btn_AddRoom.Click += new System.EventHandler(this.btn_AddRoom_Click);
            // 
            // dtg_Grades
            // 
            this.dtg_Grades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Grades.Location = new System.Drawing.Point(64, 92);
            this.dtg_Grades.Name = "dtg_Grades";
            this.dtg_Grades.RowHeadersWidth = 51;
            this.dtg_Grades.RowTemplate.Height = 24;
            this.dtg_Grades.Size = new System.Drawing.Size(380, 291);
            this.dtg_Grades.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 88;
            this.label7.Text = "Nombre de Salón:";
            // 
            // dtg_Room
            // 
            this.dtg_Room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Room.Location = new System.Drawing.Point(528, 92);
            this.dtg_Room.Name = "dtg_Room";
            this.dtg_Room.RowHeadersWidth = 51;
            this.dtg_Room.RowTemplate.Height = 24;
            this.dtg_Room.Size = new System.Drawing.Size(380, 291);
            this.dtg_Room.TabIndex = 96;
            // 
            // txt_Grades
            // 
            this.txt_Grades.Location = new System.Drawing.Point(64, 48);
            this.txt_Grades.Name = "txt_Grades";
            this.txt_Grades.Size = new System.Drawing.Size(154, 22);
            this.txt_Grades.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 97;
            this.label2.Text = "Grado:";
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 536);
            this.Controls.Add(this.txt_Grades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtg_Room);
            this.Controls.Add(this.btn_DeleteRoom);
            this.Controls.Add(this.txt_LevelEd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Room);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_AddRoom);
            this.Controls.Add(this.dtg_Grades);
            this.Controls.Add(this.label7);
            this.Name = "FormRoom";
            this.Text = "FormRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Grades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Room)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_DeleteRoom;
        private System.Windows.Forms.TextBox txt_LevelEd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Room;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_AddRoom;
        private System.Windows.Forms.DataGridView dtg_Grades;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtg_Room;
        private System.Windows.Forms.TextBox txt_Grades;
        private System.Windows.Forms.Label label2;
    }
}