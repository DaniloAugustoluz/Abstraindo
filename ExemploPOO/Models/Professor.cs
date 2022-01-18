namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {

        public double salario { get; set; }   

        public override  void Apresentar(){
            Console.WriteLine($"Olá, meu nome é: {Nome} e tenho {Idade} anos, Sou Professor e meu salário é: {salario}");

        }
    }
}