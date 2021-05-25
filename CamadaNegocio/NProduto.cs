using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Repassa dados para a camada de dados
using System.Data;
using CamadaDados;

namespace CamadaNegocio
{
    public class NProduto
    {
        public static string Inserir(string nome, double preco, int qtdEstoque)
        {
            //Associa com a camada de dados
            DProduto Obj = new DProduto();
            Obj.Nomeproduto = nome;
            Obj.Precounitario = preco;
            Obj.QtdeEstoque = qtdEstoque;
            return Obj.Inserir(Obj);
        }
        public static string Excluir(int idproduto)
        {
            DProduto Obj = new DProduto();
            Obj.Idproduto = idproduto;
            return Obj.Excluir(Obj);
        }
    }
}
