using System;
using System.IO;

namespace ProcuraArquivo
{
    class ProcuraArquivo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a pasta, a partir da qual será feita a pesquisa: ");
            string pasta = Console.ReadLine();
            Console.WriteLine("Entre com o nome do arquivo ou a máscara, para mais de um arquivo, exm: *.txt");
            string mascara = Console.ReadLine();

            var files = Directory.EnumerateFiles(pasta, mascara, SearchOption.AllDirectories);
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
        }
    }
}
