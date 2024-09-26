using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionProductos
{
    // Clase abstracta que define el comportamiento general de un producto
    internal abstract class Producto
    {
        public string Nombre { get; set; }
        public decimal PrecioBase { get; set; }
        public Producto(string nombre, decimal precioBase)
        {
            Nombre = nombre;
            PrecioBase = precioBase;
        }
        // Método abastracto que obliga a las clases derivadas a 
        // implementar su propio cálculo de precio final
        public abstract decimal CalcularPrecioFinal();
    }
    // Producto general, sin sobrecargos adicionales
    internal class ProductoGeneral : Producto
    {
        public ProductoGeneral(string nombre, decimal precioBase) 
            : base(nombre, precioBase)
        {
        }

        public override decimal CalcularPrecioFinal()
        {
            return PrecioBase; // No hay recargo
        }
    }
    // Producto electrónico que tiene un recargo por impuestos electrónicos
    internal class ProductoElectronico : Producto
    {
        public ProductoElectronico(string nombre, decimal precioBase) 
            : base(nombre, precioBase)
        {
        }

        public override decimal CalcularPrecioFinal()
        {
            // Aplicamos un recargo del 15% por impuestos electrónicos
            return PrecioBase * 1.15m;
        }
    }
    // Producto perecedero con descuento especial por caducidad
    internal class ProductoPerecedero : Producto
    {
        public DateTime FechaCaducidad { get; set; }
        public ProductoPerecedero(string nombre, decimal precioBase,
            DateTime fechaCaducidad) 
            : base(nombre, precioBase)
        {
            FechaCaducidad = fechaCaducidad;
        }

        public override decimal CalcularPrecioFinal()
        {
            // Si el producto está a punto de caducar,
            // aplicamos un descuento del 20%
            if(FechaCaducidad < DateTime.Now.AddDays(7))
            {
                return PrecioBase * 0.8m;
            }
            return PrecioBase;
        }
    }
}
