
namespace MediaAlunos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstAlunos = new System.Windows.Forms.ListBox();
            this.lstPortugues = new System.Windows.Forms.ListBox();
            this.lstMatematica = new System.Windows.Forms.ListBox();
            this.lstGeografia = new System.Windows.Forms.ListBox();
            this.lstHistoria = new System.Windows.Forms.ListBox();
            this.lstIngles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstCiencia = new System.Windows.Forms.ListBox();
            this.lstEducacaoFisica = new System.Windows.Forms.ListBox();
            this.lstArtes = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstMediaGeral = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAlunos
            // 
            this.lstAlunos.FormattingEnabled = true;
            this.lstAlunos.Location = new System.Drawing.Point(23, 31);
            this.lstAlunos.Name = "lstAlunos";
            this.lstAlunos.Size = new System.Drawing.Size(210, 329);
            this.lstAlunos.TabIndex = 0;
            this.lstAlunos.SelectedIndexChanged += new System.EventHandler(this.lstAlunos_SelectedIndexChanged);
            // 
            // lstPortugues
            // 
            this.lstPortugues.FormattingEnabled = true;
            this.lstPortugues.Location = new System.Drawing.Point(302, 33);
            this.lstPortugues.Name = "lstPortugues";
            this.lstPortugues.Size = new System.Drawing.Size(53, 329);
            this.lstPortugues.TabIndex = 1;
            this.lstPortugues.SelectedIndexChanged += new System.EventHandler(this.lstPortugues_SelectedIndexChanged);
            // 
            // lstMatematica
            // 
            this.lstMatematica.FormattingEnabled = true;
            this.lstMatematica.Location = new System.Drawing.Point(382, 33);
            this.lstMatematica.Name = "lstMatematica";
            this.lstMatematica.Size = new System.Drawing.Size(53, 329);
            this.lstMatematica.TabIndex = 2;
            this.lstMatematica.SelectedIndexChanged += new System.EventHandler(this.lstMatematica_SelectedIndexChanged);
            // 
            // lstGeografia
            // 
            this.lstGeografia.FormattingEnabled = true;
            this.lstGeografia.Location = new System.Drawing.Point(450, 33);
            this.lstGeografia.Name = "lstGeografia";
            this.lstGeografia.Size = new System.Drawing.Size(53, 329);
            this.lstGeografia.TabIndex = 3;
            this.lstGeografia.SelectedIndexChanged += new System.EventHandler(this.lstGeografia_SelectedIndexChanged);
            // 
            // lstHistoria
            // 
            this.lstHistoria.FormattingEnabled = true;
            this.lstHistoria.Location = new System.Drawing.Point(520, 31);
            this.lstHistoria.Name = "lstHistoria";
            this.lstHistoria.Size = new System.Drawing.Size(53, 329);
            this.lstHistoria.TabIndex = 4;
            this.lstHistoria.SelectedIndexChanged += new System.EventHandler(this.lstHistoria_SelectedIndexChanged);
            // 
            // lstIngles
            // 
            this.lstIngles.FormattingEnabled = true;
            this.lstIngles.Location = new System.Drawing.Point(589, 31);
            this.lstIngles.Name = "lstIngles";
            this.lstIngles.Size = new System.Drawing.Size(53, 329);
            this.lstIngles.TabIndex = 5;
            this.lstIngles.SelectedIndexChanged += new System.EventHandler(this.lstIngles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "N1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "N2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "N3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "N4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "N5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "N6";
            // 
            // lstCiencia
            // 
            this.lstCiencia.FormattingEnabled = true;
            this.lstCiencia.Location = new System.Drawing.Point(657, 31);
            this.lstCiencia.Name = "lstCiencia";
            this.lstCiencia.Size = new System.Drawing.Size(53, 329);
            this.lstCiencia.TabIndex = 12;
            this.lstCiencia.SelectedIndexChanged += new System.EventHandler(this.lstCiencia_SelectedIndexChanged);
            // 
            // lstEducacaoFisica
            // 
            this.lstEducacaoFisica.FormattingEnabled = true;
            this.lstEducacaoFisica.Location = new System.Drawing.Point(724, 33);
            this.lstEducacaoFisica.Name = "lstEducacaoFisica";
            this.lstEducacaoFisica.Size = new System.Drawing.Size(53, 329);
            this.lstEducacaoFisica.TabIndex = 13;
            this.lstEducacaoFisica.SelectedIndexChanged += new System.EventHandler(this.lstEducacaoFisica_SelectedIndexChanged);
            // 
            // lstArtes
            // 
            this.lstArtes.FormattingEnabled = true;
            this.lstArtes.Location = new System.Drawing.Point(806, 31);
            this.lstArtes.Name = "lstArtes";
            this.lstArtes.Size = new System.Drawing.Size(53, 329);
            this.lstArtes.TabIndex = 14;
            this.lstArtes.SelectedIndexChanged += new System.EventHandler(this.lstArtes_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(739, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "N7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(818, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "N8";
            // 
            // lstMediaGeral
            // 
            this.lstMediaGeral.FormattingEnabled = true;
            this.lstMediaGeral.Location = new System.Drawing.Point(888, 33);
            this.lstMediaGeral.Name = "lstMediaGeral";
            this.lstMediaGeral.Size = new System.Drawing.Size(144, 329);
            this.lstMediaGeral.TabIndex = 17;
            this.lstMediaGeral.SelectedIndexChanged += new System.EventHandler(this.lstMediaGeral_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(899, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "MEDIA DOS ALUNOS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nome dos Alunos";
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalcularMedia.Location = new System.Drawing.Point(464, 410);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(218, 48);
            this.btnCalcularMedia.TabIndex = 20;
            this.btnCalcularMedia.Text = "Calcular";
            this.btnCalcularMedia.UseVisualStyleBackColor = false;
            this.btnCalcularMedia.Click += new System.EventHandler(this.btnCalcularMedia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1108, 511);
            this.Controls.Add(this.btnCalcularMedia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstMediaGeral);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstArtes);
            this.Controls.Add(this.lstEducacaoFisica);
            this.Controls.Add(this.lstCiencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstIngles);
            this.Controls.Add(this.lstHistoria);
            this.Controls.Add(this.lstGeografia);
            this.Controls.Add(this.lstMatematica);
            this.Controls.Add(this.lstPortugues);
            this.Controls.Add(this.lstAlunos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAlunos;
        private System.Windows.Forms.ListBox lstPortugues;
        private System.Windows.Forms.ListBox lstMatematica;
        private System.Windows.Forms.ListBox lstGeografia;
        private System.Windows.Forms.ListBox lstHistoria;
        private System.Windows.Forms.ListBox lstIngles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstCiencia;
        private System.Windows.Forms.ListBox lstEducacaoFisica;
        private System.Windows.Forms.ListBox lstArtes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstMediaGeral;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCalcularMedia;
    }
}

