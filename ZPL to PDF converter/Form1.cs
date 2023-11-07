using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ZPL_to_PDF_converter.Funcoes;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography.X509Certificates;
using PdfiumViewer;

namespace ZPL_to_PDF_converter
{
    public partial class Form1 : Form
    {
        PdfiumViewer.PdfViewer pdf;
        private bool ArquivoEscolhido = false;
        public string DiretorioEscolhido { get; private set; }
        public string Diretorio { get; private set; }
        public string ZPL {  get; private set; }
        public string TamanhoPagina {  get; private set; }
        public double XLabel {  get; private set; }
        public double Ylabel {  get; private set; }
        public string Densidade { get; private set; }
        public string Copias {  get; private set; }
        public bool cbPDF {  get; private set; }
        public Form1()
        {
            InitializeComponent();
            LbProcessando.Visible = false;
            pdf = pdfViewer1;
            this.Controls.Add(pdf);
            cbPDF = false;
        }

        private GerarEtiquetas gerarEtiquetas = new GerarEtiquetas();

        private void InitializeDataGridView()
        {
            string caminhoPDF = "";
            dataGridView1.Columns[0].DataPropertyName = "Name";

            dataGridView1.Rows.Clear();

            string pasta = Path.Combine(Diretorio, "Etiquetas");

            DirectoryInfo dirinfo = new DirectoryInfo(pasta);

            FileInfo[] arquivoPDF = dirinfo.GetFiles("*.pdf");

            foreach (var arquivo in arquivoPDF)
            {
                dataGridView1.Rows.Add(arquivo.Name);
                caminhoPDF = Path.Combine(Diretorio, "Etiquetas", arquivo.Name);
            }
            dataGridView1.CellClick += DataGridView1_CellClick;

            AbrirPDF(caminhoPDF);
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nomeDoArquivo = dataGridView1.Rows[e.RowIndex].Cells["NomeDoArquivo"].Value.ToString();
                string caminhoDoPDF = Path.Combine(Diretorio, "Etiquetas", nomeDoArquivo);

                // Abra e exiba o PDF selecionado (você pode usar a biblioteca que preferir para visualização de PDF)
                AbrirPDF(caminhoDoPDF);
            }
        }
        private void AbrirPDF(string caminhoDoPDF)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(caminhoDoPDF);
            var stream = new System.IO.MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbZPL.Text == "" || TbZPL.Text is null)
                {
                    MessageBox.Show("Ensira um texto zpl para baixar");
                }
                else
                {
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                    folderBrowserDialog.Description = "Escolha um diretório";
                    folderBrowserDialog.ShowNewFolderButton = true;

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        Diretorio = folderBrowserDialog.SelectedPath;
                        string caminho = Path.Combine(Diretorio, "Etiquetas");

                        if (!Directory.Exists(caminho))
                        {
                            Directory.CreateDirectory(caminho);
                        }
                        else
                        {
                            MessageBox.Show($"Caminho: {caminho}\njá existe, por favor escolha outro diretório!!");
                        }
                    }

                    TamanhoPagina = CbPagina.Text;
                    Densidade = CbDensidade.Text;
                    LbProcessando.Visible = true;
                    Copias = TbCopias.Text;
                    if (CbPDF.Checked)
                    {
                        cbPDF = true;
                    }
                    else
                    {
                        cbPDF = false;
                    }

                    XLabel = Convert.ToDouble(TbX.Text.Replace(".", ","));
                    XLabel = Math.Round(XLabel / 2.54, 2);
                    Ylabel = Convert.ToDouble(TbY.Text.Replace(".", ","));
                    Ylabel = Math.Round(Ylabel / 2.54, 2);

                    ZPL = TbZPL.Text;
                    bool leitura = await gerarEtiquetas.lerArquivoTXT(this);

                    if (leitura)
                    {
                        LbProcessando.Visible = false;
                        InitializeDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }
        
        private void BtDiretorioTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            
            folderBrowser.Title = "Escolha um diretório";
            folderBrowser.Filter = "Arquivos de Texto|*.txt|Todos os arquivos|*.*";

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                DiretorioEscolhido = folderBrowser.FileName;
                string texto = File.ReadAllText(DiretorioEscolhido);
                TbZPL.Text = texto;
                ArquivoEscolhido = true;
            }
        }

        private async void BtVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbZPL.Text == "" || TbZPL.Text is null)
                {
                    MessageBox.Show("Ensira um texto zpl para visualizar");
                }
                else
                {
                    TamanhoPagina = CbPagina.Text;
                    Densidade = CbDensidade.Text;
                    LbProcessando.Visible = true;
                    Copias = TbCopias.Text;
                    if (CbPDF.Checked)
                    {
                        cbPDF = true;
                    }
                    else
                    {
                        cbPDF = false;
                    }

                    XLabel = Convert.ToDouble(TbX.Text.Replace(".", ","));
                    XLabel = Math.Round(XLabel / 2.54, 2);
                    Ylabel = Convert.ToDouble(TbY.Text.Replace(".", ","));
                    Ylabel = Math.Round(Ylabel / 2.54, 2);

                    ZPL = TbZPL.Text;

                    string pathProgram = Directory.GetCurrentDirectory();
                    Diretorio = pathProgram;
                    bool leitura = await gerarEtiquetas.visualizarPDF(this);

                    if (leitura)
                    {
                        LbProcessando.Visible = false;
                        InitializeDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
