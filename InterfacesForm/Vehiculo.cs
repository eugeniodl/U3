using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesForm
{
    internal class Vehiculo : IVehiculo
    {
        public string Nombre { get; set; } = "Vehículo genérico";
        public virtual void Arrancar()
        {
            MessageBox.Show($"{Nombre} ha arrancado");
        }

        public virtual void Detener()
        {
            MessageBox.Show($"{Nombre} se ha detenido.");
        }
    }
}
