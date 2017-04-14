using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace GeradorDeLetreiros
{
    public partial class Frm_Principal : MaterialForm
    {
        public Frm_Principal()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Txt_Entrada_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Entrada.Text.Length > 0)
            {
                pictureBoxLetreiro.Image = GeradorDeLetreiros.Properties.Resources.Letreiro_Base_Sem_texto;
            }
            else
            {
                pictureBoxLetreiro.Image = GeradorDeLetreiros.Properties.Resources.Letreiro_Base;
            }

            label_Itinerario.Text = Txt_Entrada.Text;
        }

        private void Btm_Fonte_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

            label_Itinerario.Font = fontDialog1.Font;
        }

        private void Btm_Alinhar_Click(object sender, EventArgs e)
        {
            label_Itinerario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        }

        private void pic_up_Click(object sender, EventArgs e)
        {
            label_Itinerario.Top -= 5;
        }

        private void pic_down_Click(object sender, EventArgs e)
        {
            label_Itinerario.Top += 5;
        }

        private void pic_rigth_Click(object sender, EventArgs e)
        {
            label_Itinerario.Left -= 5;
        }

        private void pic_Lef_Click(object sender, EventArgs e)
        {
            label_Itinerario.Left += 5;
        }
    }
}
