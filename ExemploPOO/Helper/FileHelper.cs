using System.IO;
using System.Collections.Generic;
namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void listarDiretorios(string caminho){
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho){
            Console.WriteLine(retorno);
        
            }
        }
        

        public void listarArquivosDiretorios(string caminho){
            var retornoCaminho = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho){
                System.Console.WriteLine(retorno);
            }
        }

        public void criarDiretorio(string caminho){
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }


        public void apagarDiretorio(string caminho, bool apagarTudo){
            Directory.Delete(caminho, apagarTudo);
        }

        public void criarArquivoTexto(string caminho, string conteudo){
            
            if(!File.Exists(caminho)){
                File.WriteAllText(caminho, conteudo);
            }
            else {
                System.Console.WriteLine("Arquivo existente!");
            }

        }

        public void criarArquivoTextoStream(string caminho, List<string> conteudo){
           using(var stream =  File.CreateText(caminho)){

                    foreach(var str in conteudo){
                    System.Console.WriteLine(str);
                }
           }
                     
        }

        public void adicionarTexto(string caminho, string conteudo){
            File.AppendAllText(caminho, conteudo);
        }

        public void adicionarTextoStream(string caminho, List<string> conteudo){
           using(var stream =  File.AppendText(caminho)){

                    foreach(var str in conteudo){
                    System.Console.WriteLine(str);
                }
           }
                     
        }

        public void lerArquivo(string caminho){
            var conteudo = File.ReadAllLines(caminho);
            
            foreach(var cont in conteudo){
                System.Console.WriteLine(cont);
            }
        }

        public void lerArquivoStream(string caminho){
            var linha = string.Empty;

            using(var stream = File.OpenText(caminho)){
               
                while ((linha = stream.ReadLine()) != null)
                {
                     System.Console.WriteLine(linha);
                }

            }
        }

        public void moverArquivo(string caminho, string novocaminho, bool sobrescrever){
            File.Move(caminho, novocaminho, sobrescrever);
        }

        public void copiarArquivo(string caminho, string novocaminho, bool sobrescrever){
            File.Copy(caminho, novocaminho, sobrescrever);
        }

        public void deletarArquivo(string caminho){
            File.Delete(caminho);
        }

    }
}