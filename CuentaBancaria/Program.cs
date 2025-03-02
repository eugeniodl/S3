﻿CuentaBancaria cuenta = new CuentaBancaria("1234567890", 5000m);
cuenta.Depositar(1500m);
cuenta.Retirar(3000m);
Console.WriteLine($"Saldo final: {cuenta.ConsultarSaldo():C}");

public class CuentaBancaria
{
    private string numeroCuenta;
    private decimal saldo;

    // Constructor que inicializa la cuenta con un número y un saldo inicial
    public CuentaBancaria(string numeroCuenta, decimal saldoInicial)
    {
        this.numeroCuenta = numeroCuenta;
        saldo = saldoInicial;
    }

    // Método para depositar dinero en la cuenta
    public void Depositar(decimal cantidad)
    {
        if(cantidad > 0)
        {
            saldo += cantidad;
            Console.WriteLine($"Se han depositado {cantidad:C} en la cuenta " +
                $"{numeroCuenta}. Nuevo saldo: {saldo:C}");
        }
    }

    // Método para retirar dinero de la cuenta
    public void Retirar(decimal cantidad)
    {
        if(cantidad > 0 && cantidad <= saldo)
        {
            saldo -= cantidad;
            Console.WriteLine($"Se han retirado {cantidad:C} en la cuenta " +
                $"{numeroCuenta}. Nuevo saldo: {saldo:C}");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes o cantidad inválida");
        }
    }

    // Método para consultar el saldo
    public decimal ConsultarSaldo()
    {
        return saldo;
    }
}
