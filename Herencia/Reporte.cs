class Reporte
{
    public virtual void GenerarReporte()
    {
        Console.WriteLine("Generando reporte genérico...");
    }
}

class ReporteFinanciero : Reporte
{
    public sealed override void GenerarReporte()
    {
        Console.WriteLine("Genera reporte financiero detallado...");
    }
}
// Esta clase no puede sobrescribir GenerarReporte debido a 'sealed'
class ReporteAnual : ReporteFinanciero
{
    // Intentar sobrescribir aquí causará error
/*    public override void GenerarReporte()
    {

    }*/
}