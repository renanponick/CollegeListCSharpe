using System;
using MediaTresNumeros;
using CalcularArea;
using CalcularVolume;
using MaiorQueDobro;
using VelocidadeMedia;
using PercentualImpostoPago;
using SalarioInformaImposto;
using VerificaPrimo;

namespace ListaUm
{
    public class Program
    {
        static public void ListaUm(){
            int opr = 0, a=0,b=0,c=0;
            double f=0,g=0;
            String d="", e="";
            do{
                Console.WriteLine("Digite o programa");
                Console.WriteLine(
                    "1-MediaTresNumeros\n"+
                    "2-CalcularArea\n"+
                    "3-CalcularVolume\n"+
                    "4-MaiorQueDobro\n"+
                    "5-VelocidadeMedia\n"+
                    "6-PercentualImpostoPago\n"+
                    "7-ParOuImpar\n"+
                    "8-CompararString\n"+
                    "9-SalarioInformaImposto\n"+
                    "10-VerificaPrimo\n"+
                    "11-Sair\n"
                );
                opr = Convert.ToInt32(Console.ReadLine());
                switch (opr)
                {
                    case 1:{
                        Console.WriteLine("Número 1");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Número 2");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Número 3");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("MediaTresNumeros");
                        Console.WriteLine( MediaTresNumeros.Program.MediaTresNumeros(a,b,c) );
                        break;
                    }
                    case 2:{
                        Console.WriteLine("Número 1");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Número 2");
                        b = Convert.ToInt32(Console.ReadLine());
                         Console.WriteLine("CalcularArea");
                        Console.WriteLine( CalcularArea.Program.CalcularArea(a,b));
                        break;
                    }
                    case 3:{
                        Console.WriteLine("Número 1");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Número 2");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Número 3");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("CalcularVolume");
                        Console.WriteLine( CalcularVolume.Program.CalcularVolume(a,b,c));
                        break;
                    }
                    case 4:{
                        Console.WriteLine("Número 1");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Número 2");
                        b = Convert.ToInt32(Console.ReadLine());
                         Console.WriteLine("MaiorQueDobro");
                        Console.WriteLine( MaiorQueDobro.Program.MaiorQueDobro(a,b));
                        break;
                    }
                    case 5:{
                        Console.WriteLine("Número 1");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Número 2");
                        b = Convert.ToInt32(Console.ReadLine());
                         Console.WriteLine("VelocidadeMedia");
                        Console.WriteLine( VelocidadeMedia.Program.VelocidadeMedia(a,b));
                        break;
                    }
                    case 6:{
                        
                        Console.WriteLine("Número 1");
                        f = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Número 2");
                        g = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("PercentualImpostoPago");
                        Console.WriteLine( PercentualImpostoPago.Program.PercentualImpostoPago(f,g) );
                        break;
                    }
                    case 7:{
                        Console.WriteLine("Número:");
                        f = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("ParOuImpar");
                        Console.WriteLine( ParOuImpar.Program.ParOuImpar(f) );
                        break;
                    }
                    case 8:{
                        Console.WriteLine("string 1");
                        d = Console.ReadLine();
                        Console.WriteLine("string 2");
                        e = Console.ReadLine();
                        Console.WriteLine("CompararString");
                        Console.WriteLine( CompararString.Program.CompararString(d,e) );
                        break;
                    }
                    case 9:{
                        Console.WriteLine("Número:");
                        f = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("SalarioInformaImposto");
                        Console.WriteLine( SalarioInformaImposto.Program.SalarioInformaImposto(f) );
                        break;
                    }
                    case 10:{
                        Console.WriteLine("Número:");
                        f = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("VerificaPrimo");
                        Console.WriteLine( VerificaPrimo.Program.VerificaPrimo(f) );
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
            }while(opr!=11);
        }
    }
}
