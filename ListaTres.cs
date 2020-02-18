using System;
using TabuadaArquivoTexto;
using LerImprimirArquivo;
using Exponenciacao;
using NomeCincoPessoasAleatorios;
using RaioAreaCirculo;
using AnalisarString;
using DezPrimeirosDigitosLinha;

namespace ListaTres
{
    public class Program
    {
        static public void ListaTres()
        {
            int op =0,a=0;
            do{
                Console.WriteLine("Digite a Lista");
                Console.WriteLine(
                    "1-Tabuada\n"+
                    "2-LerImprimir\n"+
                    "3-Lista 3\n"+
                    "3-Lista 3\n"+
                    "3-Lista 3\n"
                );
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:{
                        Console.WriteLine("Número:");
                        a = Convert.ToInt32(Console.ReadLine());
                        TabuadaArquivoTexto.Program.TabuadaArquivoTexto(a);
                        break;
                    }
                    case 2:{
                        LerImprimirArquivo.Program.LerImprimirArquivo();
                        break;
                    }
                    case 3:{
                        break;
                    }
                    case 11:{
                        break;
                    }
                    default:{
                        Console.WriteLine("numero inválido");
                        break;
                    }
                }
            }while(op!=11);
        }
    }
}
