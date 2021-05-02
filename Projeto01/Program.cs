using System; //importa bibliotecas
using Projeto01.Entities;   // importando o conteúdo da pasta Entities
using System.IO; // Biblioteca onde tem a classe StreamWriter essa classe,cria e escreve/grava o conteúdo em um arquivo(pasta que eu vou criar tipo temp nome da pasta ex.cliente.txt
                    //quando eu usar o StreamWriter eu uso sempre o try  e cacth( Exception e)

namespace Projeto01 //define a localização da classe no projeto
{
    class Program // definição da classe
    {
        static void Main(string[] args) // método ou função que executa o projeto
        {
            Console.WriteLine("\n *** CADASTRO DE CLIENTES ***\n "); // de console aplication, vai escrever no DOS
            Console.WriteLine("Preencha os dados para cadastrar um cliente:");

            var cliente = new Cliente(); // essa variavel está recebendo o espaço de memória da classe cliente no new Cliente

            cliente.Id = Guid.NewGuid();

            Console.WriteLine("\nInforme o nome do Cliente:"); // ConsoleWriteLine escreve no Dos (cw tab tab)
            cliente.Nome = Console.ReadLine(); // ConsoleReadLine lê o que foi escrito no WriteLine

            Console.WriteLine("\nInforme o email do Cliente:");
            cliente.Email = Console.ReadLine();

            Console.WriteLine("\nInforme o cpf do Cliente:");
            cliente.Cpf = Console.ReadLine();

            Console.WriteLine("\nDados do Cliente");

            Console.WriteLine("Id......: " + cliente.Id);
            Console.WriteLine("Nome....: " + cliente.Nome);
            Console.WriteLine("Email...: " + cliente.Email);
            Console.WriteLine("Cpf.....: " + cliente.Cpf);

            try
            {
                var streamWriter = new StreamWriter("c:\\clientes\\" + cliente.Id + ".txt");
                //stream Writer.WriteLine vai escrever dentro do arquivo
                streamWriter.WriteLine("Id......: " + cliente.Id);    
                streamWriter.WriteLine("Nome....: " + cliente.Nome);
                streamWriter.WriteLine("Email...: " + cliente.Email);
                streamWriter.WriteLine("Cpf.....: " + cliente.Cpf);


                streamWriter.Close(); // Eu tenho sempre que fechar o arquivo se não ele não vai gravar no arquivo!!!

                Console.WriteLine("\nCliente cadastrado com sucesso!");

            }
            catch (Exception e)
            {
                Console.WriteLine("\nOcorreu um erro, por favor tente novamente.");
                Console.WriteLine(e.Message);
            }







        }
    }
}
