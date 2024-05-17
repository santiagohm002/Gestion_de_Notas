namespace Gestión_de_Notas
{
    partial class FormPortalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPortalAdmin));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Period = new System.Windows.Forms.Button();
            this.btn_Teacher = new System.Windows.Forms.Button();
            this.btn_Student = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildform = new System.Windows.Forms.Panel();
            this.btn_Notes = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.panelSideMenu.Controls.Add(this.btn_Notes);
            this.panelSideMenu.Controls.Add(this.btn_Close);
            this.panelSideMenu.Controls.Add(this.btn_Period);
            this.panelSideMenu.Controls.Add(this.btn_Teacher);
            this.panelSideMenu.Controls.Add(this.btn_Student);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 573);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(0, 528);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(250, 45);
            this.btn_Close.TabIndex = 14;
            this.btn_Close.Text = "Salir";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Period
            // 
            this.btn_Period.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Period.FlatAppearance.BorderSize = 0;
            this.btn_Period.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Period.ForeColor = System.Drawing.Color.White;
            this.btn_Period.Location = new System.Drawing.Point(0, 194);
            this.btn_Period.Name = "btn_Period";
            this.btn_Period.Size = new System.Drawing.Size(250, 45);
            this.btn_Period.TabIndex = 7;
            this.btn_Period.Text = "Periodos";
            this.btn_Period.UseVisualStyleBackColor = true;
            this.btn_Period.Click += new System.EventHandler(this.btn_Period_Click);
            // 
            // btn_Teacher
            // 
            this.btn_Teacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Teacher.FlatAppearance.BorderSize = 0;
            this.btn_Teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Teacher.ForeColor = System.Drawing.Color.White;
            this.btn_Teacher.Location = new System.Drawing.Point(0, 149);
            this.btn_Teacher.Name = "btn_Teacher";
            this.btn_Teacher.Size = new System.Drawing.Size(250, 45);
            this.btn_Teacher.TabIndex = 3;
            this.btn_Teacher.Text = "Docentes";
            this.btn_Teacher.UseVisualStyleBackColor = true;
            this.btn_Teacher.Click += new System.EventHandler(this.btn_Teacher_Click);
            // 
            // btn_Student
            // 
            this.btn_Student.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Student.FlatAppearance.BorderSize = 0;
            this.btn_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Student.ForeColor = System.Drawing.Color.White;
            this.btn_Student.Location = new System.Drawing.Point(0, 104);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(250, 45);
            this.btn_Student.TabIndex = 2;
            this.btn_Student.Text = "Estudiantes";
            this.btn_Student.UseVisualStyleBackColor = true;
            this.btn_Student.Click += new System.EventHandler(this.btn_Student_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 104);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(250, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 37);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(347, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © 2024 Hola Mundo Dev\'s House";
            // 
            // panelChildform
            // 
            this.panelChildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildform.Location = new System.Drawing.Point(250, 0);
            this.panelChildform.Name = "panelChildform";
            this.panelChildform.Size = new System.Drawing.Size(966, 536);
            this.panelChildform.TabIndex = 3;
            // 
            // btn_Notes
            // 
            this.btn_Notes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Notes.FlatAppearance.BorderSize = 0;
            this.btn_Notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Notes.ForeColor = System.Drawing.Color.White;
            this.btn_Notes.Location = new System.Drawing.Point(0, 239);
            this.btn_Notes.Name = "btn_Notes";
            this.btn_Notes.Size = new System.Drawing.Size(250, 45);
            this.btn_Notes.TabIndex = 15;
            this.btn_Notes.Text = "Notas";
            this.btn_Notes.UseVisualStyleBackColor = true;
            this.btn_Notes.Click += new System.EventHandler(this.btn_Notes_Click);
            // 
            // FormPortalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 573);
            this.Controls.Add(this.panelChildform);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPortalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portal";
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Button btn_Teacher;
        private System.Windows.Forms.Button btn_Period;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelChildform;
        private System.Windows.Forms.Button btn_Notes;
    }
}