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
            btnEnviarEmail = new Button();
            btnEnviarSMS = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 19);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Notificaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 64);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(212, 61);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(237, 27);
            txtUsuario.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(498, 59);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 113);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "Mensaje:";
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(212, 110);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(380, 177);
            txtMensaje.TabIndex = 5;
            // 
            // btnEnviarEmail
            // 
            btnEnviarEmail.Location = new Point(212, 303);
            btnEnviarEmail.Name = "btnEnviarEmail";
            btnEnviarEmail.Size = new Size(173, 29);
            btnEnviarEmail.TabIndex = 6;
            btnEnviarEmail.Text = "Enviar por Email";
            btnEnviarEmail.UseVisualStyleBackColor = true;
            // 
            // btnEnviarSMS
            // 
            btnEnviarSMS.Location = new Point(437, 303);
            btnEnviarSMS.Name = "btnEnviarSMS";
            btnEnviarSMS.Size = new Size(155, 29);
            btnEnviarSMS.TabIndex = 7;
            btnEnviarSMS.Text = "Enviar por SMS";
            btnEnviarSMS.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 362);
            Controls.Add(btnEnviarSMS);
            Controls.Add(btnEnviarEmail);
            Controls.Add(txtMensaje);
            Controls.Add(label3);
            Controls.Add(btnAgregar);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Button btnEnviarEmail;
        private Button btnEnviarSMS;
    }
}