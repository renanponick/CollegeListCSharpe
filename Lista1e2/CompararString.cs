using System;

namespace CompararString
{
    public class Program
        {
            static public String CompararString(String a, String b){
                try{
                    if(String.Compare(a,b)==0){
                       return ($"Resultado: {a}, {b} é igual");
                    }else{
                       return ($"Resultado: {a}, {b} não é igual");
                    }
                }catch(Exception e){
                    return ($"Erro{e}");
                }
                
            }
        }
}