using System;
using System.Collections.Generic;
using System.Text;

namespace POOBanco
{
    public class Conta
    {
        private string? numero;
        private double saldo;

        private List<Movimento> movimentos;


        public string getNumero() => this.numero;

        public void setNumero(string numero) => this.numero = numero;

        public double getSaldo() => this.saldo;

        public Conta(string numero)
        {
            this.numero = numero;
            this.saldo = 0;
            movimentos = new List<Movimento>();
        }

        public void Depositar(double valor)
        {
           this.saldo += valor;

            Movimento movimento = new Movimento();
            movimento.setTipo("Depósito");
            movimento.setValor(valor);
            movimentos.Add(movimento);
                Console.WriteLine("Depósito de " + valor + "Kz realizado com sucesso!");
        }
        public void Levantar(double valor)
        {
            if (valor <= getSaldo())
            {
                this.saldo -= valor;

                Movimento movimento = new Movimento();

                movimento.setTipo("Levantamento");
                movimento.setValor(valor);
                movimentos.Add(movimento);

                Console.WriteLine("Levantamento de " + valor + "Kz realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
        public void MostrarMovimentos(){
            Console.WriteLine($"Movimentos da conta: {getNumero()}");
            foreach (var movimento in movimentos)
            {
                Console.WriteLine(movimento.Apresentar());
            }
        }
    }
}
