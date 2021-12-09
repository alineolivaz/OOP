namespace Prova3C03
{
    partial class FrmRelatorio
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
            this.lblSelecione = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.gridMusicas = new System.Windows.Forms.DataGridView();
            this.cmbCD = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusicas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Location = new System.Drawing.Point(81, 13);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(92, 13);
            this.lblSelecione.TabIndex = 1;
            this.lblSelecione.Text = "Selecione um CD:";
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExibir.Location = new System.Drawing.Point(352, 4);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(109, 30);
            this.btnExibir.TabIndex = 2;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // gridMusicas
            // 
            this.gridMusicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMusicas.Location = new System.Drawing.Point(12, 40);
            this.gridMusicas.Name = "gridMusicas";
            this.gridMusicas.Size = new System.Drawing.Size(528, 235);
            this.gridMusicas.TabIndex = 3;
            // 
            // cmbCD
            // 
            this.cmbCD.FormattingEnabled = true;
            this.cmbCD.Location = new System.Drawing.Point(189, 10);
            this.cmbCD.Name = "cmbCD";
            this.cmbCD.Size = new System.Drawing.Size(157, 21);
            this.cmbCD.TabIndex = 4;
            this.cmbCD.SelectedIndexChanged += new System.EventHandler(this.cmbCD_SelectedIndexChanged);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 287);
            this.Controls.Add(this.cmbCD);
            this.Controls.Add(this.gridMusicas);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.lblSelecione);
            this.Name = "FrmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Músicas";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMusicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.DataGridView gridMusicas;
        private System.Windows.Forms.ComboBox cmbCD;
    }
}