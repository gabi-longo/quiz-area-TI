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
        private Image ObterIcone(AreaTI area)
        {
            switch (area)
            {
                case AreaTI.Desenvolvimento:
                    return Properties.Resources._34_desenvolvimento2;

                case AreaTI.DadosIA:
                    return Properties.Resources._04_banco_dados_grafico;

                case AreaTI.Ciberseguranca:
                    return Properties.Resources._06_escudo_cadeado;

                case AreaTI.UXUI:
                    return Properties.Resources._03_UXUI;

                case AreaTI.Infraestrutura:
                    return Properties.Resources._09_infra;

                case AreaTI.GestaoTI:
                    return Properties.Resources._07_gestao;

                default:
                    return null;
            }
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            var ranking = Quiz.ObterRanking();
            var primeiro = ranking[0];
            var segundo = ranking[1];

            lblPrincipal.Text = "Seu perfil principal é: " + Quiz.NomeArea(primeiro.Key);
            lblSegundo.Text = "Seu segundo perfil é: " + Quiz.NomeArea(segundo.Key);
            picPrimeiro.Image = ObterIcone(primeiro.Key);
            picSegundo.Image = ObterIcone(segundo.Key);
        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            Form1 proxima = new Form1();
            proxima.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
