using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class ContaCorrente
    {
       public int Saldo { get; set; }
       public int Numero { get; set; }
       public int Limite { get; set; }
       public bool EhEspecial { get; set; }
        



        public ContaCorrente(int saldo, int numero, int limite, bool ehEspecial)
        {
            Saldo = saldo;
            Numero = numero;
            Limite = limite;
            EhEspecial = ehEspecial;
            
        }
        public void Sacar(int valor)
        {
            Saldo = Saldo - valor;
            Console.WriteLine("Saque Realizado!");

        }
        public void Depositar(int valor)
        {
            Saldo = Saldo + valor;

            Console.WriteLine("Depósito realizado!");

        }
        public void TransferirPara(ContaCorrente destino, decimal valor)
        {

        }
        public void ExibirExtrato()
        {

        }
    }
}
