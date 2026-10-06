using POOBanco;
using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Cliente cliente = new Cliente("João Silva", "123456789");
        Conta conta1 = new Conta("001");
        Console.WriteLine("--------------------------------");
        cliente.AddConta(conta1);
        Console.WriteLine("--------------------------------");
        cliente.MostrarContas();
        Console.WriteLine("--------------------------------");
        conta1.Depositar(1000);
        Console.WriteLine("================================");

        Cliente cliente2 = new Cliente("Maria Santos", "987654321");
        Conta conta2 = new Conta("002");
        Console.WriteLine("--------------------------------");
        cliente2.AddConta(conta2);
        Console.WriteLine("--------------------------------");
        cliente2.MostrarContas();
        Console.WriteLine("--------------------------------");
        conta2.Depositar(500);
        Console.WriteLine("================================");

        Cliente cliente3 = new Cliente("Carlos Oliveira", "456789123");
        Conta conta3 = new Conta("003");
        Console.WriteLine("--------------------------------");
        cliente3.AddConta(conta3);
        Console.WriteLine("--------------------------------");
        cliente3.MostrarContas();
        Console.WriteLine("--------------------------------");
        conta3.Depositar(1000);
        Console.WriteLine("================================");
    }
}
