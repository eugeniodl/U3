public class Caja : object
{
    private object[] elementos;
    private int indiceActual;

    public Caja(int tamanio)
    {
        elementos = new object[tamanio];
        indiceActual = 0;
    }

    public void AgregarElemento(object elemento)
    {
        if(indiceActual < elementos.Length)
        {
            elementos[indiceActual] = elemento;
            indiceActual++;
            Console.WriteLine($"Elemento agregado: " +
                $"{elemento}");
        }
        else
        {
            Console.WriteLine($"La caja está llena, " +
                $"no se puede agregar más elementos.");
        }
    }

    public void MostrarElementos()
    {
        for( int i = 0; i < indiceActual; i++ )
        {
            Console.WriteLine($"Elemento [{i}]: {elementos[i]}");
        }
    }
}

