using System;

namespace CalcularArea
{
    public class Program
        {
            static public String CalcularArea(double pri, double seg){
                double resultado;
                try{
                    resultado = (pri*seg);
                    return ($"Resultado: {resultado}");
                }catch(Exception e){
                    return ($"Erro{e}");
                }
                
            }
        }
}