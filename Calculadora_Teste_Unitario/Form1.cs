using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
namespace Calculadora_Teste_Unitario
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }
        CultureInfo cultures = new CultureInfo("pt-BR");
        private List<decimal> Valores = new List<decimal>();
        Auxiliar auxiliar = new Auxiliar();

        private void Text_Top(string Op)
        {
            auxiliar.SetOperacao = Op;
            if (String.IsNullOrEmpty(auxiliar.GetValue_Top))
            {
                auxiliar.Set_Valores(Ed_Visor.Text.ToString(), Op);
                Ed_Visor_Top.Text = auxiliar.GetValue_Top + " " + auxiliar.GetOperacao;
            }
            else if (!String.IsNullOrEmpty(Ed_Visor.Text.ToString()))
            {
                MessageBox.Show("já exite uma operação em andamento e com valores já inseridos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                Ed_Visor_Top.Text = auxiliar.GetValue_Top + " " + auxiliar.GetOperacao;

            Ed_Visor.Text = null;
        }
        private decimal Converter(string str)
        {
            try
            {
                return Convert.ToDecimal(str, cultures);
            }
            catch (OverflowException er)
            {
                MessageBox.Show(er.ToString());
                return 0;
            }
        }

        #region Operações
        private void Btn_Plus_Click(object sender, EventArgs e)
        {
            Lbl_Operacao.Text += "+";
            if (!String.IsNullOrEmpty(Ed_Visor.Text))
                Valores.Add(Converter(Ed_Visor.Text.ToString()));
            Text_Top("+");
        }

        private void Btn_Div_Click(object sender, EventArgs e)
        {
            Lbl_Operacao.Text += "/";
            if (!String.IsNullOrEmpty(Ed_Visor.Text))
                Valores.Add(Converter(Ed_Visor.Text.ToString()));
            Text_Top("/");
        }

        private void Btn_Menos_Click(object sender, EventArgs e)
        {
            Lbl_Operacao.Text += "-";
            if (!String.IsNullOrEmpty(Ed_Visor.Text))
                Valores.Add(Converter(Ed_Visor.Text.ToString()));
            Text_Top("-");
        }

        private void Btn_Mult_Click(object sender, EventArgs e)
        {
            Lbl_Operacao.Text += "*";
            if (!String.IsNullOrEmpty(Ed_Visor.Text))
                Valores.Add(Converter(Ed_Visor.Text.ToString()));
            Text_Top("*");
        }
        #endregion

        #region Btn Numeros
        private void Btn_0_Click(object sender, EventArgs e) => Ed_Visor.Text += "0";
        private void Btn1_Click(object sender, EventArgs e) => Ed_Visor.Text += "1";

        private void Btn_2_Click(object sender, EventArgs e) => Ed_Visor.Text += "2";

        private void Btn_3_Click(object sender, EventArgs e) => Ed_Visor.Text += "3";

        private void Btn_4_Click(object sender, EventArgs e) => Ed_Visor.Text += "4";

        private void Btn_5_Click(object sender, EventArgs e) => Ed_Visor.Text += "5";

        private void Btn_6_Click(object sender, EventArgs e) => Ed_Visor.Text += "6";

        private void Btn_7_Click(object sender, EventArgs e) => Ed_Visor.Text += "7";

        private void Btn_8_Click(object sender, EventArgs e) => Ed_Visor.Text += "8";

        private void Btn_9_Click(object sender, EventArgs e) => Ed_Visor.Text += "9";
        #endregion

        private void Btn_Ponto_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Ed_Visor.Text.ToString()))
                Ed_Visor.Text += ",";
        }

        private void Btn_Clean_Click(object sender, EventArgs e)
        {
            Ed_Visor.Text = null;
            Ed_Visor_Top.Text = null;
            auxiliar.Erase_values();
            Valores.Clear();
        }

        private void Btn_Equals_Click(object sender, EventArgs e)
        {
            Operacoes operacoes = new Operacoes();
            if (!String.IsNullOrEmpty(Ed_Visor.Text.ToString()))
                Valores.Add(Converter(Ed_Visor.Text.ToString()));
            Ed_Visor_Top.Text = auxiliar.GetValue_Top + " " + auxiliar.GetOperacao + " " + Ed_Visor.Text.ToString();
            switch (auxiliar.GetOperacao)
            {
                case "*":
                    Ed_Visor.Text = operacoes.Multiplicacao(Valores).ToString();
                    break;
                case "+":
                    Ed_Visor.Text = operacoes.Soma(Valores).ToString();
                    break;
                case "-":
                    Ed_Visor.Text = operacoes.Subtracao(Valores).ToString();
                    break;
                case "/":
                    Ed_Visor.Text = operacoes.Divisao(Valores).ToString();
                    break;
            }
        }
    }
}
