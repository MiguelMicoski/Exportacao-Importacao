using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void TesteTeste()
        {
            var EnderecoDoArquivo = "contas.txt";

            using (var fluxodoArquivo = new FileStream(EnderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxodoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();

                    Console.WriteLine(linha);
                }


            }
            
                
                
            
        }
        

    }
}
