using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLCategoria
    {
        private DALConexao conexao;

        public BLLCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCategoria modelo)
        {
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatorio!");
                //modelo.CatNome = modelo.CatNome.ToUpper();
            }
            BLLCategoria DALobj = new BLLCategoria(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCategoria modelo)
        {
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatorio!");
            }
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatorio!");
            }
            BLLCategoria DALobj = new BLLCategoria(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            BLLCategoria DALobj = new BLLCategoria(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            BLLCategoria DALobj = new BLLCategoria(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            BLLCategoria DALobj = new BLLCategoria(conexao);
            return DALobj.CarregaModeloCategoria(codigo);
        }

    }
}
