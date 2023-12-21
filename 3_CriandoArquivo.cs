using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //input e output

namespace ByteBankImportacaoExportacao

{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456, 43256, 4785.31, Miguel Micoski";

                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";


            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
            using (var escritor = new StreamWriter(fluxoDeArquivo)) 
            {
                escritor.Write("325325,2145, 2424.22, Rute Micoski");


            }

            
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxodoArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxodoArquivo))
            {
                for (int i = 0; i < 10000; i++)
                {
                    escritor.WriteLine($"Linha {i}");

                    escritor.Flush();

                    Console.WriteLine($"Linha {i} foi escrita no arquivo, tecle enter p adicionar mais uma!");

                    Console.ReadLine();
                }
            }
        }
    }
}