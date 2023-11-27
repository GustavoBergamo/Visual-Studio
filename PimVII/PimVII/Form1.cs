using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PimVII.CarrinhoRepository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PimVII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        public void TxtBoxValorTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void btnLerDados_Click(object sender, EventArgs e)
        {
            //Botao para ObterPorId
            var varStringConvert = txtId.Text;
            int varInt;
            if ((int.TryParse(varStringConvert.ToString(), out varInt)))
            {

            }
            dgCarrinho.DataSource = CarrinhoRepository.Conector.ObterPorId(varInt);
            CarrinhoRepository.carrinho carrinho = new CarrinhoRepository.carrinho();
            txtBoxData.Text = dgCarrinho[1,0].Value.ToString();
            txtBoxValorTotal.Text = dgCarrinho[2,0].Value.ToString();
            txtBoxClienteId.Text = dgCarrinho[3,0].Value.ToString();
            txtBoxProdutos.Text = dgCarrinho[4,0].Value.ToString();
        }

        private void btnConsultarTodos_Click(object sender, EventArgs e)
        {
            dgCarrinho.DataSource = CarrinhoRepository.Conector.Obtertodos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CarrinhoRepository.carrinho carrinho = new CarrinhoRepository.carrinho();
            carrinho.data_pedido = txtBoxData.Text;
            carrinho.valor_total = txtBoxValorTotal.Text;
            carrinho.produtos = txtBoxProdutos.Text;
            carrinho.cliente_id = txtBoxClienteId.Text;
            CarrinhoRepository.Conector.Adicionar(carrinho);
            txtBoxData.Text = null;
            txtBoxValorTotal.Text = null;
            txtBoxProdutos.Text = null;
            txtBoxClienteId.Text = null;
            MessageBox.Show("Adicionado com sucesso");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CarrinhoRepository.carrinho carrinho = new CarrinhoRepository.carrinho();
            var varStringConvert = txtId.Text;
            int varInt;
            if ((int.TryParse(varStringConvert.ToString(), out varInt)))
            {
                carrinho.id = varInt;
            }
            carrinho.valor_total = txtBoxValorTotal.Text;
            carrinho.produtos = txtBoxProdutos.Text;
            CarrinhoRepository.Conector.Atualizar(carrinho);
            txtBoxData.Text = null;
            txtBoxValorTotal.Text = null;
            txtBoxProdutos.Text = null;
            txtBoxClienteId.Text = null;
            MessageBox.Show("Alterado com sucesso");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            CarrinhoRepository.carrinho carrinho = new CarrinhoRepository.carrinho();
            var varStringConvert = txtId.Text;
            int varInt;
            if ((int.TryParse(varStringConvert.ToString(), out varInt)))
            {
                carrinho.id = varInt;
                CarrinhoRepository.Conector.Excluir(carrinho);
            }
        }
    }
}
