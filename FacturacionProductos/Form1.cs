namespace FacturacionProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboTipoProducto.SelectedIndex = 0; // Selecciona Producto General por defecto
        }

        private void cboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si el tipo de producto es Perecedero, mostrar el DateTimePicker para
            // la fecha de caducidad
            if (cboTipoProducto.SelectedItem.ToString() == "Perecedero")
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

                // Dependiendo del tipo de producto, creamos una instancia de la 
                // clase adecuada
                if (cboTipoProducto.SelectedItem.ToString() == "General")
                {
                    producto = new ProductoGeneral(nombreProducto, precioBase);
                }
                else if (cboTipoProducto.SelectedItem.ToString() == "Electrónico")
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