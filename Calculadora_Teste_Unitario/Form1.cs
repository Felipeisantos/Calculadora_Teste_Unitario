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
        private string Value_Top;

        private void Text_Top(string Op)
        {
            if (Value_Top == null)
            {
                Value_Top = Ed_Visor.Text.ToString();
                Ed_Visor_Top.Text = Value_Top.ToString() + " " + Op;
            }
            else
                Ed_Visor_Top.Text = Value_Top.ToString() + " " + Op;

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
            if (Ed_Visor.Text == null)
                Valores.Add(Converter(Ed_Visor.Text.ToString()));
            Text_Top("+");
        }

        private void Btn_Div_Click(object sender, EventArgs e)
        {
            Lbl_Operacao.Text += "/";
            if (Ed_Visor.Text == null)
                Valores.Add(Converter(Ed_Visor.Text.ToString()));
            Text_Top("/");
        }

        private void Btn_Menos_Click(object sender, EventArgs e)
        {
            Lbl_Operacao.Text += "-";
            if(Ed_Visor.Text == null)
                Valores.Add(Converter(Ed_Visor.Text.ToString()));
            Text_Top("-");
        }

        private void Btn_Mult_Click(object sender, EventArgs e)
        {
            Lbl_Operacao.Text += "*";
            if (Ed_Visor.Text == null)
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

        private void Btn_Ponto_Click(object sender, EventArgs e) => Ed_Visor.Text += ".";
        private void Btn_Clean_Click(object sender, EventArgs e)
        {
            Ed_Visor.Text = null;
            Ed_Visor_Top.Text = null;
            Value_Top = null;
            Valores.Clear();
        }

        private void Btn_Equals_Click(object sender, EventArgs e)
        {

            Operacoes operacoes = new Operacoes();
            operacoes.Subtracao(Valores);
        }

        private void Ed_Visor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
