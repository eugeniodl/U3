using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesForm
{
    internal class Carro : Vehiculo, ITransporte
    {
        public new string Nombre { get; set; } = "Carro"; // Oculta el campo Nombre de la clase base

        public override void Arrancar()
        {
            base.Arrancar(); // Llamada al método de la clase base
            MessageBox.Show($"{Nombre} está listo para rodar.");
        }

        public override void Detener()
        {
            MessageBox.Show($"{Nombre} se ha estacionado.");
        }

        public void Cargar()
        {
            MessageBox.Show($"{Nombre} está cargando pasajeros.");
        }

        public void Descargar()
        {
            MessageBox.Show($"{Nombre} ha descargado a los pasajeros.");
        }
    }
}
