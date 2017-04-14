namespace GeradorDeLetreiros
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Txt_Entrada = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Btm_GerarLetreiro = new MaterialSkin.Controls.MaterialRaisedButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label_Itinerario = new System.Windows.Forms.Label();
            this.pictureBoxLetreiro = new System.Windows.Forms.PictureBox();
            this.pic_up = new System.Windows.Forms.PictureBox();
            this.pic_down = new System.Windows.Forms.PictureBox();
            this.pic_rigth = new System.Windows.Forms.PictureBox();
            this.pic_Lef = new System.Windows.Forms.PictureBox();
            this.Btm_Fonte = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panelLetreiro = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLetreiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lef)).BeginInit();
            this.panelLetreiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Entrada
            // 
            this.Txt_Entrada.Depth = 0;
            this.Txt_Entrada.Hint = "";
            this.Txt_Entrada.Location = new System.Drawing.Point(202, 296);
            this.Txt_Entrada.MouseState = MaterialSkin.MouseState.HOVER;
            this.Txt_Entrada.Name = "Txt_Entrada";
            this.Txt_Entrada.PasswordChar = '\0';
            this.Txt_Entrada.SelectedText = "";
            this.Txt_Entrada.SelectionLength = 0;
            this.Txt_Entrada.SelectionStart = 0;
            this.Txt_Entrada.Size = new System.Drawing.Size(645, 23);
            this.Txt_Entrada.TabIndex = 1;
            this.Txt_Entrada.UseSystemPasswordChar = false;
            this.Txt_Entrada.TextChanged += new System.EventHandler(this.Txt_Entrada_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(109, 301);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(81, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Itinerário - ";
            // 
            // Btm_GerarLetreiro
            // 
            this.Btm_GerarLetreiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_GerarLetreiro.Depth = 0;
            this.Btm_GerarLetreiro.Location = new System.Drawing.Point(202, 346);
            this.Btm_GerarLetreiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btm_GerarLetreiro.Name = "Btm_GerarLetreiro";
            this.Btm_GerarLetreiro.Primary = true;
            this.Btm_GerarLetreiro.Size = new System.Drawing.Size(645, 36);
            this.Btm_GerarLetreiro.TabIndex = 2;
            this.Btm_GerarLetreiro.Text = "Salvar";
            this.Btm_GerarLetreiro.UseVisualStyleBackColor = true;
            this.Btm_GerarLetreiro.Click += new System.EventHandler(this.Btm_GerarLetreiro_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowHelp = true;
            // 
            // label_Itinerario
            // 
            this.label_Itinerario.AutoSize = true;
            this.label_Itinerario.BackColor = System.Drawing.Color.Black;
            this.label_Itinerario.ForeColor = System.Drawing.Color.White;
            this.label_Itinerario.Location = new System.Drawing.Point(109, 136);
            this.label_Itinerario.Name = "label_Itinerario";
            this.label_Itinerario.Size = new System.Drawing.Size(0, 13);
            this.label_Itinerario.TabIndex = 5;
            this.label_Itinerario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLetreiro
            // 
            this.pictureBoxLetreiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLetreiro.Image = global::GeradorDeLetreiros.Properties.Resources.Letreiro_Base;
            this.pictureBoxLetreiro.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLetreiro.Name = "pictureBoxLetreiro";
            this.pictureBoxLetreiro.Size = new System.Drawing.Size(1025, 131);
            this.pictureBoxLetreiro.TabIndex = 0;
            this.pictureBoxLetreiro.TabStop = false;
            // 
            // pic_up
            // 
            this.pic_up.BackColor = System.Drawing.Color.Transparent;
            this.pic_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_up.Image = global::GeradorDeLetreiros.Properties.Resources.ic_keyboard_arrow_up_white_48px;
            this.pic_up.Location = new System.Drawing.Point(1044, 77);
            this.pic_up.Name = "pic_up";
            this.pic_up.Size = new System.Drawing.Size(41, 38);
            this.pic_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_up.TabIndex = 6;
            this.pic_up.TabStop = false;
            this.pic_up.Click += new System.EventHandler(this.pic_up_Click);
            // 
            // pic_down
            // 
            this.pic_down.BackColor = System.Drawing.Color.Transparent;
            this.pic_down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_down.Image = global::GeradorDeLetreiros.Properties.Resources.ic_keyboard_arrow_down_white_48px;
            this.pic_down.Location = new System.Drawing.Point(1044, 163);
            this.pic_down.Name = "pic_down";
            this.pic_down.Size = new System.Drawing.Size(41, 38);
            this.pic_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_down.TabIndex = 7;
            this.pic_down.TabStop = false;
            this.pic_down.Click += new System.EventHandler(this.pic_down_Click);
            // 
            // pic_rigth
            // 
            this.pic_rigth.BackColor = System.Drawing.Color.Transparent;
            this.pic_rigth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_rigth.Image = global::GeradorDeLetreiros.Properties.Resources.ic_keyboard_arrow_right_white_48px;
            this.pic_rigth.Location = new System.Drawing.Point(991, 214);
            this.pic_rigth.Name = "pic_rigth";
            this.pic_rigth.Size = new System.Drawing.Size(41, 38);
            this.pic_rigth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rigth.TabIndex = 8;
            this.pic_rigth.TabStop = false;
            this.pic_rigth.Click += new System.EventHandler(this.pic_rigth_Click);
            // 
            // pic_Lef
            // 
            this.pic_Lef.BackColor = System.Drawing.Color.Transparent;
            this.pic_Lef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Lef.Image = global::GeradorDeLetreiros.Properties.Resources.ic_keyboard_arrow_left_white_48px;
            this.pic_Lef.Location = new System.Drawing.Point(908, 214);
            this.pic_Lef.Name = "pic_Lef";
            this.pic_Lef.Size = new System.Drawing.Size(41, 38);
            this.pic_Lef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Lef.TabIndex = 9;
            this.pic_Lef.TabStop = false;
            this.pic_Lef.Click += new System.EventHandler(this.pic_Lef_Click);
            // 
            // Btm_Fonte
            // 
            this.Btm_Fonte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_Fonte.Depth = 0;
            this.Btm_Fonte.Location = new System.Drawing.Point(12, 214);
            this.Btm_Fonte.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btm_Fonte.Name = "Btm_Fonte";
            this.Btm_Fonte.Primary = true;
            this.Btm_Fonte.Size = new System.Drawing.Size(63, 33);
            this.Btm_Fonte.TabIndex = 3;
            this.Btm_Fonte.Text = "Fonte";
            this.Btm_Fonte.UseVisualStyleBackColor = true;
            this.Btm_Fonte.Click += new System.EventHandler(this.Btm_Fonte_Click);
            // 
            // panelLetreiro
            // 
            this.panelLetreiro.BackColor = System.Drawing.Color.Transparent;
            this.panelLetreiro.Controls.Add(this.pictureBoxLetreiro);
            this.panelLetreiro.ForeColor = System.Drawing.Color.Transparent;
            this.panelLetreiro.Location = new System.Drawing.Point(12, 77);
            this.panelLetreiro.Name = "panelLetreiro";
            this.panelLetreiro.Size = new System.Drawing.Size(1025, 131);
            this.panelLetreiro.TabIndex = 10;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 440);
            this.Controls.Add(this.label_Itinerario);
            this.Controls.Add(this.panelLetreiro);
            this.Controls.Add(this.pic_Lef);
            this.Controls.Add(this.pic_rigth);
            this.Controls.Add(this.pic_down);
            this.Controls.Add(this.pic_up);
            this.Controls.Add(this.Btm_Fonte);
            this.Controls.Add(this.Btm_GerarLetreiro);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Txt_Entrada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de letreiros";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLetreiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lef)).EndInit();
            this.panelLetreiro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Txt_Entrada;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton Btm_GerarLetreiro;
        private System.Windows.Forms.PictureBox pictureBoxLetreiro;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label_Itinerario;
        private System.Windows.Forms.PictureBox pic_up;
        private System.Windows.Forms.PictureBox pic_down;
        private System.Windows.Forms.PictureBox pic_rigth;
        private System.Windows.Forms.PictureBox pic_Lef;
        private MaterialSkin.Controls.MaterialRaisedButton Btm_Fonte;
        private System.Windows.Forms.Panel panelLetreiro;

    }
}

