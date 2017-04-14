using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

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

        private void Btm_Cor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label_Itinerario.ForeColor = colorDialog1.Color;
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
            label_Itinerario.Left += 15;
        }

        private void pic_Lef_Click(object sender, EventArgs e)
        {
            label_Itinerario.Left -= 15;
        }

        private void Btm_GerarLetreiro_Click(object sender, EventArgs e)
        {
            salvarItinerario();
        }

        private void salvarItinerario()
        {
            Control c = label_Itinerario;
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(c.Width, c.Height);
            c.DrawToBitmap(bmp, c.ClientRectangle);

            SaveFileDialog sf = new SaveFileDialog();

            sf.FileName = "itinerario.JPEG";
            sf.Title = "Salvar itinerário";
            sf.RestoreDirectory = true;
            sf.AddExtension = true;
            sf.Filter = "Images (*.Png + Jpeg)|*.Png + *.Jpeg";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sf.FileName, ImageFormat.Jpeg);

                MessageBox.Show("Arquivo salvo com sucesso","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Escolha um local para salvar seu arquivo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            if (Atualizacoes.VerificarAtualizacao())
            {
                DialogResult dr = new DialogResult();
                    
                 dr = MessageBox.Show("Uma nova atualizaão do software foi encontrada, deseja atualiza-lo?","Pergunta"
                    ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if(dr == System.Windows.Forms.DialogResult.Yes) 
                {
                    Process.Start(Atualizacoes.ObterLinkUltimaVersao());

                    Application.Exit();
                }
            }
        }

    }
}
