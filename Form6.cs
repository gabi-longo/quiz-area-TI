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
    public partial class Form6 : Form
    {
        private char? respostaSelecionada = null;
        private Button botaoSelecionado = null;
        public Form6()
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

        private void SeisbtnA_Click(object sender, EventArgs e)
        {
            SelecionarResposta(SeisbtnA, 'A');
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form7 proxima = new Form7();
            proxima.Show();
            this.Hide();
        }

        private void SeisbtnB_Click(object sender, EventArgs e)
        {
            SelecionarResposta(SeisbtnB, 'B');
        }

        private void SeisbtnC_Click(object sender, EventArgs e)
        {
            SelecionarResposta(SeisbtnC, 'C');
        }

        private void SeisbtnD_Click(object sender, EventArgs e)
        {
            SelecionarResposta(SeisbtnD, 'D');
        }
    }
}
