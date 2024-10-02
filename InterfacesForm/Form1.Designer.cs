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
            btnCargarDescargar = new Button();
            btnDetener = new Button();
            btnArrancar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo de vehículo";
            // 
            // cboTipoVehiculo
            // 
            cboTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoVehiculo.FormattingEnabled = true;
            cboTipoVehiculo.Location = new Point(178, 21);
            cboTipoVehiculo.Margin = new Padding(3, 2, 3, 2);
            cboTipoVehiculo.Name = "cboTipoVehiculo";
            cboTipoVehiculo.Size = new Size(133, 23);
            cboTipoVehiculo.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCargarDescargar);
            groupBox1.Controls.Add(btnDetener);
            groupBox1.Controls.Add(btnArrancar);
            groupBox1.Location = new Point(22, 62);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(460, 87);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            // 
            // btnCargarDescargar
            // 
            btnCargarDescargar.Location = new Point(326, 31);
            btnCargarDescargar.Margin = new Padding(3, 2, 3, 2);
            btnCargarDescargar.Name = "btnCargarDescargar";
            btnCargarDescargar.Size = new Size(118, 35);
            btnCargarDescargar.TabIndex = 2;
            btnCargarDescargar.Text = "Cargar/Descargar";
            btnCargarDescargar.UseVisualStyleBackColor = true;
            btnCargarDescargar.Click += btnCargarDescargar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(171, 31);
            btnDetener.Margin = new Padding(3, 2, 3, 2);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(118, 35);
            btnDetener.TabIndex = 1;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnArrancar
            // 
            btnArrancar.Location = new Point(18, 31);
            btnArrancar.Margin = new Padding(3, 2, 3, 2);
            btnArrancar.Name = "btnArrancar";
            btnArrancar.Size = new Size(120, 35);
            btnArrancar.TabIndex = 0;
            btnArrancar.Text = "Arrancar";
            btnArrancar.UseVisualStyleBackColor = true;
            btnArrancar.Click += btnArrancar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 160);
            Controls.Add(groupBox1);
            Controls.Add(cboTipoVehiculo);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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