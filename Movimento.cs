using System;
using System.Collections.Generic;
using System.Text;

namespace POOBanco
{
    public class Movimento
    {
        private string? tipo;
        private double valor;


        public string getTipo() => tipo;
        public void setTipo(string tipo) => this.tipo = tipo;
        public double getValor() => valor;
        public void setValor(double valor) => this.valor = valor;

        public string Apresentar()
        {
            return tipo + " - " + this.valor + "Kz";
        }
    }
}
