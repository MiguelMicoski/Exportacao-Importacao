using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void EscritaBinaria()
        {
            using(var fs = new FileStream ("contaCorrente.txt", FileMode.Create))
            using(var escritor = new BinaryWriter(fs))
            {
                escritor.Write(456);
                escritor.Write(5636);
                escritor.Write(2555.55);
                escritor.Write("miguel");
            }

            
        }

        static void LeituraBinaria()
        {
            using(var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using(var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var nomeTitular = leitor.ReadString();

                Console.WriteLine($"{nomeTitular}: ag: {agencia}, conta: {numeroConta}, saldo: {saldo}");

            }
        }
    }
}
