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
    public partial class Form2 : Form
    {
        private char? respostaSelecionada = null;
        private Button botaoSelecionado = null;

        public Form2()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void SelecionarResposta(
            Button botao,
            char resposta)
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

        private void btnA_Click(object sender, EventArgs e)
        {
            SelecionarResposta(btnA, 'A');
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            SelecionarResposta(btnB, 'B');
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            SelecionarResposta(btnC, 'C');
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            SelecionarResposta(btnD, 'D');
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

            // Salva resposta da PERGUNTA 1
            Quiz.SalvarResposta(
                1,
                respostaSelecionada.Value);

            Form3 proxima = new Form3();

            proxima.Show();

            this.Hide();
        }

        private void text_box_TextChanged(
            object sender,
            EventArgs e)
        {

        }

        private void Form2_Load(
            object sender,
            EventArgs e)
        {

        }

        private void panel1_Paint(
            object sender,
            PaintEventArgs e)
        {

        }
    }
}
