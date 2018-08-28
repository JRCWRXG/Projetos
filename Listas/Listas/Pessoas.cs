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
    public static class MyExtensions
    {

        public static Object DefaultDbNull(this Object value, object defaultValue)
        {
            if (value == Convert.DBNull)
               
                return defaultValue;
            return value;
        }

    }

    //public enum EstadoCivil
    //economiza memoria utilizar short 16bits, int 32bits, byte 8 bits
    public enum EstadoCivil : short
    {
        Solteiro = 0,
        casado = 1,
        Viuvo = 2

    }

    public enum Sexo
    {
        Masculino,
        Feminino
    }


    class Pessoas
    {


        public SqlConnection objConexao;
        public SqlCommand objCommand;
        public string strStringConexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        public string strSelect = "SELECT COD_PRODUTO, DESCRICAO, PRECO_CUSTO, PRECO_VENDA FROM PRODUTOS where COD_PRODUTO = '1010A'";
        public string strSelectPorID = "SELECT COD_PRODUTO, DESCRICAO, PRECO_CUSTO, PRECO_VENDA FROM PRODUTOS WHERE ID_PRODUTO = @ProductID";
        public string sConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog= Pedidos;Integrated Security=True";




        public EstadoCivil EstadoCivil { get; set; }
        public Sexo Sexo { get; set; }

        public void Validate()
        {
            string strMsg = "";
            switch (EstadoCivil)
            {
                case EstadoCivil.Solteiro:
                    if (Sexo == Sexo.Masculino)
                        strMsg = "Homen";
                    else
                    {
                        strMsg = "Mulher";
                    }

                    break;
                case EstadoCivil.casado:
                    break;
                case EstadoCivil.Viuvo:
                    break;
                default:
                    break;
                //https://www.youtube.com/watch?v=50UNtNp0KeY


            }
        }






        public ArrayList SelecionaCategorias()
        {

            ArrayList lista = new ArrayList();


            try
            {

                SqlConnection Conn = new SqlConnection(sConexao);
                Conn.Open();
                // SqlCommand Comm = new SqlCommand("SELECT COD_FORNECEDOR, NOME, FISICA_JURIDICA FROM FORNECEDORES", Conn);
                SqlCommand Comm = new SqlCommand("SELECT NOME FROM FORNECEDORES", Conn);
                SqlDataReader Reader = Comm.ExecuteReader();
                while (Reader.Read())
                {
                  //  lista.Add(Reader.GetValue(0).ToString());
                 //   lista.Add(Reader.GetString(0));
                     lista.Add(Reader.GetValue(0).ToString());
                 
                }

                Conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally { }

            return lista;
        }



        public List<string> Merda()
        {


            List<string> items = new List<string>();


            try
            {

                SqlConnection Conn = new SqlConnection(sConexao);

                string qry = "SELECT NOME FROM FORNECEDORES";
                var cmd = new SqlCommand(qry, Conn);
                Conn.Open();

                using (SqlDataReader objReader = cmd.ExecuteReader())

                    if (objReader.HasRows)
                    {
                        while (objReader.Read())
                        {
                            //I would also check for DB.Null here before reading the value.
                            string item = objReader.GetString(objReader.GetOrdinal("NOME"));
                            items.Add(item);
                        }
                    }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {

            }
            return items;
        }



        public class Fornecedor
        {

            public int Id { get; set; }
            public string Nome { get; set; }
            public string cidade { get; set; }
            public string Estado { get; set; }

        }



        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public List<Fornecedor> GetFoncedorOB()
        {

           
            SqlConnection Conn = new SqlConnection(sConexao);

            string consulta = "SELECT COD_FORNECEDOR, NOME, CIDADE, ESTADO FROM FORNECEDORES";

            List<Fornecedor> _fornecedor = new List<Fornecedor>();

            try
            {

                Conn.Open();

                SqlCommand cmd = new SqlCommand(consulta, Conn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    _fornecedor.Add(new Fornecedor()

                    {

                        Id = Convert.ToInt32(dr["COD_FORNECEDOR"]),

                        Nome = dr["NOME"].ToString(),

                        cidade = dr["CIDADE"].ToString(),

                        Estado = dr["ESTADO"].ToString()

                    });

                }

                dr.Close();

                return _fornecedor;

            }

            catch (Exception ex)
            {

                throw ex;

            }

            finally
            {

                Conn.Close();

            }

        }



        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



        

        public class ModeloProdutos
        {
         //   public Int32 ProductID { get; set; }
            public String ProductID { get; set; }
            public String ProductName { get; set; }
            public Decimal UnitPrice { get; set; }
            public Decimal UnitsInStock { get; set; }
        }


        public List<ModeloProdutos> ConsultarProdutos()
        {
            var lstRetorno = new List<ModeloProdutos>();
            using (objConexao = new SqlConnection(strStringConexao))
            {
                using (objCommand = new SqlCommand(strSelect, objConexao))
                {
                    try
                    {
                        objConexao.Open();
                        var objDataReader = objCommand.ExecuteReader();
                        if (objDataReader.HasRows)
                            lstRetorno = PreencheValores(objDataReader);
                    }

                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                    finally
                    {
                        objConexao.Close();
                    }
                }
            } return lstRetorno;
        }




        public List<ModeloProdutos> PreencheValores(SqlDataReader reader)
        {
            var lista = new List<ModeloProdutos>();

            while (reader.Read())
            {
                var modeloProdutos = new ModeloProdutos();




               // modeloProdutos.ProductID = Convert.ToInt32(reader["COD_PRODUTO"].ToString());
                modeloProdutos.ProductID = reader["COD_PRODUTO"].ToString();
                modeloProdutos.ProductName = reader["DESCRICAO"].ToString();


                if (reader["PRECO_CUSTO"] != DBNull.Value)
                {
                    modeloProdutos.UnitPrice = Convert.ToDecimal(reader["PRECO_CUSTO"].ToString());
                }
                else
                {
                    modeloProdutos.UnitPrice = 0;
                }




           /////     modeloProdutos.UnitsInStock = Convert.ToDecimal(reader["PRECO_VENDA"].DefaultDbNull(string.Empty));
                //http://csharpbrasil.com.br/verificando-dbnull-de-forma-mais-elegante-com-extension-methods-e-generics/


                
                if (reader["PRECO_VENDA"] != DBNull.Value)
                {
                    modeloProdutos.UnitsInStock = Convert.ToDecimal(reader["PRECO_VENDA"].ToString());
                }
                else
                {
                    modeloProdutos.UnitsInStock = 0;
                }


              //  modeloProdutos.UnitPrice = Convert.ToDecimal(reader["PRECO_CUSTO"].ToString());
              //  modeloProdutos.UnitsInStock = Convert.ToDecimal(reader["PRECO_VENDA"].ToString());
                //  modeloProdutos.UnitsInStock = Convert.ToInt16(reader["PRECO_VENDA"].ToString());



                lista.Add(modeloProdutos);
            } return lista;
        }




        public ModeloProdutos ConsultarProduto(int IdProduto)
        {
            var produto = new ModeloProdutos();
            using (objConexao = new SqlConnection(strStringConexao))
            {
                using (objCommand = new SqlCommand(strSelectPorID, objConexao))
                {
                    try
                    {
                        objConexao.Open();
                        objCommand.Parameters.AddWithValue("@ProductID", IdProduto);
                        var objDataReader = objCommand.ExecuteReader();
                        if (objDataReader.HasRows) produto = PreencheValor(objDataReader);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        objConexao.Close();
                    }
                }
            } return produto;
        }


        public ModeloProdutos PreencheValor(SqlDataReader reader)
        {
            var modeloProdutos = new ModeloProdutos();
            while (reader.Read())
            {
                modeloProdutos.ProductID = reader["COD_PRODUTO"].ToString();
                //modeloProdutos.ProductID = Convert.ToInt32(reader["COD_PRODUTO"].ToString());
                modeloProdutos.ProductName = reader["DESCRICAO"].ToString();
                modeloProdutos.UnitPrice = Convert.ToDecimal(reader["PRECO_CUSTO"].ToString());
                modeloProdutos.UnitsInStock = Convert.ToDecimal(reader["PRECO_VENDA"].ToString());

            }
            return modeloProdutos;
        }



    }
}
