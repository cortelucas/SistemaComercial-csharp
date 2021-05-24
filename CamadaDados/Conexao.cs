using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//permite o uso do DataTale
using System.Data;
//importa os recursos do MySql
using MySql.Data.MySqlClient;

namespace CamadaDados
{
    public class Conexao
    {
        private MySqlConnection conn;
        private DataTable data;
        MySqlDataAdapter da;
        private MySqlCommandBuilder cb;

        public void Conectar()
        {//faz conexão com o banco de dados
            if (conn != null)
                conn.Close();
            string caminho = "server = localhost; database = dbsiscomercio; uid = fatec; pwd =; ";
            try //tentativa
            {
                conn = new MySqlConnection(caminho);
                conn.Open();
                Console.WriteLine("Banco conectado e aberto");
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void ExecutarComandoSql(string comandoSql)
        {//método para executar um insert, update e delete
            MySqlCommand comando = new MySqlCommand(comandoSql, conn);
            //comando.ExecuteNonQuery();         
            Console.WriteLine(comando.ExecuteNonQuery() == 1 ? "Operação executada com sucesso!" : "Registro não inserido");
            conn.Close();
        }
        public DataTable RetornoDataTable(string sql)
        {//método para retornar uma tabela de dados
         //para preencher um grid ou um comboBox
            data = new DataTable();
            da = new MySqlDataAdapter(sql, conn);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);
            return data;
        }
    }
}
