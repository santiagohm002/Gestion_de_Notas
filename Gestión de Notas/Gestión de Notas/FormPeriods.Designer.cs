namespace Gestión_de_Notas
{
    partial class FormPeriods
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
            this.txt_Period = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_Periods = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dtg_SchoolYear = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Periods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SchoolYear)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Period
            // 
            this.txt_Period.Location = new System.Drawing.Point(67, 59);
            this.txt_Period.Name = "txt_Period";
            this.txt_Period.Size = new System.Drawing.Size(154, 22);
            this.txt_Period.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 107;
            this.label2.Text = "Periodo:";
            // 
            // dtg_Periods
            // 
            this.dtg_Periods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Periods.Location = new System.Drawing.Point(531, 103);
            this.dtg_Periods.Name = "dtg_Periods";
            this.dtg_Periods.RowHeadersWidth = 51;
            this.dtg_Periods.RowTemplate.Height = 24;
            this.dtg_Periods.Size = new System.Drawing.Size(380, 291);
            this.dtg_Periods.TabIndex = 106;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(734, 416);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(177, 55);
            this.btn_Delete.TabIndex = 105;
            this.btn_Delete.Text = "Eliminar Periodo";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(293, 59);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(154, 22);
            this.txt_Year.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 103;
            this.label1.Text = "Año Escolar:";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(67, 416);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(188, 55);
            this.btn_Add.TabIndex = 101;
            this.btn_Add.Text = "Agregar Periodo";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dtg_SchoolYear
            // 
            this.dtg_SchoolYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_SchoolYear.Location = new System.Drawing.Point(67, 103);
            this.dtg_SchoolYear.Name = "dtg_SchoolYear";
            this.dtg_SchoolYear.RowHeadersWidth = 51;
            this.dtg_SchoolYear.RowTemplate.Height = 24;
            this.dtg_SchoolYear.Size = new System.Drawing.Size(380, 291);
            this.dtg_SchoolYear.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 99;
            this.label7.Text = "Fecha de inicio:";
            // 
            // dtp_FechaInicio
            // 
            this.dtp_FechaInicio.Location = new System.Drawing.Point(484, 57);
            this.dtp_FechaInicio.Name = "dtp_FechaInicio";
            this.dtp_FechaInicio.Size = new System.Drawing.Size(200, 22);
            this.dtp_FechaInicio.TabIndex = 109;
            // 
            // dtp_FechaFin
            // 
            this.dtp_FechaFin.Location = new System.Drawing.Point(711, 57);
            this.dtp_FechaFin.Name = "dtp_FechaFin";
            this.dtp_FechaFin.Size = new System.Drawing.Size(200, 22);
            this.dtp_FechaFin.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(708, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 110;
            this.label3.Text = "Fecha de Fin:";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(405, 416);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(177, 55);
            this.btn_Update.TabIndex = 112;
            this.btn_Update.Text = "Modificar Periodo";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(846, 490);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(108, 34);
            this.btn_Close.TabIndex = 113;
            this.btn_Close.Text = "Cerrar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // FormPeriods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 536);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.dtp_FechaFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_FechaInicio);
            this.Controls.Add(this.txt_Period);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtg_Periods);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.txt_Year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dtg_SchoolYear);
            this.Controls.Add(this.label7);
            this.Name = "FormPeriods";
            this.Text = "FormPeriods";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Periods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SchoolYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Period;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtg_Periods;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dtg_SchoolYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_FechaInicio;
        private System.Windows.Forms.DateTimePicker dtp_FechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Close;
    }
}