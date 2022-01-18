using System;
namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo { get; set; }

       public abstract void Creditar(double valor);

        public void exibirSaldo(){

            Console.WriteLine($"seu saldo é: {saldo}");

        }     
    }
}