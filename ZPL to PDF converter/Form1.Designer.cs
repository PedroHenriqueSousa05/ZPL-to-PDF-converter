namespace ZPL_to_PDF_converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtGerar = new System.Windows.Forms.Button();
            this.BtDiretorioTxt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomeDoArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdfViewer1 = new PdfiumViewer.PdfViewer();
            this.LbProcessando = new System.Windows.Forms.Label();
            this.TbZPL = new System.Windows.Forms.TextBox();
            this.CbPagina = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbCopias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbDensidade = new System.Windows.Forms.ComboBox();
            this.LbDensidade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbY = new System.Windows.Forms.TextBox();
            this.TbX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbPagina = new System.Windows.Forms.Label();
            this.CbPDF = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtVisualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtGerar
            // 
            this.BtGerar.Location = new System.Drawing.Point(230, 435);
            this.BtGerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtGerar.Name = "BtGerar";
            this.BtGerar.Size = new System.Drawing.Size(145, 38);
            this.BtGerar.TabIndex = 0;
            this.BtGerar.Text = "Baixar PDFs";
            this.BtGerar.UseVisualStyleBackColor = true;
            this.BtGerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtDiretorioTxt
            // 
            this.BtDiretorioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BtDiretorioTxt.Location = new System.Drawing.Point(381, 437);
            this.BtDiretorioTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtDiretorioTxt.Name = "BtDiretorioTxt";
            this.BtDiretorioTxt.Size = new System.Drawing.Size(103, 36);
            this.BtDiretorioTxt.TabIndex = 1;
            this.BtDiretorioTxt.Text = "Abrir Arquivo";
            this.BtDiretorioTxt.UseVisualStyleBackColor = true;
            this.BtDiretorioTxt.Click += new System.EventHandler(this.BtDiretorioTxt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeDoArquivo});
            this.dataGridView1.Location = new System.Drawing.Point(512, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(148, 382);
            this.dataGridView1.TabIndex = 8;
            // 
            // NomeDoArquivo
            // 
            this.NomeDoArquivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NomeDoArquivo.HeaderText = "NomeDoArquivo";
            this.NomeDoArquivo.MinimumWidth = 6;
            this.NomeDoArquivo.Name = "NomeDoArquivo";
            this.NomeDoArquivo.ReadOnly = true;
            this.NomeDoArquivo.Width = 137;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.BackColor = System.Drawing.Color.Silver;
            this.pdfViewer1.Location = new System.Drawing.Point(685, 49);
            this.pdfViewer1.Margin = new System.Windows.Forms.Padding(5);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(405, 655);
            this.pdfViewer1.TabIndex = 7;
            // 
            // LbProcessando
            // 
            this.LbProcessando.AutoSize = true;
            this.LbProcessando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProcessando.Location = new System.Drawing.Point(920, 716);
            this.LbProcessando.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbProcessando.Name = "LbProcessando";
            this.LbProcessando.Size = new System.Drawing.Size(156, 25);
            this.LbProcessando.TabIndex = 9;
            this.LbProcessando.Text = "Processando...";
            this.LbProcessando.Visible = false;
            // 
            // TbZPL
            // 
            this.TbZPL.BackColor = System.Drawing.Color.White;
            this.TbZPL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbZPL.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbZPL.Location = new System.Drawing.Point(31, 49);
            this.TbZPL.Margin = new System.Windows.Forms.Padding(4);
            this.TbZPL.Multiline = true;
            this.TbZPL.Name = "TbZPL";
            this.TbZPL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbZPL.Size = new System.Drawing.Size(453, 381);
            this.TbZPL.TabIndex = 10;
            // 
            // CbPagina
            // 
            this.CbPagina.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPagina.FormattingEnabled = true;
            this.CbPagina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CbPagina.Items.AddRange(new object[] {
            "Letter",
            "Legal",
            "A4",
            "A5",
            "A6"});
            this.CbPagina.Location = new System.Drawing.Point(264, 26);
            this.CbPagina.Margin = new System.Windows.Forms.Padding(4);
            this.CbPagina.Name = "CbPagina";
            this.CbPagina.Size = new System.Drawing.Size(97, 24);
            this.CbPagina.TabIndex = 11;
            this.CbPagina.Text = "A4";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.CbPDF);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TbCopias);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CbDensidade);
            this.groupBox1.Controls.Add(this.LbDensidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbY);
            this.groupBox1.Controls.Add(this.TbX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LbPagina);
            this.groupBox1.Controls.Add(this.CbPagina);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(31, 490);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(453, 251);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // TbCopias
            // 
            this.TbCopias.Location = new System.Drawing.Point(264, 150);
            this.TbCopias.Margin = new System.Windows.Forms.Padding(4);
            this.TbCopias.Name = "TbCopias";
            this.TbCopias.Size = new System.Drawing.Size(97, 22);
            this.TbCopias.TabIndex = 21;
            this.TbCopias.Text = "1";
            this.TbCopias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cópias por etiqueta:";
            // 
            // CbDensidade
            // 
            this.CbDensidade.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbDensidade.FormattingEnabled = true;
            this.CbDensidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CbDensidade.Items.AddRange(new object[] {
            "6dpmm",
            "8dpmm",
            "12dpmm",
            "24dpmm"});
            this.CbDensidade.Location = new System.Drawing.Point(264, 108);
            this.CbDensidade.Margin = new System.Windows.Forms.Padding(4);
            this.CbDensidade.Name = "CbDensidade";
            this.CbDensidade.Size = new System.Drawing.Size(97, 24);
            this.CbDensidade.TabIndex = 19;
            this.CbDensidade.Text = "6dpmm";
            // 
            // LbDensidade
            // 
            this.LbDensidade.AutoSize = true;
            this.LbDensidade.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDensidade.Location = new System.Drawing.Point(8, 113);
            this.LbDensidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbDensidade.Name = "LbDensidade";
            this.LbDensidade.Size = new System.Drawing.Size(247, 22);
            this.LbDensidade.TabIndex = 18;
            this.LbDensidade.Text = "Densidade da Impressão:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "cm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "X";
            // 
            // TbY
            // 
            this.TbY.Location = new System.Drawing.Point(351, 66);
            this.TbY.Margin = new System.Windows.Forms.Padding(4);
            this.TbY.Name = "TbY";
            this.TbY.Size = new System.Drawing.Size(60, 22);
            this.TbY.TabIndex = 15;
            this.TbY.Text = "7.5";
            this.TbY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbX
            // 
            this.TbX.Location = new System.Drawing.Point(264, 66);
            this.TbX.Margin = new System.Windows.Forms.Padding(4);
            this.TbX.Name = "TbX";
            this.TbX.Size = new System.Drawing.Size(51, 22);
            this.TbX.TabIndex = 14;
            this.TbX.Text = "10";
            this.TbX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tamanho da Label:";
            // 
            // LbPagina
            // 
            this.LbPagina.AutoSize = true;
            this.LbPagina.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPagina.Location = new System.Drawing.Point(8, 31);
            this.LbPagina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbPagina.Name = "LbPagina";
            this.LbPagina.Size = new System.Drawing.Size(201, 22);
            this.LbPagina.TabIndex = 12;
            this.LbPagina.Text = "Tamanho da Pagina:";
            // 
            // CbPDF
            // 
            this.CbPDF.AutoSize = true;
            this.CbPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPDF.Location = new System.Drawing.Point(264, 192);
            this.CbPDF.Name = "CbPDF";
            this.CbPDF.Size = new System.Drawing.Size(146, 22);
            this.CbPDF.TabIndex = 13;
            this.CbPDF.Text = "Agrupar Etiquetas";
            this.CbPDF.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Gerar pdf Multi Label:";
            // 
            // BtVisualizar
            // 
            this.BtVisualizar.Location = new System.Drawing.Point(31, 437);
            this.BtVisualizar.Name = "BtVisualizar";
            this.BtVisualizar.Size = new System.Drawing.Size(118, 36);
            this.BtVisualizar.TabIndex = 13;
            this.BtVisualizar.Text = "Visualizar";
            this.BtVisualizar.UseVisualStyleBackColor = true;
            this.BtVisualizar.Click += new System.EventHandler(this.BtVisualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1119, 763);
            this.Controls.Add(this.BtVisualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TbZPL);
            this.Controls.Add(this.LbProcessando);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.BtDiretorioTxt);
            this.Controls.Add(this.BtGerar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Gerar Etiquetas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtGerar;
        private System.Windows.Forms.Button BtDiretorioTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PdfiumViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.Label LbProcessando;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoArquivo;
        private System.Windows.Forms.TextBox TbZPL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbPagina;
        private System.Windows.Forms.ComboBox CbPagina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbY;
        private System.Windows.Forms.TextBox TbX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbDensidade;
        private System.Windows.Forms.Label LbDensidade;
        private System.Windows.Forms.TextBox TbCopias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CbPDF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtVisualizar;
    }
}

