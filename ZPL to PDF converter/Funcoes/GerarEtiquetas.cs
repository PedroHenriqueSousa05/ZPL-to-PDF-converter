using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.IO;
using ZPL_to_PDF_converter;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ZPL_to_PDF_converter.Funcoes
{
    internal class GerarEtiquetas
    {
        public async Task<bool> lerArquivoTXT(Form1 form1)
        {
            string filePath = form1.DiretorioEscolhido;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/pdf"));
                client.DefaultRequestHeaders.Add("X-Page-Size", $"{form1.TamanhoPagina}");
                client.DefaultRequestHeaders.Add("X-Page-Align", "Center");
                client.DefaultRequestHeaders.Add("X-Page-Vertical-Align", "Center");

                string[] blocks = ExtractBlocks(form1.ZPL, form1);
                    
                int contador = 0;

                Directory.CreateDirectory(form1.Diretorio + "\\Etiquetas");

                foreach (string block in blocks)
                {
                    string outputFilePath = $"{form1.Diretorio}\\Etiquetas\\Etiqueta_{contador}.pdf";
                    contador++;
                    string api = $"http://api.labelary.com/v1/printers/{form1.Densidade}/labels/{form1.XLabel}x{form1.Ylabel}//";
                    string apiUrl = api.Replace(",", ".") + block + " -O label.pdf";
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(apiUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            string contentType = response.Content.Headers.ContentType.MediaType;

                            if (contentType == "application/pdf")
                            {
                                byte[] fileData = await response.Content.ReadAsByteArrayAsync();

                                System.IO.File.WriteAllBytes(outputFilePath, fileData);
                            }
                            else
                            {
                                Console.WriteLine("A resposta da API não é um arquivo PNG ou PDF.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Erro na resposta da API: {response.StatusCode} - {response.ReasonPhrase}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao fazer a solicitação: {ex.Message}");
                    }
                }
            }

            return true;
        }

        public async Task<bool> visualizarPDF(Form1 form1)
        {
            string filePath = form1.DiretorioEscolhido;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/pdf"));
                client.DefaultRequestHeaders.Add("X-Page-Size", $"{form1.TamanhoPagina}");
                client.DefaultRequestHeaders.Add("X-Page-Align", "Center");
                client.DefaultRequestHeaders.Add("X-Page-Vertical-Align", "Center");

                string[] blocks = ExtractBlocks(form1.ZPL, form1);

                int contador = 0;

                Directory.CreateDirectory(form1.Diretorio + "\\Etiquetas");

                string outputFilePath = $"{form1.Diretorio}\\Etiquetas\\Etiqueta_{contador}.pdf";
                contador++;
                string api = $"http://api.labelary.com/v1/printers/{form1.Densidade}/labels/{form1.XLabel}x{form1.Ylabel}//";
                string apiUrl = api.Replace(",", ".") + blocks[0];
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string contentType = response.Content.Headers.ContentType.MediaType;

                        if (contentType == "application/pdf")
                        {
                            byte[] fileData = await response.Content.ReadAsByteArrayAsync();

                            System.IO.File.WriteAllBytes(outputFilePath, fileData);
                        }
                        else
                        {
                            Console.WriteLine("A resposta da API não é um arquivo PNG ou PDF.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Erro na resposta da API: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao fazer a solicitação: {ex.Message}");
                }
                
            }

            return true;
        }
        public static string[] ExtractBlocks(string text, Form1 form1)
        {
            string[] delimiters = { "^XA", "^XZ" };
            string[] blocks = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            blocks = blocks.Where(s => !string.IsNullOrWhiteSpace(s.Trim())).ToArray();

            bool agruparBlocos = form1.cbPDF;

            List<string> blocosAgrupados = new List<string>();
            List<string> blocosIndividuais = new List<string>();

            for (int i = 0; i < blocks.Length; i++)
            {
                if (!blocks[i].Contains("^PQ"))
                {
                    // Se não contiver ^PQ, adicione ^PQ antes do ^XZ
                    blocks[i] = blocks[i] + $"^PQ{form1.Copias},0,1,Y";
                }
                else
                {
                    Match match = Regex.Match(blocks[i], @"\^PQ(\d+),(\d+),(\d+),[A-Z]");
                    if (match.Success)
                    {
                        // Obtém os valores após ^PQ
                        int valor1 = int.Parse(match.Groups[1].Value);
                        int valor2 = int.Parse(match.Groups[2].Value);
                        int valor3 = int.Parse(match.Groups[3].Value);

                        // Faça as alterações desejadas nos valores
                        valor1 = Convert.ToInt32( form1.Copias);
                        valor2 = 0;
                        valor3 = 1;

                        // Substitua os valores no bloco
                        string novoPQ = $"^PQ{valor1},{valor2},{valor3},Y";
                        blocks[i] = Regex.Replace(blocks[i], @"\^PQ(\d+),(\d+),(\d+),[A-Z]", novoPQ);

                    }
                }

                if (agruparBlocos)
                {
                    var e = 19 / Convert.ToInt32(form1.Copias);

                    blocosIndividuais.Add("^XA" + blocks[i] + "^XZ");

                    if (blocosIndividuais.Count == e || i == blocks.Length - 1)
                    {
                        blocosAgrupados.Add(string.Join("", blocosIndividuais));
                        blocosIndividuais.Clear();
                    }
                }
                else
                {
                    blocosAgrupados.Add("^XA" + blocks[i] + "^XZ");
                }
            }

            return blocosAgrupados.ToArray();
        }
    }
}
