class CuentaBancaria
{
    protected decimal saldo;

    public CuentaBancaria(decimal saldoIncial)
    {
        saldo = saldoIncial;
    }

    public void Depositar(decimal monto)
    {
        saldo += monto;
        Console.WriteLine($"Depósito de {monto} realizado. " +
            $"Nuevo saldo: {saldo}.");
    }

    public void Retirar(decimal monto)
    {
        if(monto <= saldo)
        {
            saldo -= monto;
            Console.WriteLine($"Retiro de {monto} realizado. " +
                $"Nuevo saldo: {saldo}.");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes.");
        }
    }

    public decimal ObtenerSaldo()
    {
        return saldo;
    }
}

class CuentaAhorros : CuentaBancaria
{
    private decimal tasaInteres;
    public CuentaAhorros(decimal saldoIncial, decimal tasaInteres) 
        : base(saldoIncial)
    {
        this.tasaInteres = tasaInteres;
    }

    public void AplicarInteres()
    {
        decimal interes = saldo * tasaInteres;
        saldo += interes;
        Console.WriteLine($"Interés aplicado: {interes}. " +
            $"Nuevo saldo: {saldo}");
    }
}

class CuentaCorriente : CuentaBancaria
{
    private decimal limiteSobregiro;
    public CuentaCorriente(decimal saldoIncial, decimal limiteSobregiro) 
        : base(saldoIncial)
    {
        this.limiteSobregiro = limiteSobregiro;
    }

    public new void Retirar(decimal monto)
    {
        if( monto <= saldo + limiteSobregiro )
        {
            saldo -= monto;
            Console.WriteLine($"Retiro de {monto} realizado. " +
                $"Nuevo saldo: {saldo}.");
        }
        else
        {
            Console.WriteLine("Excede el límite de sobregiro.");
        }
    }
}