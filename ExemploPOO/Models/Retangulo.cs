using System;
namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double Comprimento { get; set; }
        private double Largura { get; set; }
        private bool valido { get; set; }

        public void definirMedidas(double Comprimento, double Largura){
            if(Comprimento > 0 && Largura > 0){
                this.Comprimento = Comprimento;
                this.Largura = Largura;
                valido = true;
            }
            else{
                System.Console.WriteLine("Informe um valor valido.");
            }        
        }

        public double retornarArea(){
            if(valido){
                return Comprimento * Largura;
            }
            else{
                System.Console.WriteLine("Preencha um valor válido.");
                return 0;
            }            
        }
    }
}