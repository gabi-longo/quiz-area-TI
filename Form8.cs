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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            var ranking = Quiz.ObterRanking();
            var primeiro = ranking[0];
            var segundo = ranking[1];

            lblPrincipal.Text = "Seu perfil principal é: " + Quiz.NomeArea(primeiro.Key);
            lblSegundo.Text = "Seu segundo perfil é: " + Quiz.NomeArea(segundo.Key);
        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            Form1 proxima = new Form1();
            proxima.Show();
            this.Hide();
        }
    }
}
