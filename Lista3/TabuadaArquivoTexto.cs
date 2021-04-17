using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TabuadaArquivoTexto
{
    public class Program
    {
        static public void TabuadaArquivoTexto(int a)
        {

            // Escrevendo no arquivo de texto o arquivo de texto
            string texto ="";
            try {
                for(int i=0; i<=10; i++){
                    texto += i+" x "+a+" = "+a*i+"\n";
                }
                using (StreamWriter arquivo = new StreamWriter("./arquivos/teste.txt")){
                    arquivo.Flush();
                    arquivo.WriteLine(texto);
                }
            }catch(Exception e){
                Console.WriteLine($"Erro{e}");
            }


            // Lendo o arquivo de texto
            string line = "";
            using (StreamReader sr = new StreamReader("./arquivos/teste.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
