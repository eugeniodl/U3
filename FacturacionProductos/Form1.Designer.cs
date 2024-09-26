namespace FacturacionProductos
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
            label2 = new Label();
            cboTipoProducto = new ComboBox();
            label3 = new Label();
            txtNombreProducto = new TextBox();
            label4 = new Label();
            txtPrecioBase = new TextBox();
            lblCaducidad = new Label();
            dtpFechaCaducidad = new DateTimePicker();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(127, 9);
            label1.Name = "label1";
            label1.Size = new Size(348, 38);
            label1.TabIndex = 0;
            label1.Text = "Facturación de Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 77);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Producto:";
            // 
            // cboTipoProducto
            // 
            cboTipoProducto.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cboTipoProducto.FormattingEnabled = true;
            cboTipoProducto.Items.AddRange(new object[] { "General", "Electrónico", "Perecedero" });
            cboTipoProducto.Location = new Point(265, 74);
            cboTipoProducto.Name = "cboTipoProducto";
            cboTipoProducto.Size = new Size(151, 33);
            cboTipoProducto.TabIndex = 2;
            cboTipoProducto.SelectedIndexChanged += cboTipoProducto_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(60, 124);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 3;
            label3.Text = "Nombre de Producto:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreProducto.Location = new Point(265, 121);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(151, 31);
            txtNombreProducto.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 170);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 5;
            label4.Text = "Precio Base:";
            // 
            // txtPrecioBase
            // 
            txtPrecioBase.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioBase.Location = new Point(265, 167);
            txtPrecioBase.Name = "txtPrecioBase";
            txtPrecioBase.Size = new Size(151, 31);
            txtPrecioBase.TabIndex = 6;
            // 
            // lblCaducidad
            // 
            lblCaducidad.AutoSize = true;
            lblCaducidad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaducidad.Location = new Point(60, 216);
            lblCaducidad.Name = "lblCaducidad";
            lblCaducidad.Size = new Size(175, 25);
            lblCaducidad.TabIndex = 7;
            lblCaducidad.Text = "Fecha de Caducidad:";
            lblCaducidad.Visible = false;
            // 
            // dtpFechaCaducidad
            // 
            dtpFechaCaducidad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaCaducidad.Format = DateTimePickerFormat.Short;
            dtpFechaCaducidad.Location = new Point(265, 211);
            dtpFechaCaducidad.Name = "dtpFechaCaducidad";
            dtpFechaCaducidad.Size = new Size(151, 31);
            dtpFechaCaducidad.TabIndex = 8;
            dtpFechaCaducidad.Visible = false;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(275, 269);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(111, 35);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(435, 274);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(115, 25);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Precio Final:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 333);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(dtpFechaCaducidad);
            Controls.Add(lblCaducidad);
            Controls.Add(txtPrecioBase);
            Controls.Add(label4);
            Controls.Add(txtNombreProducto);
            Controls.Add(label3);
            Controls.Add(cboTipoProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Facturación de Productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboTipoProducto;
        private Label label3;
        private TextBox txtNombreProducto;
        private Label label4;
        private TextBox txtPrecioBase;
        private Label lblCaducidad;
        private DateTimePicker dtpFechaCaducidad;
        private Button btnCalcular;
        private Label lblResultado;
    }
}