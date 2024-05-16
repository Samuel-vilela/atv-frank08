using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv_frank08
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

        private void btn_validar_Click(object sender, EventArgs e)
        {
            int idade;

            try
            {
                idade = int.Parse(textBoxIdade.Text);
            }
                 catch (FormatException)
            {

               


                MessageBox.Show("Erro: Formato de idade inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mensagemValidacao;

                  if (idade < 18)
            {
                    mensagemValidacao = "Você não tem permição ";
            }
            else
            {
                mensagemValidacao = "Você tem permição para tirar habilitação";
         
            }

            labelResultado.Text = mensagemValidacao;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
