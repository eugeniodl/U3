namespace InterfacesForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboTipoVehiculo.Items.AddRange(new string[] { "Carro", "Camión" });
        }
    }
}