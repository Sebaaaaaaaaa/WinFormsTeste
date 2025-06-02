namespace teste1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            CalcularPrecoTotal();
        }

        private void CalcularPrecoTotal()
        {
            try
            {
                textBoxTotal.Text = obterPrecoTotal().ToString("C2", System.Globalization.CultureInfo.CurrentCulture);
            }
            catch (Exception e)
            {

            }
        }

        private Decimal obterPrecoTotal()
        {
            Decimal total = 0;
            foreach (Produto p in produtos)
            {
                total += p.preco * p.quantidade;
            }
            return total;
        }

        //private void CalcularTotalProdutos()
        //{
        //    try
        //    {
        //        int id = Convert.ToInt32(textBoxId.Text);

        //        int quantidade = Convert.ToInt32(textBoxQuantidade.Text);

        //        Decimal preco = Convert.ToDecimal(textBoxPreco.Text);

        //        Decimal total = preco * quantidade;

        //        textBoxTotal.Text = total.ToString("C2", System.Globalization.CultureInfo.CurrentCulture);
        //    }
        //    catch (Exception e)
        //    {
        //        labelAviso.Text = e.Message;
        //        labelAviso.ForeColor = Color.Red;
        //    }

        //}

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarNaSacola();
        }

        private class Produto
        {
            public int id { get; set; }
            public int quantidade { get; set; }
            public Decimal preco { get; set; }

            public Produto(int id, int quantidade, Decimal preco)
            {
                this.id = id;
                this.quantidade = quantidade;
                this.preco = preco;
            }
        }


        private void AdicionarNaSacola()
        {
            int index = 0;

            try
            {
                
                Produto produto = CriarProduto();
                produtos.Add(produto);
                dataGridViewProdutos.Rows.Insert(index, produto.id, produto.quantidade, produto.preco);
            }
            catch (Exception e)
            {
                labelAviso.Text = e.Message;
                labelAviso.ForeColor = Color.Red;
            }
            index++;

            textBoxId.Clear();
            textBoxQuantidade.Clear();
            textBoxPreco.Clear();
        }

        private Produto CriarProduto()
        {
            int id = Convert.ToInt32(textBoxId.Text);
            int quantidade = Convert.ToInt32(textBoxQuantidade.Text);
            Decimal preco = Convert.ToDecimal(textBoxPreco.Text);
            Produto produto = new Produto(id, quantidade, preco);

            return produto;
        }



        /*private void Calcular1()
        {
            try
            {
                Decimal preco = Convert.ToDecimal(textBoxId.Text);

                int quantidade = Convert.ToInt32(textBoxPreco.Text);

                Decimal total = preco * quantidade;

                textBoxTotal.Text = total.ToString("C2", System.Globalization.CultureInfo.CurrentCulture);

                if (total > 1000)
                {
                    labelAviso.Text = "Valor total acima de R$ 1000,00!";
                    labelAviso.ForeColor = Color.Red;
                    labelAviso.BackColor = Color.Yellow;
                }
                else
                {
                    labelAviso.Text = "Valor total dentro do limite.";
                    labelAviso.ForeColor = Color.Green;
                }
            }
            catch (Exception e)
            {
                DialogResult resutado = MessageBox.Show("Erro ao calcular: " + e.Message, "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (resutado == DialogResult.Yes)
                {
                    MessageBox.Show("PRESSIONOU sim");
                }
                else if (resutado == DialogResult.No)
                {
                    MessageBox.Show("PRESSIONOU nao");
                }

                labelAviso.Text = "Erro ao calcular: " + e.Message;
                labelAviso.ForeColor = Color.Red;
                labelAviso.BackColor = Color.Yellow;
            }

        }
         * 
         * 
         */
    }
}
