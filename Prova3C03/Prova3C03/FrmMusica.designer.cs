namespace Prova3C03
{
    partial class FrmMusica
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
            this.lblIdMusica = new System.Windows.Forms.Label();
            this.txtIdMusica = new System.Windows.Forms.TextBox();
            this.lblGravadora = new System.Windows.Forms.Label();
            this.lblTituloCD = new System.Windows.Forms.Label();
            this.cmbGravadora = new System.Windows.Forms.ComboBox();
            this.cmbCD = new System.Windows.Forms.ComboBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gridMusicas = new System.Windows.Forms.DataGridView();
            this.lblNomeMusica = new System.Windows.Forms.Label();
            this.txtNomeMusica = new System.Windows.Forms.TextBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.lblNomeAutor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusicas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdMusica
            // 
            this.lblIdMusica.AutoSize = true;
            this.lblIdMusica.Location = new System.Drawing.Point(6, 13);
            this.lblIdMusica.Name = "lblIdMusica";
            this.lblIdMusica.Size = new System.Drawing.Size(73, 13);
            this.lblIdMusica.TabIndex = 0;
            this.lblIdMusica.Text = "ID da Música:";
            // 
            // txtIdMusica
            // 
            this.txtIdMusica.Enabled = false;
            this.txtIdMusica.Location = new System.Drawing.Point(113, 6);
            this.txtIdMusica.Name = "txtIdMusica";
            this.txtIdMusica.Size = new System.Drawing.Size(164, 20);
            this.txtIdMusica.TabIndex = 0;
            // 
            // lblGravadora
            // 
            this.lblGravadora.AutoSize = true;
            this.lblGravadora.Location = new System.Drawing.Point(308, 13);
            this.lblGravadora.Name = "lblGravadora";
            this.lblGravadora.Size = new System.Drawing.Size(60, 13);
            this.lblGravadora.TabIndex = 2;
            this.lblGravadora.Text = "Gravadora:";
            // 
            // lblTituloCD
            // 
            this.lblTituloCD.AutoSize = true;
            this.lblTituloCD.Location = new System.Drawing.Point(308, 40);
            this.lblTituloCD.Name = "lblTituloCD";
            this.lblTituloCD.Size = new System.Drawing.Size(71, 13);
            this.lblTituloCD.TabIndex = 3;
            this.lblTituloCD.Text = "Título do CD:";
            // 
            // cmbGravadora
            // 
            this.cmbGravadora.FormattingEnabled = true;
            this.cmbGravadora.Location = new System.Drawing.Point(415, 5);
            this.cmbGravadora.Name = "cmbGravadora";
            this.cmbGravadora.Size = new System.Drawing.Size(164, 21);
            this.cmbGravadora.TabIndex = 1;
            // 
            // cmbCD
            // 
            this.cmbCD.FormattingEnabled = true;
            this.cmbCD.Location = new System.Drawing.Point(415, 32);
            this.cmbCD.Name = "cmbCD";
            this.cmbCD.Size = new System.Drawing.Size(164, 21);
            this.cmbCD.TabIndex = 2;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGravar.Location = new System.Drawing.Point(7, 275);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(130, 32);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "GRAVAR";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExcluir.Location = new System.Drawing.Point(153, 275);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(133, 32);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpar.Location = new System.Drawing.Point(301, 275);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 32);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSair.Location = new System.Drawing.Point(446, 275);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(133, 32);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gridMusicas
            // 
            this.gridMusicas.BackgroundColor = System.Drawing.Color.White;
            this.gridMusicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMusicas.Location = new System.Drawing.Point(9, 101);
            this.gridMusicas.Name = "gridMusicas";
            this.gridMusicas.Size = new System.Drawing.Size(570, 168);
            this.gridMusicas.TabIndex = 11;
            this.gridMusicas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLivros_CellClick);
            // 
            // lblNomeMusica
            // 
            this.lblNomeMusica.AutoSize = true;
            this.lblNomeMusica.Location = new System.Drawing.Point(6, 43);
            this.lblNomeMusica.Name = "lblNomeMusica";
            this.lblNomeMusica.Size = new System.Drawing.Size(90, 13);
            this.lblNomeMusica.TabIndex = 12;
            this.lblNomeMusica.Text = "Nome da Música:";
            // 
            // txtNomeMusica
            // 
            this.txtNomeMusica.Location = new System.Drawing.Point(113, 40);
            this.txtNomeMusica.Name = "txtNomeMusica";
            this.txtNomeMusica.Size = new System.Drawing.Size(164, 20);
            this.txtNomeMusica.TabIndex = 3;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRelatorio.Location = new System.Drawing.Point(225, 313);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(129, 31);
            this.btnRelatorio.TabIndex = 10;
            this.btnRelatorio.Text = "RELATÓRIO";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(113, 75);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(164, 20);
            this.txtNomeAutor.TabIndex = 6;
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.Location = new System.Drawing.Point(6, 78);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(81, 13);
            this.lblNomeAutor.TabIndex = 17;
            this.lblNomeAutor.Text = "Nome do Autor:";
            // 
            // FrmMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 347);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.lblNomeAutor);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.txtNomeMusica);
            this.Controls.Add(this.lblNomeMusica);
            this.Controls.Add(this.gridMusicas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.cmbCD);
            this.Controls.Add(this.cmbGravadora);
            this.Controls.Add(this.lblTituloCD);
            this.Controls.Add(this.lblGravadora);
            this.Controls.Add(this.txtIdMusica);
            this.Controls.Add(this.lblIdMusica);
            this.Name = "FrmMusica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Músicas";
            this.Load += new System.EventHandler(this.FrmMusica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMusicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdMusica;
        private System.Windows.Forms.TextBox txtIdMusica;
        private System.Windows.Forms.Label lblGravadora;
        private System.Windows.Forms.Label lblTituloCD;
        private System.Windows.Forms.ComboBox cmbGravadora;
        private System.Windows.Forms.ComboBox cmbCD;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView gridMusicas;
        private System.Windows.Forms.Label lblNomeMusica;
        private System.Windows.Forms.TextBox txtNomeMusica;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label lblNomeAutor;
    }
}