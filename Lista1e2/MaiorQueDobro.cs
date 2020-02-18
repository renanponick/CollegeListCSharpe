using System;

namespace MaiorQueDobro
{
    public class Program
        {
            static public String MaiorQueDobro(double pri, double seg){
                double resultado;
                try{
                    resultado = seg*2;
                    if (resultado > pri) {
                        return ($"Resultado: {resultado}, é o dobro");
                    }
                    else{
                        return ($"Resultado: {resultado}, não é o dobro");
                    }
                }catch(Exception e){
                    return ($"Erro{e}");
                }
                
            }
        }
}