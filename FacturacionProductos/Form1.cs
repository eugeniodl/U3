namespace FacturacionProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbTipoProducto.SelectedIndex = 0; // Selecciona Producto General por defecto
        }

        private void cmbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si el tipo de producto es Perecedero, mostrar el DateTimePicker 
            // para la fecha de caducidad
            if (cmbTipoProducto.SelectedItem.ToString() == "Perecedero")
            {
                dtpFechaCaducidad.Visible = true;
                lblCaducidad.Visible = true;
            }
            else
            {
                dtpFechaCaducidad.Visible = false;
                lblCaducidad.Visible = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreProducto = txtNombreProducto.Text;
                decimal precioBase = decimal.Parse(txtPrecioBase.Text);
                Producto producto;
                // Dependiendo del tipo de producto,
                // creamos una instancia de la clase adecuada
                if (cmbTipoProducto.SelectedItem.ToString() == "General")
                {
                    producto = new ProductoGeneral(nombreProducto, precioBase);
                }
                else if (cmbTipoProducto.SelectedItem.ToString() == "Electrónico")
                {
                    producto = new ProductoElectronico(nombreProducto, precioBase);
                }
                else // Producto Perecedero
                {
                    DateTime fechaCaducidad = dtpFechaCaducidad.Value;
                    producto = new ProductoPerecedero(nombreProducto, precioBase,
                        fechaCaducidad);
                }
                // Calculamos el precio final y lo mostramos en el label
                decimal precioFinal = producto.CalcularPrecioFinal();
                lblResultado.Text = $"Precio Final: {precioFinal:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}