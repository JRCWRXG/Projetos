using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;



namespace Listas
{
    class Produtos
    {
        public SqlConnection objConexao;
        public SqlCommand objCommand;
        public string strStringConexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        public string strSelect = "SELECT TOP 10 ProductID, ProductName, UnitPrice, UnitsInStock FROM Products";
        public string strSelectPorID = "SELECT COD_PRODUTO, DESCRICAO, PRECO_CUSTO, PRECO_VENDA FROM PRODUTOS WHERE COD_PRODUTO = @ProductID";


    }


    public class ModeloProdutos
    {
        public Int32 ProductID { get; set; }
        public String ProductName { get; set; }
        public Decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
    }






}
