namespace InterfacesForm
{
    public partial class Form1 : Form
    {
        IVehiculo vehiculoActual;
        ITransporte transporteActual;

        public Form1()
        {
            InitializeComponent();
            cmbTipoVehiculo.Items.AddRange(new object[] { "Carro", "Camión" });
            cmbTipoVehiculo.SelectedIndex = 0;
        }

        private void btnArrancar_Click(object sender, EventArgs e)
        {
            SeleccionarVehiculo();
            vehiculoActual.Arrancar();
        }

        private void SeleccionarVehiculo()
        {
            throw new NotImplementedException();
        }
    }
}