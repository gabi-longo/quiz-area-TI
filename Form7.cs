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
    public partial class Form7 : Form
    {
        private char? respostaSelecionada = null;
        private Button botaoSelecionado = null;
        public Form7()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Dpi;
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

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void SetebtnA_Click(object sender, EventArgs e)
        {
            SelecionarResposta(SetebtnA, 'A');
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 proxima = new Form1(); #Criar form de resposta
            proxima.Show();
            this.Hide();
        }

        private void SetebtnB_Click(object sender, EventArgs e)
        {
            SelecionarResposta(SetebtnB, 'B');
        }

        private void SetebtnC_Click(object sender, EventArgs e)
        {
            SelecionarResposta(SetebtnC, 'C');
        }

        private void SetebtnD_Click(object sender, EventArgs e)
        {
            SelecionarResposta(SetebtnD, 'D');
        }
    }
}
