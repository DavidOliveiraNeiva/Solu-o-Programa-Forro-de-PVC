using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forro_de_PVC
{
    internal class CarregarFormulario
    {
        public void Atualizar(List<ComboBox> EscolhaProduto, string[] NomeProdutos) 
        {

            #region Intanciando todos os produtos dentro das ComboBox
            foreach (ComboBox ComboBox in EscolhaProduto)
            {
                ComboBox.Items.AddRange(NomeProdutos);
            }
            #endregion
        }

        public void RefreshFormulario(ComboBox EscolhaProduto, NumericUpDown ControleDoMultiplo, TextBox ValorDoMetro, TextBox MultiploDoProduto, List<Produtos> ListaDeProdutos)
        {
            if (EscolhaProduto.Text != "") 
            {
                int IndiceDoProduto = ListaDeProdutos.FindIndex(p => p.NomeProduto == EscolhaProduto.Text);
                double MultiplicaçãoDoMultiplo = (double)ControleDoMultiplo.Value * ListaDeProdutos[IndiceDoProduto].MultiploDoProduto;
                MultiploDoProduto.Text = MultiplicaçãoDoMultiplo.ToString();
                ValorDoMetro.Text = Convert.ToString(ListaDeProdutos[IndiceDoProduto].PrecoDoProduto);
            }
            else
            {
                ControleDoMultiplo.Value = 0;
            }
        }

        public void ResetarControlesDaComboBox(NumericUpDown ControleDoMultiplo, TextBox ValorDoMetro, TextBox MultiploDoProduto)
        {
            ControleDoMultiplo.Value = 0;
            ValorDoMetro.Text = "";
            MultiploDoProduto.Text = "";
        }

        public void FormatarCampoDePreco(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    decimal valor;
                    if (decimal.TryParse(textBox.Text, out valor))
                    {
                        textBox.Text = valor.ToString("C", new CultureInfo("pt-BR"));
                    }
                }
            }
        }

        public void FormatarCampoDePreco2(TextBox PrecoDeRevenda, object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PrecoDeRevenda.Text))
            {
                decimal valor;
                if (decimal.TryParse(PrecoDeRevenda.Text, out valor))
                {
                    PrecoDeRevenda.Text = valor.ToString("C", new CultureInfo("pt-BR"));
                }
            }
        }
    }
}
