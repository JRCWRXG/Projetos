using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WindowsFormsApplication1
{
   public class DAL
    {
           
       public List<Aluno> executaSQL2(string ComandoSQL)
       {
           ConexaoDB oConn = new ConexaoDB();

           if (oConn._connection.State == ConnectionState.Closed)
           {
               oConn._connection.Open();
                              
           }
                     
           List<Aluno> _alunos = new List<Aluno>();

           SqlCommand cmd = new SqlCommand(ComandoSQL, oConn._connection);

           cmd.CommandType = CommandType.Text;

           SqlDataReader dr = cmd.ExecuteReader();

           while (dr.Read())
           {

               _alunos.Add(new Aluno()

               {

                   Id = Convert.ToInt32(dr["Id"]),

                   Nome = dr["Nome"].ToString(),

                   Email = dr["Email"].ToString(),

                   Idade = dr["Idade"].ToString()

               });

           }

           dr.Close();

           return _alunos;
           
       }

    }
}
