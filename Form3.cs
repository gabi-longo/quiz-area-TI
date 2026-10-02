using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizz_sua_area_de_ti
{
    public partial class Form3 : Form
    {
        private char? respostaSelecionada = null;
        private Button botaoSelecionado = null;
        public Form3()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Dpi;

            DoisbtnB.Focus();
        }
        private void SelecionarResposta(Button botao,char resposta)
        {
            if (botaoSelecionado != null)
            {
                botaoSelecionado.BackColor =
                    ColorTranslator.FromHtml("#1B284E");
            }

            botaoSelecionado = botao;
            respostaSelecionada = resposta;

            botaoSelecionado.BackColor =
                ColorTranslator.FromHtml("#5C4DF6");
        }
        private void label_question1_Click(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
                SelecionarResposta(DoisbtnA, 'A');
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            SelecionarResposta(DoisbtnB, 'B');
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            SelecionarResposta(DoisbtnC, 'C');
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            SelecionarResposta(DoisbtnD, 'D');
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (respostaSelecionada == null)
            {
                MessageBox.Show(
                    "Escolha uma alternativa antes de continuar.",
                    "Quiz",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Salva resposta da PERGUNTA 
            Quiz.SalvarResposta(
                2,
                respostaSelecionada.Value);
            Form4 proxima = new Form4();
            proxima.Show();
            this.Hide();
        }
    }
}


