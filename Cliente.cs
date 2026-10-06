using System;
using System.Collections.Generic;
using System.Text;

namespace POOBanco
{
    public class Cliente
    {
        private string? nome;
        private string? identificacao;
        private List<Conta> contas;

        public string getNome() => this.nome;
        public void setNome(string nome) => this.nome = nome;
        public string getIdentificacao() => this.identificacao;
        public void setIdentificacao(string identificacao) => this.identificacao = identificacao;

        public Cliente(string nome, string identificacao)
        {
            this.nome = nome;
            this.identificacao = identificacao;
            contas = new List<Conta>();
        }
        public void AddConta(Conta conta)
        {
            contas.Add(conta);
            Console.WriteLine($"Conta {conta.getNumero()} adicionada com sucesso ao cliente {getNome()}!");
        }
        public void MostrarContas()
        {
            Console.WriteLine($"Contas do cliente: {getNome()}");
            foreach (Conta conta in contas)
            {
                Console.WriteLine($"Número da conta: {conta.getNumero()}, Saldo: {conta.getSaldo()}Kz");
            }
        }
    }
}
