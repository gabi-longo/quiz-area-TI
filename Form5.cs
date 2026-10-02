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
        }

        private void CincobtnA_Click(object sender, EventArgs e)
        {

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
    }
}
