namespace InterfacesForm
{
    public partial class Form1 : Form
    {
        private IVehiculo vehiculoActual;
        private ITransporte transporteActual;

        public Form1()
        {
            InitializeComponent();
            cboTipoVehiculo.Items.AddRange(new object[] { "Carro", "Camión" });
            cboTipoVehiculo.SelectedIndex = 0;
        }

        private void btnArrancar_Click(object sender, EventArgs e)
        {
            SeleccionarVehiculo();
            vehiculoActual.Arrancar();
        }

        private void SeleccionarVehiculo()
        {
            string seleccion = cboTipoVehiculo.SelectedItem.ToString();

            switch (seleccion)
            {
                case "Carro":
                    vehiculoActual = new Carro();
                    transporteActual = vehiculoActual as ITransporte;
                    break;
                case "Camión":
                    vehiculoActual = new Camion();
                    transporteActual = vehiculoActual as ITransporte;
                    break;
                default:
                    MessageBox.Show("Seleccione un tipo de vehículo");
                    break;
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            SeleccionarVehiculo();
            vehiculoActual.Detener();
        }

        private void btnCargarDescargar_Click(object sender, EventArgs e)
        {
            SeleccionarVehiculo();

            if(transporteActual != null)
            {
                transporteActual.Cargar();
                transporteActual.Descargar();
            }
            else
            {
                MessageBox.Show("Este vehículo no puede transportar.");
            }
        }
    }
}