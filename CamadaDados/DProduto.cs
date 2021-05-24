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

    }
}
