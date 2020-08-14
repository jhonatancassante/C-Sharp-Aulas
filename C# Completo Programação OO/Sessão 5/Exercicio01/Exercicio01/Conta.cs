using System;

namespace Exercicio01
{
    class Conta
    {
        //Atributos privados
        private double _taxa = 5.0;

        //Propriedades autoimplementadas
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        //Construtores
        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }
        public Conta(int numero, string nome, double saldo) : this(numero, nome)
        {
            Saldo = saldo;
        }

        //Propriedades customizadas

        //Outros métodos de classe
        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }
        public void Saque(double saldo)
        {
            Saldo -= (saldo + _taxa);
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2");
        }
    }
}
