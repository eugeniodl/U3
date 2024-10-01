using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesForm
{
    internal class Camion : Vehiculo, ITransporte
    {
        public new string Nombre { get; set; } = "Camión";

        public override void Arrancar()
        {
            base.Arrancar();
            MessageBox.Show($"{Nombre} está transportando mercancía.");
        }
        public void Cargar()
        {
            MessageBox.Show($"{Nombre} está siendo cargado.");
        }

        public void Descargar()
        {
            MessageBox.Show($"{Nombre} ha descargado la mercancía.");
        }
    }
}
