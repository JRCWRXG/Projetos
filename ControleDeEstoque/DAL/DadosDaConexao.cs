using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class DadosDaConexao
    {
        
       public static string StringDeConexao

       {
           get

           {

               //return "Data Source=JRCWRXG-PC\SQLEXPRESS;Initial Catalog=ControleDeEstoque;Integrated Security=True";
               return @"Data Source=.\SQLEXPRESS;Initial Catalog=Estoque;Integrated Security=True";

              

                  
           }
       }
    }
}
