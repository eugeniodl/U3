namespace NotificacionesForm
{
    partial class MainForm
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
            label2 = new Label();
            txtUsuario = new TextBox();
            btnAgregar = new Button();
            label3 = new Label();
            txtMensaje = new TextBox();
            btnEnviarSMS = new Button();
            btnEnviarEmail = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(375, 18);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 50);
            label1.TabIndex = 0;
            label1.Text = "Notificaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 121);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 38);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(278, 118);
            txtUsuario.Margin = new Padding(5, 6, 5, 6);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(419, 45);
            txtUsuario.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(728, 111);
            btnAgregar.Margin = new Padding(5, 6, 5, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(158, 58);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(57, 232);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 38);
            label3.TabIndex = 4;
            label3.Text = "Mensaje:";
            // 
            // txtMensaje
            // 
            txtMensaje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMensaje.Location = new Point(278, 226);
            txtMensaje.Margin = new Padding(5, 6, 5, 6);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(606, 288);
            txtMensaje.TabIndex = 5;
            // 
            // btnEnviarSMS
            // 
            btnEnviarSMS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviarSMS.Location = new Point(278, 574);
            btnEnviarSMS.Margin = new Padding(5, 6, 5, 6);
            btnEnviarSMS.Name = "btnEnviarSMS";
            btnEnviarSMS.Size = new Size(278, 78);
            btnEnviarSMS.TabIndex = 6;
            btnEnviarSMS.Text = "Enviar por SMS";
            btnEnviarSMS.UseVisualStyleBackColor = true;
            btnEnviarSMS.Click += btnEnviarSMS_Click;
            // 
            // btnEnviarEmail
            // 
            btnEnviarEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviarEmail.Location = new Point(627, 574);
            btnEnviarEmail.Margin = new Padding(5, 6, 5, 6);
            btnEnviarEmail.Name = "btnEnviarEmail";
            btnEnviarEmail.Size = new Size(259, 78);
            btnEnviarEmail.TabIndex = 7;
            btnEnviarEmail.Text = "Enviar por Email";
            btnEnviarEmail.UseVisualStyleBackColor = true;
            btnEnviarEmail.Click += btnEnviarEmail_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 694);
            Controls.Add(btnEnviarEmail);
            Controls.Add(btnEnviarSMS);
            Controls.Add(txtMensaje);
            Controls.Add(label3);
            Controls.Add(btnAgregar);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Button btnAgregar;
        private Label label3;
        private TextBox txtMensaje;
        private Button btnEnviarSMS;
        private Button btnEnviarEmail;
    }
}