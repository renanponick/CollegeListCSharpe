using System;

namespace CalcularVolume
{
    public class Program
        {
            static public String CalcularVolume(double pri, double seg, double tre){
                double resultado;
                try{
                    resultado = ((pri*seg)*tre);
                    return ($"Resultado: {resultado}");
                }catch(Exception e){
                    return ($"Erro{e}");
                }
                
            }
        }
}