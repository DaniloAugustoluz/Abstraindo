using System.IO;
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
    }
}