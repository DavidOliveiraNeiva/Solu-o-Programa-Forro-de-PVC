using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forro_de_PVC
{
    public partial class Form1 : Form
    {
        private List<ComboBox> EscolhaProduto;
        private List<Produtos> ListaDeProdutos;
        private CarregarFormulario CarregarFormulario = new CarregarFormulario();
        public Form1()
        {
            InitializeComponent();

            #region Classes Instanciada no Formulario
            //CarregarFormulario CarregarFormulario = new CarregarFormulario();
            #endregion

            #region Coleção de ComboBox EscolhaProduto
            EscolhaProduto = new List<ComboBox>
            {
                EscolhaProduto1,
                EscolhaProduto2,
                EscolhaProduto3,
                EscolhaProduto4,
                EscolhaProduto5,
                EscolhaProduto6,
                EscolhaProduto7,
                EscolhaProduto8,
                EscolhaProduto9,
                EscolhaProduto10,
                EscolhaProduto11,
                EscolhaProduto12,
                EscolhaProduto13,
                EscolhaProduto14,
                EscolhaProduto15
            };
            #endregion

            #region Atributos importados para esta classe
            int QuantidadeProduto = 15;

            ListaDeProdutos = new List<Produtos>();

            Produtos[] produtos = new Produtos[QuantidadeProduto];
            string[] NomeProdutos = new string[QuantidadeProduto];

            for (int i = 0; i < QuantidadeProduto; i++)
            {
                produtos[i] = new Produtos();

                produtos[i].NomeProduto = "Produto " + (i + 1);
                NomeProdutos[i] = produtos[i].NomeProduto;
                produtos[i].MultiploDoProduto = 10.2 * (i + 1);
                produtos[i].PrecoDoProduto = 13.4 * (i + 1) + (i + 1);

                ListaDeProdutos.Add(produtos[i]);
            }
            #endregion

            CarregarFormulario.Atualizar(EscolhaProduto, NomeProdutos);
        }
        #region ControleDoMultiplo Evento changed
        private void ControleDoMultiplo1_ValueChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((NumericUpDown)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoEscolhaProduto = "EscolhaProduto" + parteSelecionada;
            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            ComboBox EscolhaProduto = this.Controls.Find(NomeDoCampoEscolhaProduto, true).FirstOrDefault() as ComboBox;
            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.RefreshFormulario(EscolhaProduto, ControleDoMultiplo, ValorDoMetro, MultiploDoProduto, ListaDeProdutos);
        }

        private void ControleDoMultiplo2_ValueChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((NumericUpDown)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoEscolhaProduto = "EscolhaProduto" + parteSelecionada;
            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            ComboBox EscolhaProduto = this.Controls.Find(NomeDoCampoEscolhaProduto, true).FirstOrDefault() as ComboBox;
            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.RefreshFormulario(EscolhaProduto, ControleDoMultiplo, ValorDoMetro, MultiploDoProduto, ListaDeProdutos);
        }

        private void ControleDoMultiplo3_ValueChanged_1(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((NumericUpDown)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoEscolhaProduto = "EscolhaProduto" + parteSelecionada;
            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            ComboBox EscolhaProduto = this.Controls.Find(NomeDoCampoEscolhaProduto, true).FirstOrDefault() as ComboBox;
            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.RefreshFormulario(EscolhaProduto, ControleDoMultiplo, ValorDoMetro, MultiploDoProduto, ListaDeProdutos);
        }

        private void ControleDoMultiplo4_ValueChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((NumericUpDown)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoEscolhaProduto = "EscolhaProduto" + parteSelecionada;
            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            ComboBox EscolhaProduto = this.Controls.Find(NomeDoCampoEscolhaProduto, true).FirstOrDefault() as ComboBox;
            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.RefreshFormulario(EscolhaProduto, ControleDoMultiplo, ValorDoMetro, MultiploDoProduto, ListaDeProdutos);
        }

        private void ControleDoMultiplo5_ValueChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((NumericUpDown)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoEscolhaProduto = "EscolhaProduto" + parteSelecionada;
            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            ComboBox EscolhaProduto = this.Controls.Find(NomeDoCampoEscolhaProduto, true).FirstOrDefault() as ComboBox;
            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.RefreshFormulario(EscolhaProduto, ControleDoMultiplo, ValorDoMetro, MultiploDoProduto, ListaDeProdutos);
        }

        private void ControleDoMultiplo6_ValueChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((NumericUpDown)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoEscolhaProduto = "EscolhaProduto" + parteSelecionada;
            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            ComboBox EscolhaProduto = this.Controls.Find(NomeDoCampoEscolhaProduto, true).FirstOrDefault() as ComboBox;
            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.RefreshFormulario(EscolhaProduto, ControleDoMultiplo, ValorDoMetro, MultiploDoProduto, ListaDeProdutos);
        }

        private void ControleDoMultiplo7_ValueChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((NumericUpDown)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoEscolhaProduto = "EscolhaProduto" + parteSelecionada;
            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            ComboBox EscolhaProduto = this.Controls.Find(NomeDoCampoEscolhaProduto, true).FirstOrDefault() as ComboBox;
            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.RefreshFormulario(EscolhaProduto, ControleDoMultiplo, ValorDoMetro, MultiploDoProduto, ListaDeProdutos);
        }

        private void ControleDoMultiplo8_ValueChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((NumericUpDown)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoEscolhaProduto = "EscolhaProduto" + parteSelecionada;
            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            ComboBox EscolhaProduto = this.Controls.Find(NomeDoCampoEscolhaProduto, true).FirstOrDefault() as ComboBox;
            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.RefreshFormulario(EscolhaProduto, ControleDoMultiplo, ValorDoMetro, MultiploDoProduto, ListaDeProdutos);
        }

        private void ControleDoMultiplo9_ValueChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((NumericUpDown)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoEscolhaProduto = "EscolhaProduto" + parteSelecionada;
            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            ComboBox EscolhaProduto = this.Controls.Find(NomeDoCampoEscolhaProduto, true).FirstOrDefault() as ComboBox;
            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.RefreshFormulario(EscolhaProduto, ControleDoMultiplo, ValorDoMetro, MultiploDoProduto, ListaDeProdutos);
        }

        private void ControleDoMultiplo10_ValueChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((NumericUpDown)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoEscolhaProduto = "EscolhaProduto" + parteSelecionada;
            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            ComboBox EscolhaProduto = this.Controls.Find(NomeDoCampoEscolhaProduto, true).FirstOrDefault() as ComboBox;
            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.RefreshFormulario(EscolhaProduto, ControleDoMultiplo, ValorDoMetro, MultiploDoProduto, ListaDeProdutos);
        }

        private void ControleDoMultiplo11_ValueChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((NumericUpDown)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoEscolhaProduto = "EscolhaProduto" + parteSelecionada;
            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            ComboBox EscolhaProduto = this.Controls.Find(NomeDoCampoEscolhaProduto, true).FirstOrDefault() as ComboBox;
            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.RefreshFormulario(EscolhaProduto, ControleDoMultiplo, ValorDoMetro, MultiploDoProduto, ListaDeProdutos);
        }

        private void ControleDoMultiplo12_ValueChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((NumericUpDown)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoEscolhaProduto = "EscolhaProduto" + parteSelecionada;
            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            ComboBox EscolhaProduto = this.Controls.Find(NomeDoCampoEscolhaProduto, true).FirstOrDefault() as ComboBox;
            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.RefreshFormulario(EscolhaProduto, ControleDoMultiplo, ValorDoMetro, MultiploDoProduto, ListaDeProdutos);
        }

        private void ControleDoMultiplo13_ValueChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((NumericUpDown)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoEscolhaProduto = "EscolhaProduto" + parteSelecionada;
            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            ComboBox EscolhaProduto = this.Controls.Find(NomeDoCampoEscolhaProduto, true).FirstOrDefault() as ComboBox;
            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.RefreshFormulario(EscolhaProduto, ControleDoMultiplo, ValorDoMetro, MultiploDoProduto, ListaDeProdutos);
        }

        private void ControleDoMultiplo14_ValueChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((NumericUpDown)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoEscolhaProduto = "EscolhaProduto" + parteSelecionada;
            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            ComboBox EscolhaProduto = this.Controls.Find(NomeDoCampoEscolhaProduto, true).FirstOrDefault() as ComboBox;
            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.RefreshFormulario(EscolhaProduto, ControleDoMultiplo, ValorDoMetro, MultiploDoProduto, ListaDeProdutos);
        }

        private void ControleDoMultiplo15_ValueChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((NumericUpDown)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoEscolhaProduto = "EscolhaProduto" + parteSelecionada;
            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            ComboBox EscolhaProduto = this.Controls.Find(NomeDoCampoEscolhaProduto, true).FirstOrDefault() as ComboBox;
            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.RefreshFormulario(EscolhaProduto, ControleDoMultiplo, ValorDoMetro, MultiploDoProduto, ListaDeProdutos);
        }
        #endregion
        //
        #region EscolhaDoProduto evento Update e select
        private void EscolhaProduto1_TextUpdate(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto2_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto2_TextUpdate(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto3_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto3_TextUpdate(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto4_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto4_TextUpdate(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto5_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto5_TextUpdate(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto6_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto6_TextUpdate(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto7_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto7_TextUpdate(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto8_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto8_TextUpdate(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto9_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto9_TextUpdate(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto10_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto10_TextUpdate(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto11_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto11_TextUpdate(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto12_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto12_TextUpdate(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto13_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto13_TextUpdate(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto14_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto14_TextUpdate(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto15_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }

        private void EscolhaProduto15_TextUpdate(object sender, EventArgs e)
        {
            #region Captar Todos Elementos Necessarios
            string NomeDoCampo = ((ComboBox)sender).Name;
            string parteSelecionada = NomeDoCampo.Substring(NomeDoCampo.Length - 1);

            string NomeDoCampoControleDoMultiplo = "ControleDoMultiplo" + parteSelecionada;
            string NomeDoCampoValorDoMetro = "ValorDoMetro" + parteSelecionada;
            string NomeDoCampoMultiploDoProduto = "MultiploDoProduto" + parteSelecionada;

            NumericUpDown ControleDoMultiplo = this.Controls.Find(NomeDoCampoControleDoMultiplo, true).FirstOrDefault() as NumericUpDown;
            TextBox ValorDoMetro = this.Controls.Find(NomeDoCampoValorDoMetro, true).FirstOrDefault() as TextBox;
            TextBox MultiploDoProduto = this.Controls.Find(NomeDoCampoMultiploDoProduto, true).FirstOrDefault() as TextBox;
            #endregion

            CarregarFormulario.ResetarControlesDaComboBox(ControleDoMultiplo, ValorDoMetro, MultiploDoProduto);
        }
        #endregion
        //

        private void PrecoDeRevenda1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void PrecoDeRevenda1_Leave(object sender, EventArgs e)
        {
            
        }

        private void PrecoDeRevenda2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void PrecoDeRevenda2_Leave(object sender, EventArgs e)
        {

        }

        //private void PrecoDeRevenda1_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    CarregarFormulario.FormatarCampoDePreco(sender, e);
        //}

        //private void PrecoDeRevenda1_Leave(object sender, EventArgs e)
        //{
        //    CarregarFormulario.FormatarCampoDePreco2(PrecoDeRevenda1, sender, e);
        //}

        //private void PrecoDeRevenda1_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    CarregarFormulario.FormatarCampoDePreco(sender, e);
        //}

        //private void PrecoDeRevenda1_Leave(object sender, EventArgs e)
        //{
        //    CarregarFormulario.FormatarCampoDePreco2(PrecoDeRevenda1, sender, e);
        //}

        //private void PrecoDeRevenda1_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    CarregarFormulario.FormatarCampoDePreco(sender, e);
        //}

        //private void PrecoDeRevenda1_Leave(object sender, EventArgs e)
        //{
        //    CarregarFormulario.FormatarCampoDePreco2(PrecoDeRevenda1, sender, e);
        //}

        //private void PrecoDeRevenda1_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    CarregarFormulario.FormatarCampoDePreco(sender, e);
        //}

        //private void PrecoDeRevenda1_Leave(object sender, EventArgs e)
        //{
        //    CarregarFormulario.FormatarCampoDePreco2(PrecoDeRevenda1, sender, e);
        //}

        //private void PrecoDeRevenda1_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    CarregarFormulario.FormatarCampoDePreco(sender, e);
        //}

        //private void PrecoDeRevenda1_Leave(object sender, EventArgs e)
        //{
        //    CarregarFormulario.FormatarCampoDePreco2(PrecoDeRevenda1, sender, e);
        //}

        //private void PrecoDeRevenda1_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    CarregarFormulario.FormatarCampoDePreco(sender, e);
        //}

        //private void PrecoDeRevenda1_Leave(object sender, EventArgs e)
        //{
        //    CarregarFormulario.FormatarCampoDePreco2(PrecoDeRevenda1, sender, e);
        //}

        //private void PrecoDeRevenda1_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    CarregarFormulario.FormatarCampoDePreco(sender, e);
        //}

        //private void PrecoDeRevenda1_Leave(object sender, EventArgs e)
        //{
        //    CarregarFormulario.FormatarCampoDePreco2(PrecoDeRevenda1, sender, e);
        //}

        //private void PrecoDeRevenda1_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    CarregarFormulario.FormatarCampoDePreco(sender, e);
        //}

        //private void PrecoDeRevenda1_Leave(object sender, EventArgs e)
        //{
        //    CarregarFormulario.FormatarCampoDePreco2(PrecoDeRevenda1, sender, e);
        //}

        //private void PrecoDeRevenda1_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    CarregarFormulario.FormatarCampoDePreco(sender, e);
        //}

        //private void PrecoDeRevenda1_Leave(object sender, EventArgs e)
        //{
        //    CarregarFormulario.FormatarCampoDePreco2(PrecoDeRevenda1, sender, e);
        //}

        //private void PrecoDeRevenda1_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    CarregarFormulario.FormatarCampoDePreco(sender, e);
        //}

        //private void PrecoDeRevenda1_Leave(object sender, EventArgs e)
        //{
        //    CarregarFormulario.FormatarCampoDePreco2(PrecoDeRevenda1, sender, e);
        //}

        //private void PrecoDeRevenda1_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    CarregarFormulario.FormatarCampoDePreco(sender, e);
        //}

        //private void PrecoDeRevenda1_Leave(object sender, EventArgs e)
        //{
        //    CarregarFormulario.FormatarCampoDePreco2(PrecoDeRevenda1, sender, e);
        //}

        //private void PrecoDeRevenda1_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    CarregarFormulario.FormatarCampoDePreco(sender, e);
        //}

        //private void PrecoDeRevenda1_Leave(object sender, EventArgs e)
        //{
        //    CarregarFormulario.FormatarCampoDePreco2(PrecoDeRevenda1, sender, e);
        //}

        //private void PrecoDeRevenda1_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    CarregarFormulario.FormatarCampoDePreco(sender, e);
        //}

        //private void PrecoDeRevenda1_Leave(object sender, EventArgs e)
        //{
        //    CarregarFormulario.FormatarCampoDePreco2(PrecoDeRevenda1, sender, e);
        //}
    }
}
