
using System;
namespace Exercicos_de_Pogramação__Seção_5_
{
    public class Dados
    {
        private string _nome;
        public double Conta { get; private set; }
        private double Saldo;

     

        public Dados(string nome, double conta)
        {
            _nome = nome;
            Conta = conta;
            Saldo = 0;

        }
        public string GetNome()
        {
            return _nome;
        }
      public void SetNome(string nome)
        {
            if (_nome != null && _nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public void Saque(double saque)
        {
            Saldo = Saldo - (saque + 5);
        }

        public void Dep(double deposito)
        {
            Saldo += deposito;
        }

        public override string ToString()
        {
            return
                "Usuario = " + _nome + "\n" +
                "N° da Conta = " + Conta + "\n" +
                "Saldo = " + Saldo + "\n";

        }

    }
}
