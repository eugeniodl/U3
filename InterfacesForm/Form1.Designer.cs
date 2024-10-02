namespace InterfacesForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbTipoVehiculo = new ComboBox();
            btnArrancar = new Button();
            btnDetener = new Button();
            btnCargarDescargar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 30);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 0;
            label1.Text = "Tipo de vehículo:";
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoVehiculo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(274, 27);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(193, 36);
            cmbTipoVehiculo.TabIndex = 1;
            // 
            // btnArrancar
            // 
            btnArrancar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnArrancar.Location = new Point(47, 114);
            btnArrancar.Name = "btnArrancar";
            btnArrancar.Size = new Size(193, 48);
            btnArrancar.TabIndex = 2;
            btnArrancar.Text = "Arrancar";
            btnArrancar.UseVisualStyleBackColor = true;
            btnArrancar.Click += btnArrancar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetener.Location = new Point(274, 114);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(193, 48);
            btnDetener.TabIndex = 3;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnCargarDescargar
            // 
            btnCargarDescargar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargarDescargar.Location = new Point(496, 114);
            btnCargarDescargar.Name = "btnCargarDescargar";
            btnCargarDescargar.Size = new Size(193, 48);
            btnCargarDescargar.TabIndex = 4;
            btnCargarDescargar.Text = "Cargar/Descargar";
            btnCargarDescargar.UseVisualStyleBackColor = true;
            btnCargarDescargar.Click += btnCargarDescargar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 198);
            Controls.Add(btnCargarDescargar);
            Controls.Add(btnDetener);
            Controls.Add(btnArrancar);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbTipoVehiculo;
        private Button btnArrancar;
        private Button btnDetener;
        private Button btnCargarDescargar;
    }
}