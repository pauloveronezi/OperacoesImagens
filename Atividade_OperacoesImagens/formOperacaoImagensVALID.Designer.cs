
namespace Atividade_OperacoesImagens
{
    partial class formOperacoesImagensVALID
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOperacoes = new System.Windows.Forms.GroupBox();
            this.rbGerarImagem = new System.Windows.Forms.RadioButton();
            this.rbRecortarDigital = new System.Windows.Forms.RadioButton();
            this.rbQualidadeDigital = new System.Windows.Forms.RadioButton();
            this.rbMatchWSQ = new System.Windows.Forms.RadioButton();
            this.rbBMPtoWSQ = new System.Windows.Forms.RadioButton();
            this.rbWSQtoBMP = new System.Windows.Forms.RadioButton();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.gbFileA = new System.Windows.Forms.GroupBox();
            this.txtFileA = new System.Windows.Forms.TextBox();
            this.btnOpenFileA = new System.Windows.Forms.Button();
            this.gbFileB = new System.Windows.Forms.GroupBox();
            this.txtFileB = new System.Windows.Forms.TextBox();
            this.btnOpenFileB = new System.Windows.Forms.Button();
            this.gbFileResult = new System.Windows.Forms.GroupBox();
            this.txtFileResult = new System.Windows.Forms.TextBox();
            this.btnOperation = new System.Windows.Forms.Button();
            this.gbArquivos = new System.Windows.Forms.GroupBox();
            this.gbOperacoes.SuspendLayout();
            this.gbFileA.SuspendLayout();
            this.gbFileB.SuspendLayout();
            this.gbFileResult.SuspendLayout();
            this.gbArquivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOperacoes
            // 
            this.gbOperacoes.Controls.Add(this.rbGerarImagem);
            this.gbOperacoes.Controls.Add(this.rbRecortarDigital);
            this.gbOperacoes.Controls.Add(this.rbQualidadeDigital);
            this.gbOperacoes.Controls.Add(this.rbMatchWSQ);
            this.gbOperacoes.Controls.Add(this.rbBMPtoWSQ);
            this.gbOperacoes.Controls.Add(this.rbWSQtoBMP);
            this.gbOperacoes.Location = new System.Drawing.Point(12, 12);
            this.gbOperacoes.Name = "gbOperacoes";
            this.gbOperacoes.Size = new System.Drawing.Size(564, 125);
            this.gbOperacoes.TabIndex = 0;
            this.gbOperacoes.TabStop = false;
            this.gbOperacoes.Text = "Operações:";
            // 
            // rbGerarImagem
            // 
            this.rbGerarImagem.AutoSize = true;
            this.rbGerarImagem.Location = new System.Drawing.Point(276, 47);
            this.rbGerarImagem.Name = "rbGerarImagem";
            this.rbGerarImagem.Size = new System.Drawing.Size(157, 19);
            this.rbGerarImagem.TabIndex = 2;
            this.rbGerarImagem.Text = "Gerar imagem com texto";
            this.rbGerarImagem.UseVisualStyleBackColor = true;
            // 
            // rbRecortarDigital
            // 
            this.rbRecortarDigital.AutoSize = true;
            this.rbRecortarDigital.Location = new System.Drawing.Point(276, 22);
            this.rbRecortarDigital.Name = "rbRecortarDigital";
            this.rbRecortarDigital.Size = new System.Drawing.Size(158, 19);
            this.rbRecortarDigital.TabIndex = 1;
            this.rbRecortarDigital.Text = "Recortar digital (512x512)";
            this.rbRecortarDigital.UseVisualStyleBackColor = true;
            // 
            // rbQualidadeDigital
            // 
            this.rbQualidadeDigital.AutoSize = true;
            this.rbQualidadeDigital.Location = new System.Drawing.Point(6, 97);
            this.rbQualidadeDigital.Name = "rbQualidadeDigital";
            this.rbQualidadeDigital.Size = new System.Drawing.Size(215, 19);
            this.rbQualidadeDigital.TabIndex = 0;
            this.rbQualidadeDigital.Text = "Cálculo da qualidade de uma digital";
            this.rbQualidadeDigital.UseVisualStyleBackColor = true;
            // 
            // rbMatchWSQ
            // 
            this.rbMatchWSQ.AutoSize = true;
            this.rbMatchWSQ.Location = new System.Drawing.Point(6, 72);
            this.rbMatchWSQ.Name = "rbMatchWSQ";
            this.rbMatchWSQ.Size = new System.Drawing.Size(207, 19);
            this.rbMatchWSQ.TabIndex = 0;
            this.rbMatchWSQ.Text = "Match entre duas digitais em WSQ";
            this.rbMatchWSQ.UseVisualStyleBackColor = true;
            // 
            // rbBMPtoWSQ
            // 
            this.rbBMPtoWSQ.AutoSize = true;
            this.rbBMPtoWSQ.Location = new System.Drawing.Point(6, 47);
            this.rbBMPtoWSQ.Name = "rbBMPtoWSQ";
            this.rbBMPtoWSQ.Size = new System.Drawing.Size(194, 19);
            this.rbBMPtoWSQ.TabIndex = 0;
            this.rbBMPtoWSQ.Text = "Conversão entre BMP para WSQ";
            this.rbBMPtoWSQ.UseVisualStyleBackColor = true;
            // 
            // rbWSQtoBMP
            // 
            this.rbWSQtoBMP.AutoSize = true;
            this.rbWSQtoBMP.Checked = true;
            this.rbWSQtoBMP.Location = new System.Drawing.Point(6, 22);
            this.rbWSQtoBMP.Name = "rbWSQtoBMP";
            this.rbWSQtoBMP.Size = new System.Drawing.Size(194, 19);
            this.rbWSQtoBMP.TabIndex = 0;
            this.rbWSQtoBMP.TabStop = true;
            this.rbWSQtoBMP.Text = "Conversão entre WSQ para BMP";
            this.rbWSQtoBMP.UseVisualStyleBackColor = true;
            // 
            // gbFileA
            // 
            this.gbFileA.Controls.Add(this.txtFileA);
            this.gbFileA.Controls.Add(this.btnOpenFileA);
            this.gbFileA.Location = new System.Drawing.Point(6, 22);
            this.gbFileA.Name = "gbFileA";
            this.gbFileA.Size = new System.Drawing.Size(551, 57);
            this.gbFileA.TabIndex = 1;
            this.gbFileA.TabStop = false;
            this.gbFileA.Text = "Arquivo \"A\" (Prioritário)";
            // 
            // txtFileA
            // 
            this.txtFileA.Location = new System.Drawing.Point(6, 22);
            this.txtFileA.Name = "txtFileA";
            this.txtFileA.ReadOnly = true;
            this.txtFileA.Size = new System.Drawing.Size(458, 23);
            this.txtFileA.TabIndex = 3;
            // 
            // btnOpenFileA
            // 
            this.btnOpenFileA.Location = new System.Drawing.Point(470, 22);
            this.btnOpenFileA.Name = "btnOpenFileA";
            this.btnOpenFileA.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFileA.TabIndex = 2;
            this.btnOpenFileA.Text = "Abrir...";
            this.btnOpenFileA.UseVisualStyleBackColor = true;
            this.btnOpenFileA.Click += new System.EventHandler(this.btnOpenFileA_Click);
            // 
            // gbFileB
            // 
            this.gbFileB.Controls.Add(this.txtFileB);
            this.gbFileB.Controls.Add(this.btnOpenFileB);
            this.gbFileB.Location = new System.Drawing.Point(6, 85);
            this.gbFileB.Name = "gbFileB";
            this.gbFileB.Size = new System.Drawing.Size(551, 57);
            this.gbFileB.TabIndex = 1;
            this.gbFileB.TabStop = false;
            this.gbFileB.Text = "Arquivo \"B\"";
            // 
            // txtFileB
            // 
            this.txtFileB.Location = new System.Drawing.Point(6, 22);
            this.txtFileB.Name = "txtFileB";
            this.txtFileB.ReadOnly = true;
            this.txtFileB.Size = new System.Drawing.Size(458, 23);
            this.txtFileB.TabIndex = 3;
            // 
            // btnOpenFileB
            // 
            this.btnOpenFileB.Location = new System.Drawing.Point(470, 22);
            this.btnOpenFileB.Name = "btnOpenFileB";
            this.btnOpenFileB.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFileB.TabIndex = 2;
            this.btnOpenFileB.Text = "Abrir...";
            this.btnOpenFileB.UseVisualStyleBackColor = true;
            this.btnOpenFileB.Click += new System.EventHandler(this.btnOpenFileB_Click);
            // 
            // gbFileResult
            // 
            this.gbFileResult.Controls.Add(this.txtFileResult);
            this.gbFileResult.Location = new System.Drawing.Point(12, 327);
            this.gbFileResult.Name = "gbFileResult";
            this.gbFileResult.Size = new System.Drawing.Size(564, 56);
            this.gbFileResult.TabIndex = 1;
            this.gbFileResult.TabStop = false;
            this.gbFileResult.Text = "Resultado";
            // 
            // txtFileResult
            // 
            this.txtFileResult.Location = new System.Drawing.Point(6, 22);
            this.txtFileResult.Name = "txtFileResult";
            this.txtFileResult.ReadOnly = true;
            this.txtFileResult.Size = new System.Drawing.Size(552, 23);
            this.txtFileResult.TabIndex = 3;
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(211, 298);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(138, 23);
            this.btnOperation.TabIndex = 2;
            this.btnOperation.Text = "Realizar operação...";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // gbArquivos
            // 
            this.gbArquivos.Controls.Add(this.gbFileA);
            this.gbArquivos.Controls.Add(this.gbFileB);
            this.gbArquivos.Location = new System.Drawing.Point(12, 143);
            this.gbArquivos.Name = "gbArquivos";
            this.gbArquivos.Size = new System.Drawing.Size(564, 149);
            this.gbArquivos.TabIndex = 3;
            this.gbArquivos.TabStop = false;
            this.gbArquivos.Text = "Arquivos";
            // 
            // formOperacoesImagensVALID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 391);
            this.Controls.Add(this.gbArquivos);
            this.Controls.Add(this.gbFileResult);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.gbOperacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formOperacoesImagensVALID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operações com Imagens";
            this.gbOperacoes.ResumeLayout(false);
            this.gbOperacoes.PerformLayout();
            this.gbFileA.ResumeLayout(false);
            this.gbFileA.PerformLayout();
            this.gbFileB.ResumeLayout(false);
            this.gbFileB.PerformLayout();
            this.gbFileResult.ResumeLayout(false);
            this.gbFileResult.PerformLayout();
            this.gbArquivos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOperacoes;
        private System.Windows.Forms.RadioButton rbWSQtoBMP;
        private System.Windows.Forms.RadioButton rbQualidadeDigital;
        private System.Windows.Forms.RadioButton rbMatchWSQ;
        private System.Windows.Forms.RadioButton rbBMPtoWSQ;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.GroupBox gbFileA;
        private System.Windows.Forms.TextBox txtFileA;
        private System.Windows.Forms.Button btnOpenFileA;
        private System.Windows.Forms.GroupBox gbFileB;
        private System.Windows.Forms.TextBox txtFileB;
        private System.Windows.Forms.Button btnOpenFileB;
        private System.Windows.Forms.GroupBox gbFileResult;
        private System.Windows.Forms.TextBox txtFileResult;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.GroupBox gbArquivos;
        private System.Windows.Forms.RadioButton rbRecortarDigital;
        private System.Windows.Forms.RadioButton rbGerarImagem;
    }
}

