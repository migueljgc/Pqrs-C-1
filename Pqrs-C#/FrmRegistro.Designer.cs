﻿namespace Pqrs_C_
{
    partial class FrmRegistro
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
            label1 = new Label();
            TxtUsuario = new TextBox();
            TxtContraseña = new TextBox();
            BtnRegistar2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(70, 162, 253);
            label1.Location = new Point(111, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 26);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO";
            // 
            // TxtUsuario
            // 
            TxtUsuario.BackColor = Color.White;
            TxtUsuario.BorderStyle = BorderStyle.FixedSingle;
            TxtUsuario.Location = new Point(12, 58);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(138, 23);
            TxtUsuario.TabIndex = 1;
            // 
            // TxtContraseña
            // 
            TxtContraseña.BackColor = Color.White;
            TxtContraseña.BorderStyle = BorderStyle.FixedSingle;
            TxtContraseña.Location = new Point(11, 119);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PasswordChar = '*';
            TxtContraseña.Size = new Size(139, 23);
            TxtContraseña.TabIndex = 2;
            // 
            // BtnRegistar2
            // 
            BtnRegistar2.BackColor = Color.FromArgb(70, 162, 253);
            BtnRegistar2.FlatAppearance.BorderSize = 0;
            BtnRegistar2.FlatStyle = FlatStyle.Flat;
            BtnRegistar2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistar2.ForeColor = Color.White;
            BtnRegistar2.Location = new Point(95, 159);
            BtnRegistar2.Name = "BtnRegistar2";
            BtnRegistar2.Size = new Size(123, 31);
            BtnRegistar2.TabIndex = 3;
            BtnRegistar2.Text = "Registrar";
            BtnRegistar2.UseVisualStyleBackColor = false;
            BtnRegistar2.Click += BtnRegistar2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 40);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 101);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 5;
            label3.Text = "CONTRASEÑA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 101);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "APELLIDO";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 40);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 8;
            label5.Text = "NOMBRE";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.White;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Location = new Point(173, 119);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(139, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(174, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(138, 23);
            txtNombre.TabIndex = 6;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(324, 230);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnRegistar2);
            Controls.Add(TxtContraseña);
            Controls.Add(TxtUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtUsuario;
        private TextBox TxtContraseña;
        private Button BtnRegistar2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtApellido;
        private TextBox txtNombre;
    }
}