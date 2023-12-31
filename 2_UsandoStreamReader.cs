﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //input e output
using ByteBankImportacaoExportacao.Modelos;

namespace ByteBankImportacaoExportacao

{
    partial class Program
    {
        static void UsandoStremReader()
        {
            var enderecoDoArquivo = "contas.txt";
            
            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))

            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();

                    var contaCorrente = ConverterStringParaContaCorrente(linha);


                    var msg = $"{contaCorrente.Titular.Nome}: Conta número {contaCorrente.Numero}, ag.{contaCorrente.Agencia}, Saldo: {contaCorrente.Saldo}";

                    Console.WriteLine(msg);
                }


            }
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ','); 
            var nomeTitular = campos[3];

            var agenciaComoInt = int.Parse(agencia);

            var numeroComoInt = int.Parse(numero);

            var saldocomoDouble = double.Parse(saldo);

            var titular = new Clientes();

            titular.Nome = nomeTitular;

            
            var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);

            resultado.Depositar(saldocomoDouble);

            resultado.Titular = titular;

            return resultado;

        }

    }

}