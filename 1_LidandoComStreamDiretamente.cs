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
        static void LidandoComFileStreamDiretamente()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))

            {


                var buffer = new byte[1024];//1kb

                var numerosDeBytesLidos = -1;



                while (numerosDeBytesLidos != 0)
                {
                    numerosDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer, numerosDeBytesLidos);
                }

                fluxoDoArquivo.Close();
            }
        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {

            var utf8 = Encoding.Default;

            var texto = utf8.GetString(buffer, 0, bytesLidos);

            Console.Write(texto);


            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}

        }
    }
}