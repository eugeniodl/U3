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
            cboTipoVehiculo = new ComboBox();
            groupBox1 = new GroupBox();
            btnArrancar = new Button();
            btnDetener = new Button();
            btnCargarDescargar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 31);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo de vehículo";
            // 
            // cboTipoVehiculo
            // 
            cboTipoVehiculo.FormattingEnabled = true;
            cboTipoVehiculo.Location = new Point(204, 28);
            cboTipoVehiculo.Name = "cboTipoVehiculo";
            cboTipoVehiculo.Size = new Size(151, 28);
            cboTipoVehiculo.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCargarDescargar);
            groupBox1.Controls.Add(btnDetener);
            groupBox1.Controls.Add(btnArrancar);
            groupBox1.Location = new Point(25, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(526, 94);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            // 
            // btnArrancar
            // 
            btnArrancar.Location = new Point(20, 41);
            btnArrancar.Name = "btnArrancar";
            btnArrancar.Size = new Size(135, 29);
            btnArrancar.TabIndex = 0;
            btnArrancar.Text = "Arrancar";
            btnArrancar.UseVisualStyleBackColor = true;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(195, 41);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(135, 29);
            btnDetener.TabIndex = 1;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            // 
            // btnCargarDescargar
            // 
            btnCargarDescargar.Location = new Point(372, 41);
            btnCargarDescargar.Name = "btnCargarDescargar";
            btnCargarDescargar.Size = new Size(135, 29);
            btnCargarDescargar.TabIndex = 2;
            btnCargarDescargar.Text = "Cargar/Descargar";
            btnCargarDescargar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 214);
            Controls.Add(groupBox1);
            Controls.Add(cboTipoVehiculo);
            Controls.Add(label1);
            Name = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboTipoVehiculo;
        private GroupBox groupBox1;
        private Button btnCargarDescargar;
        private Button btnDetener;
        private Button btnArrancar;
    }
}