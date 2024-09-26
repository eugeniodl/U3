abstract class FiguraGeometrica
{
    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
    public void MostrarInformacion()
    {
        Console.WriteLine($"Área: {CalcularArea()}");
        Console.WriteLine($"Perímetro: {CalcularPerimetro()}");
    }
}

class Rectangulo : FiguraGeometrica
{
    private double largo;
    private double ancho;
    public Rectangulo(double largo, double ancho)
    {
        this.largo = largo;
        this.ancho = ancho;
    }
    public override double CalcularArea()
    {
        return largo * ancho;
    }

    public override double CalcularPerimetro()
    {
        return 2 * (largo * ancho);
    }
}

class Ciculo : FiguraGeometrica
{
    private double radio;

    public Ciculo(double radio)
    {
        this.radio = radio;
    }
    public override double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

