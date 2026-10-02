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
    public partial class Form5 : Form
    {
        private char? respostaSelecionada = null;
        private Button botaoSelecionado = null;
        public Form5()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Dpi;

            CincobtnD.Focus();
        }

        private void SelecionarResposta(Button botao, char resposta)
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

        private void CincobtnA_Click(object sender, EventArgs e)
        {
            SelecionarResposta(CincobtnA, 'A');
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
                4,
                respostaSelecionada.Value);

            Form6 proxima = new Form6();
            proxima.Show();
            this.Hide();
        }

        private void CincobtnB_Click(object sender, EventArgs e)
        {
            SelecionarResposta(CincobtnB, 'B');
        }

        private void CincobtnC_Click(object sender, EventArgs e)
        {
            SelecionarResposta(CincobtnC, 'C');
        }

        private void CincobtnD_Click(object sender, EventArgs e)
        {
            SelecionarResposta(CincobtnD, 'D');
        }
    }
}
