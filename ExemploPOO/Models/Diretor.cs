using System;
namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
         public override void Apresentar(){
            Console.WriteLine($"Olá, meu nome é: {Nome} e tenho {Idade} anos, Sou Professor e meu salário é: {salario}");
        }
    }
}