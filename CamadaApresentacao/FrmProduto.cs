﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NProduto.Inserir(textBox5.Text, Convert.ToDouble(textBox2.Text), Convert.ToInt32(textBox4.Text));
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = NProduto.Mostrar();
            label5.Visible = true;
            label5.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            NProduto.Editar(Convert.ToInt32(textBox1.Text), textBox5.Text, Convert.ToDouble(textBox2.Text), Convert.ToInt32(textBox4.Text));
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            NProduto.Excluir(Convert.ToInt32(textBox1.Text));
        }
    }
}
