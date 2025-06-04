using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace teste1
{
    public partial class Form1 : Form
    {
        private const string ERRO_CAMPO_VAZIO = "Os campos não podem ficar vazios";
        private const string CADASTRO_SUCESO = "Carro cadastrado com suceso";
        private const string VALOR_AUTOMATICO_INVALIDO = "Selecione um valor valido";

        public Form1()
        {
            InitializeComponent();
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
        private void InstanciarCarroEAdicionarNoGrid()
        {
            try
            {
                int i = 0;
                if (ValidarCarro())
                {
                    bool eAutomatico = comboBoxAutomatico.SelectedIndex == 0;
                    int ano = Convert.ToInt32(maskedTextBoxAno.Text);
                    Carro carro = new Carro(textBoxPlaca.Text, textBoxMarca.Text, textBoxModelo.Text, eAutomatico, ano);
                    dataGridViewCarros.Rows.Insert(i, i, carro.placa, carro.marca, carro.modelo, comboBoxAutomatico.Text, carro.ano);
                    MessageBox.Show(CADASTRO_SUCESO, "SUCESO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelAviso.Text = ".";
                    i++;
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message, "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCarro()
        {
            bool result = false;
            if (string.IsNullOrEmpty(textBoxPlaca.Text) || string.IsNullOrEmpty(textBoxMarca.Text) || string.IsNullOrEmpty(textBoxModelo.Text)
                || string.IsNullOrEmpty(maskedTextBoxAno.Text))
            {
                labelAviso.Text = ERRO_CAMPO_VAZIO;
                MessageBox.Show(ERRO_CAMPO_VAZIO, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxAutomatico.SelectedIndex < 0)
            {
                labelAviso.Text = VALOR_AUTOMATICO_INVALIDO;
                MessageBox.Show(VALOR_AUTOMATICO_INVALIDO, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                result = true;
            }
            return result;
        }

        private void buttonAdicionarCarro_Click(object sender, EventArgs e)
        {
            InstanciarCarroEAdicionarNoGrid();
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
