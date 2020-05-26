namespace Autorizador
{
    partial class Autorizador
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabAutorizacao = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblVendas = new System.Windows.Forms.Label();
            this.btnNovaPrescricao = new System.Windows.Forms.Button();
            this.btnConfirmarItem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumeroCR = new System.Windows.Forms.Label();
            this.cbTipoCR = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInfoMedico = new System.Windows.Forms.Label();
            this.txtDataPrescricao = new System.Windows.Forms.TextBox();
            this.lblDataPrescricao = new System.Windows.Forms.Label();
            this.lblPrescricao = new System.Windows.Forms.Label();
            this.dataGridAutorizador = new System.Windows.Forms.DataGridView();
            this.textProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboUsoContinuo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabAutorizacao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutorizador)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(808, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabAutorizacao
            // 
            this.tabAutorizacao.Controls.Add(this.tabPage1);
            this.tabAutorizacao.Controls.Add(this.tabReport);
            this.tabAutorizacao.Controls.Add(this.tabPage3);
            this.tabAutorizacao.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabAutorizacao.Location = new System.Drawing.Point(0, 27);
            this.tabAutorizacao.Name = "tabAutorizacao";
            this.tabAutorizacao.SelectedIndex = 0;
            this.tabAutorizacao.ShowToolTips = true;
            this.tabAutorizacao.Size = new System.Drawing.Size(800, 404);
            this.tabAutorizacao.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblVendas);
            this.tabPage1.Controls.Add(this.btnNovaPrescricao);
            this.tabPage1.Controls.Add(this.btnConfirmarItem);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.lblNumeroCR);
            this.tabPage1.Controls.Add(this.cbTipoCR);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblInfoMedico);
            this.tabPage1.Controls.Add(this.txtDataPrescricao);
            this.tabPage1.Controls.Add(this.lblDataPrescricao);
            this.tabPage1.Controls.Add(this.lblPrescricao);
            this.tabPage1.Controls.Add(this.dataGridAutorizador);
            this.tabPage1.Controls.Add(this.textProduto);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textEan);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textQuantidade);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboUsoContinuo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Autorização";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Location = new System.Drawing.Point(8, 119);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(46, 13);
            this.lblVendas.TabIndex = 19;
            this.lblVendas.Text = "Vendas:";
            // 
            // btnNovaPrescricao
            // 
            this.btnNovaPrescricao.Location = new System.Drawing.Point(623, 78);
            this.btnNovaPrescricao.Name = "btnNovaPrescricao";
            this.btnNovaPrescricao.Size = new System.Drawing.Size(146, 23);
            this.btnNovaPrescricao.TabIndex = 18;
            this.btnNovaPrescricao.Text = "Nova Prescrição";
            this.btnNovaPrescricao.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarItem
            // 
            this.btnConfirmarItem.Location = new System.Drawing.Point(519, 77);
            this.btnConfirmarItem.Name = "btnConfirmarItem";
            this.btnConfirmarItem.Size = new System.Drawing.Size(98, 23);
            this.btnConfirmarItem.TabIndex = 17;
            this.btnConfirmarItem.Text = "Confirmar Item";
            this.btnConfirmarItem.UseVisualStyleBackColor = true;
            this.btnConfirmarItem.Click += new System.EventHandler(this.btnConfirmarItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(393, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // lblNumeroCR
            // 
            this.lblNumeroCR.AutoSize = true;
            this.lblNumeroCR.Location = new System.Drawing.Point(322, 80);
            this.lblNumeroCR.Name = "lblNumeroCR";
            this.lblNumeroCR.Size = new System.Drawing.Size(65, 13);
            this.lblNumeroCR.TabIndex = 15;
            this.lblNumeroCR.Text = "Numero CR:";
            // 
            // cbTipoCR
            // 
            this.cbTipoCR.FormattingEnabled = true;
            this.cbTipoCR.Items.AddRange(new object[] {
            "CRM",
            "CRO"});
            this.cbTipoCR.Location = new System.Drawing.Point(270, 77);
            this.cbTipoCR.Name = "cbTipoCR";
            this.cbTipoCR.Size = new System.Drawing.Size(46, 21);
            this.cbTipoCR.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tipo:";
            // 
            // lblInfoMedico
            // 
            this.lblInfoMedico.AutoSize = true;
            this.lblInfoMedico.Location = new System.Drawing.Point(322, 57);
            this.lblInfoMedico.Name = "lblInfoMedico";
            this.lblInfoMedico.Size = new System.Drawing.Size(117, 13);
            this.lblInfoMedico.TabIndex = 12;
            this.lblInfoMedico.Text = "Dados madico/dentista";
            // 
            // txtDataPrescricao
            // 
            this.txtDataPrescricao.Location = new System.Drawing.Point(113, 77);
            this.txtDataPrescricao.Name = "txtDataPrescricao";
            this.txtDataPrescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDataPrescricao.TabIndex = 11;
            // 
            // lblDataPrescricao
            // 
            this.lblDataPrescricao.AutoSize = true;
            this.lblDataPrescricao.Location = new System.Drawing.Point(8, 80);
            this.lblDataPrescricao.Name = "lblDataPrescricao";
            this.lblDataPrescricao.Size = new System.Drawing.Size(99, 13);
            this.lblDataPrescricao.TabIndex = 10;
            this.lblDataPrescricao.Text = "Data da Prescrção:";
            // 
            // lblPrescricao
            // 
            this.lblPrescricao.AutoSize = true;
            this.lblPrescricao.Location = new System.Drawing.Point(8, 57);
            this.lblPrescricao.Name = "lblPrescricao";
            this.lblPrescricao.Size = new System.Drawing.Size(105, 13);
            this.lblPrescricao.TabIndex = 9;
            this.lblPrescricao.Text = "Dados da prescrição";
            // 
            // dataGridAutorizador
            // 
            this.dataGridAutorizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAutorizador.Location = new System.Drawing.Point(3, 135);
            this.dataGridAutorizador.Name = "dataGridAutorizador";
            this.dataGridAutorizador.Size = new System.Drawing.Size(783, 81);
            this.dataGridAutorizador.TabIndex = 8;
            // 
            // textProduto
            // 
            this.textProduto.Location = new System.Drawing.Point(569, 21);
            this.textProduto.Name = "textProduto";
            this.textProduto.Size = new System.Drawing.Size(200, 20);
            this.textProduto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Produto:";
            // 
            // textEan
            // 
            this.textEan.Location = new System.Drawing.Point(310, 21);
            this.textEan.Name = "textEan";
            this.textEan.Size = new System.Drawing.Size(200, 20);
            this.textEan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "EAN Produto:";
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(194, 21);
            this.textQuantidade.MaxLength = 2;
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(30, 20);
            this.textQuantidade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade:";
            // 
            // comboUsoContinuo
            // 
            this.comboUsoContinuo.FormattingEnabled = true;
            this.comboUsoContinuo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.comboUsoContinuo.Location = new System.Drawing.Point(87, 21);
            this.comboUsoContinuo.Name = "comboUsoContinuo";
            this.comboUsoContinuo.Size = new System.Drawing.Size(30, 21);
            this.comboUsoContinuo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uso continuo:";
            // 
            // tabReport
            // 
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(792, 378);
            this.tabReport.TabIndex = 1;
            this.tabReport.Text = "Report";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Informações";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Autorizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 456);
            this.Controls.Add(this.tabAutorizacao);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Autorizador";
            this.Text = "Autorizador Saude Nova";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabAutorizacao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutorizador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabAutorizacao;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboUsoContinuo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textEan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.TextBox textProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridAutorizador;
        private System.Windows.Forms.Label lblPrescricao;
        private System.Windows.Forms.ComboBox cbTipoCR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInfoMedico;
        private System.Windows.Forms.TextBox txtDataPrescricao;
        private System.Windows.Forms.Label lblDataPrescricao;
        private System.Windows.Forms.Button btnNovaPrescricao;
        private System.Windows.Forms.Button btnConfirmarItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNumeroCR;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

