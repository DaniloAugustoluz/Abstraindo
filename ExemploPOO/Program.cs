using System.IO;
using System;
using ExemploPOO.Models;
using System;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;
using System.Collections.Generic;

namespace ExemploPOO{

    class Program{
        static void Main(string[] args){
        
      var caminho = @"C:\Users\danil\Documents\ManipulandoArquivosCSharp";
      var pathCombine = Path.Combine(caminho, "Teste1");
      var caminhoArquivo = Path.Combine(caminho, "TextoStream.txt");
      var caminhoArquivoTeste = Path.Combine(caminho, "TextoStream.txt");
      var caminhoArquivoCopy = Path.Combine(caminho, "TextoStream-bkp.txt");
      var novoCaminho = Path.Combine(caminho, "PastaTeste1", "TextoStream.txt");
      
      var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
      var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};

      FileHelper helper = new FileHelper();
      helper.deletarArquivo(caminhoArquivoCopy);
      
      // helper.criarArquivoTextoStream(caminhoArquivo, listaString);  
      // helper.adicionarTextoStream(caminhoArquivo, listaStringContinuacao);
        
        //helper.criarArquivoTexto(caminhoArquivo, "Criando arquivo de texto");
      
      
       //helper.apagarDiretorio(pathCombine, true);
       //helper.criarDiretorio(pathCombine);
       //helper.listarArquivosDiretorios(caminho);
       
        // ICalculadora calc = new Calculadora();
        // Console.WriteLine(calc.somar(10,15));
        // Console.WriteLine(calc.subtrair(20,15));
        // Console.WriteLine(calc.multiplicar(3,15));
        // Console.WriteLine(calc.dividir(50,15));
        
        
        // Corrente contaCorrente = new Corrente();
        // contaCorrente.Creditar(100);

        // contaCorrente.exibirSaldo();
        
        
        
        
        
        //  Calculadora calc = new Calculadora();
        //  Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10));
        //  Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10,10));
         
         
         
          // Aluno p1 = new Aluno();
          // p1.Nome = "Danilo Augusto";
          // p1.Idade = 26;
          // p1.Nota = 9.5;
          // p1.Apresentar();


          // Professor prof = new Professor();
          // prof.Nome = "Danilo Augusto";
          // prof.Idade = 26;
          // prof.salario = 15300;
          // prof.Apresentar();


        //Valores Validos
        // Retangulo r = new Retangulo();
        // r.definirMedidas(30,30);
        // System.Console.WriteLine($"o tamanho da area é: {r.retornarArea()}");

        //Valores Invalidos
        // Retangulo r2 = new Retangulo();
        // r2.definirMedidas(-2,0);
        // System.Console.WriteLine($"o tamanho da area é: {r2.retornarArea()}");
        
        
        // Pessoa p1 = new Pessoa();
        // p1.Nome = "Danilo Augusto";
        // p1.Idade = 26;
        // p1.Apresentar();

      }

    }
    
}
