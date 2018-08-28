using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Configuration;

namespace Listas
{
    class Fornecedores
    {
        public SqlConnection objConexao;
        public SqlCommand objCommand;
        public string strStringConexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        public string strSelect = "SELECT COD_PRODUTO, DESCRICAO, PRECO_CUSTO, PRECO_VENDA FROM PRODUTOS where COD_PRODUTO = '1010A'";
        public string strSelectPorID = "SELECT COD_PRODUTO, DESCRICAO, PRECO_CUSTO, PRECO_VENDA FROM PRODUTOS WHERE ID_PRODUTO = @ProductID";
        public string sConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog= Pedidos;Integrated Security=True";

        public class Fornecedor
        {
            public int id { get; set; }
            public string nome { get; set; }
            public string cidade { get; set; }
            public string estado { get; set; }
        }


        public List<Fornecedor> GetFornecedor()
        {

            SqlConnection Conn = new SqlConnection(sConexao);
            string strSQL = "SELECT COD_FORNECEDOR, NOME, CIDADE, ESTADO FROM FORNECEDORES";

            List<Fornecedor> _Fornecedor = new List<Fornecedor>();

            try
            {

                Conn.Open();
                SqlCommand cmd = new SqlCommand(strSQL, Conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    _Fornecedor.Add(new Fornecedor()

                    {
                        id = Convert.ToInt32(dr["COD_FORNECEDOR"]),

                        nome = dr["NOME"].ToString(),

                        cidade = dr["CIDADE"].ToString(),

                        estado = dr["ESTADO"].ToString()

                    });
                }

                dr.Close();
                return _Fornecedor;

            }

            catch (Exception ex)

            { throw ex; }

            finally { Conn.Close(); }

            //http://www.linhadecodigo.com.br/artigo/2767/array-arraylist-e-listt-o-que-devemos-saber.aspx
        }

    }
}
