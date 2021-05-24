using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//permite o uso do DataGridView
using System.Data;
// importa recursos do Mysql
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace CamadaDados
{
    class DProduto
    {
        public int idproduto { get; set; }
        public string Nomeproduto { get; set; }
        public double Precounitario { get; set; }
        public int QtdeEstoque { get; set; }
        //constructor vazio
        public DProduto() { }

        public string Inserir(DProduto dProduto)
        {
            string resp = "";
            Console.WriteLine("Classe de D Produto ..........");
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                // conn obj estanciado da classe Conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();
                string sqlInserir = "INSERT INTO produto (descricao, preco, estoque) VALUES('" + dProduto.Nomeproduto + "' ,'" + dProduto.Precounitario + "', '" + dProduto.QtdeEstoque + "')";
                Console.WriteLine("SEL... " + sqlInserir);
                conexao.ExecutarComandoSql(sqlInserir);
            }
            catch (Exception ex)
            {
                resp = "Erro ao Salvar! ... " + ex.Message;
            }
        }
    }
}
