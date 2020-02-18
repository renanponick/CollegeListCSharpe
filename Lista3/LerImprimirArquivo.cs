using System;

namespace LerImprimirArquivo
{
    public class Program
    {
        static public void LerImprimirArquivo()
        {
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
