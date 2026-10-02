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
    public partial class Form4 : Form
    {
        private char? respostaSelecionada = null;
        private Button botaoSelecionado = null;

        public Form4()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Dpi;

            QuatrobtnC.Focus();
        }

        private void SelecionarResposta(Button botao,char resposta)
        {
            // Volta o botão anterior para a cor normal
            if (botaoSelecionado != null)
            {
                botaoSelecionado.BackColor =
                    ColorTranslator.FromHtml("#1B284E");
            }

            // Guarda qual alternativa foi escolhida
            botaoSelecionado = botao;
            respostaSelecionada = resposta;

            // Deixa a alternativa selecionada roxa
            botaoSelecionado.BackColor =
                ColorTranslator.FromHtml("#5C4DF6");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuatrobtnA_Click(object sender, EventArgs e)
        {
            SelecionarResposta(QuatrobtnA, 'A');
        }

        private void QuatrobtnB_Click(object sender, EventArgs e)
        {
            SelecionarResposta(QuatrobtnB, 'B');
        }

        private void QuatrobtnC_Click(object sender, EventArgs e)
        {
            SelecionarResposta(QuatrobtnC, 'C');
        }

        private void QuatrobtnD_Click(object sender, EventArgs e)
        {
            SelecionarResposta(QuatrobtnD, 'D');
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
                3,
                respostaSelecionada.Value);

            Form5 proxima = new Form5();
            proxima.Show();
            this.Hide();
        }
    }
}
