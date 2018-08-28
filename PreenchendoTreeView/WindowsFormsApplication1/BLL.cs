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
  public class BLL
    {

      public List<Aluno> GetAlunosOB()
      {
          DAL objDados = new DAL();

          StringBuilder strSql = new StringBuilder();
          strSql.AppendLine("Select id,nome,email,idade ");
          strSql.AppendLine("From CLIENTE ");
          strSql.AppendLine("Order By id");
          
          List<Aluno> _alunos = new List<Aluno>();

          try
          {

              _alunos = objDados.executaSQL2(strSql.ToString());


          }

          catch (Exception ex)
          {

              throw ex;

          }

          finally
          {

            

          }

          return _alunos;

      }


    }
}
