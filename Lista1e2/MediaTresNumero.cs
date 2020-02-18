using System;

namespace MediaTresNumeros
{
    public class Program
        {
            static public String MediaTresNumeros(int pri, int seg, int ter){
                double resultado;
                try{
                    resultado = (pri+seg+ter)/3;
                    return ($"Resultado: {resultado}");
                }catch(Exception e){
                    return ($"Erro{e}");
                }
                
            }
        }
}