namespace Gestion_de_Notas
{
    partial class FormSchoolYear
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
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dtg_SchoolYears = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_FechadeInicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechadeFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SchoolYears)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 109;
            this.label4.Text = "Fecha de Fin:";
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(31, 43);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(145, 22);
            this.txt_Year.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 103;
            this.label1.Text = "Año Escolar:";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(840, 490);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(99, 32);
            this.btn_Close.TabIndex = 102;
            this.btn_Close.Text = "Cerrar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(753, 433);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(156, 39);
            this.btn_Delete.TabIndex = 101;
            this.btn_Delete.Text = "Eliminar Año Escolar";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(381, 433);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(164, 39);
            this.btn_Update.TabIndex = 100;
            this.btn_Update.Text = "Modificar Año Escolar";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(31, 433);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(145, 39);
            this.btn_Add.TabIndex = 99;
            this.btn_Add.Text = "Añadir Año Escolar";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dtg_SchoolYears
            // 
            this.dtg_SchoolYears.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_SchoolYears.Location = new System.Drawing.Point(31, 71);
            this.dtg_SchoolYears.Name = "dtg_SchoolYears";
            this.dtg_SchoolYears.RowHeadersWidth = 51;
            this.dtg_SchoolYears.RowTemplate.Height = 24;
            this.dtg_SchoolYears.Size = new System.Drawing.Size(878, 336);
            this.dtg_SchoolYears.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 95;
            this.label5.Text = "Fecha de Inicio:";
            // 
            // dtp_FechadeInicio
            // 
            this.dtp_FechadeInicio.Location = new System.Drawing.Point(345, 43);
            this.dtp_FechadeInicio.Name = "dtp_FechadeInicio";
            this.dtp_FechadeInicio.Size = new System.Drawing.Size(200, 22);
            this.dtp_FechadeInicio.TabIndex = 110;
            // 
            // dtp_FechadeFin
            // 
            this.dtp_FechadeFin.Location = new System.Drawing.Point(709, 43);
            this.dtp_FechadeFin.Name = "dtp_FechadeFin";
            this.dtp_FechadeFin.Size = new System.Drawing.Size(200, 22);
            this.dtp_FechadeFin.TabIndex = 111;
            // 
            // FormSchoolYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 536);
            this.Controls.Add(this.dtp_FechadeFin);
            this.Controls.Add(this.dtp_FechadeInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dtg_SchoolYears);
            this.Controls.Add(this.label5);
            this.Name = "FormSchoolYear";
            this.Text = "FormSchoolYear";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SchoolYears)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dtg_SchoolYears;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_FechadeInicio;
        private System.Windows.Forms.DateTimePicker dtp_FechadeFin;
    }
}