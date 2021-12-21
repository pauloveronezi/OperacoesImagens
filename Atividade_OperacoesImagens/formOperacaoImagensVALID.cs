using Atividade_OperacoesImagens.Componentes;
using FreeImageAPI;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Atividade_OperacoesImagens
{
    public partial class formOperacoesImagensVALID : Form
    {
        private readonly string _localArquivos = "C:/Temp/";

        public formOperacoesImagensVALID()
        {
            InitializeComponent();
        }

        private void btnOpenFileA_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Image Files|*.bmp;*.wsq";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtFileA.Text = openFile.FileName;
                }
                catch (Exception ex)
                {
                    txtFileA.Text = $"Erro ao abrir o arquivo. Erro: {ex}";
                }
            }
        }

        private void btnOpenFileB_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Image Files|*.bmp;*.wsq";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtFileB.Text = openFile.FileName;
                }
                catch (Exception ex)
                {
                    txtFileB.Text = $"Erro ao abrir o arquivo. Erro: {ex}";
                }
            }
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            SelectOperation();
        }

        private void SelectOperation()
        {
            var _radioButton = gbOperacoes.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);

            switch (_radioButton.Text)
            {
                case "Conversão entre WSQ para BMP":
                    ConvertFileWSQtoBMP();
                    break;

                case "Conversão entre BMP para WSQ":
                    ConvertFileBMPtoWSQ();
                    break;

                case "Match entre duas digitais em WSQ":
                    MatchTwoFilesWSQ();
                    break;

                case "Cálculo da qualidade de uma digital":
                    QualityFile();
                    break;

                case "Recortar digital (512x512)":
                    CutFingerFile();
                    break;

                case "Gerar imagem com texto":
                    GenerateImageText();
                    break;
            }
        }

        private void ConvertFileWSQtoBMP()
        {
            //try
            //{
            //    var _arquivo = new StreamReader(txtFileA.Text);
            //    var _arquivoBytes = default(byte[]);

            //    using (var _memoria = new MemoryStream())
            //    {
            //        _arquivo.BaseStream.CopyTo(_memoria);
            //        _arquivoBytes = _memoria.ToArray();
            //    }

            //    var _arquivoConvertido = Wsq.FromWsqToBitmap(_arquivoBytes);

            //    var _arquivoSave = $"{_localArquivos}WSQtoBMP{DateTime.Now:ddMMyyyyhhmmss}.bmp";
            //    _arquivoConvertido.Save(_arquivoSave, ImageFormat.Bmp);

            //    txtFileResult.Text = $"Arquivo processado com sucesso! Local: {_arquivoSave}";
            //}
            //catch (Exception ex)
            //{
            //    txtFileResult.Text = $"Erro ao converter o arquivo. Erro: {ex}";
            //}
        }

        private void ConvertFileBMPtoWSQ()
        {
            //try
            //{
            //    var _arquivo = new StreamReader(txtFileA.Text);
            //    var _arquivoBytes = default(byte[]);

            //    using (var _memoria = new MemoryStream())
            //    {
            //        _arquivo.BaseStream.CopyTo(_memoria);
            //        _arquivoBytes = _memoria.ToArray();
            //    }

            //    Bitmap _imagem;

            //    using (var _memoria = new MemoryStream(_arquivoBytes))
            //    {
            //        _imagem = new Bitmap(_memoria);
            //    }

            //    var _minuciaImagem = DetectMinutiae.FromBitmap(_imagem, 500);
            //    var _arquivoConvertido = Wsq.FromBitmapToWsq(_imagem, (float)0.75, 500, "Teste"); //75% é o padrão para compressão do arquivo

            //    var _arquivoSave = $"{_localArquivos}BMPtoWSQ{DateTime.Now:ddMMyyyyhhmmss}.wsq";

            //    using (var _fileStream = File.Create(_arquivoSave))
            //    {
            //        _fileStream.Write(_arquivoConvertido, 0, _arquivoConvertido.Length);
            //    }

            //    txtFileResult.Text = $"Arquivo processado com sucesso! Local: {_arquivoSave}";
            //}
            //catch (Exception ex)
            //{
            //    txtFileResult.Text = $"Erro ao converter o arquivo. Erro: {ex}";
            //}
        }

        private void MatchTwoFilesWSQ()
        {
            //try
            //{
            //    //arquivo A
            //    var _arquivoA = new StreamReader(txtFileA.Text);
            //    var _arquivoABytes = default(byte[]);

            //    using (var _memoria = new MemoryStream())
            //    {
            //        _arquivoA.BaseStream.CopyTo(_memoria);
            //        _arquivoABytes = _memoria.ToArray();
            //    }

            //    var _arquivoAConvertido = Wsq.FromWsqToBitmap(_arquivoABytes);

            //    //arquivo B
            //    var _arquivoB = new StreamReader(txtFileB.Text);
            //    var _arquivoBBytes = default(byte[]);

            //    using (var _memoria = new MemoryStream())
            //    {
            //        _arquivoB.BaseStream.CopyTo(_memoria);
            //        _arquivoBBytes = _memoria.ToArray();
            //    }

            //    var _arquivoBConvertido = Wsq.FromWsqToBitmap(_arquivoBBytes);

            //    //analisando...
            //    var _minuciaImagemA = DetectMinutiae.FromBitmap(_arquivoAConvertido, 500);
            //    var _minuciaImagemB = DetectMinutiae.FromBitmap(_arquivoBConvertido, 500);

            //    var _score = Matcher.Compare(_minuciaImagemA, _minuciaImagemB);

            //    txtFileResult.Text = _score < 30 ? "NÃO MATCH!" : "MATCH!";
            //}
            //catch (Exception ex)
            //{
            //    txtFileResult.Text = $"Erro ao analisar os arquivos. Erro: {ex}";
            //}
        }

        private void QualityFile()
        {
            //try
            //{
            //    var _arquivo = new StreamReader(txtFileA.Text);
            //    var _arquivoBytes = default(byte[]);

            //    using (var _memoria = new MemoryStream())
            //    {
            //        _arquivo.BaseStream.CopyTo(_memoria);
            //        _arquivoBytes = _memoria.ToArray();
            //    }

            //    if (txtFileA.Text.EndsWith(".bmp"))
            //    {
            //        Bitmap _imagem;

            //        using (var _memoria = new MemoryStream(_arquivoBytes))
            //        {
            //            _imagem = new Bitmap(_memoria);
            //        }

            //        var _qualidade = Nfiq.FromBitmap(_imagem, 500);

            //        txtFileResult.Text = $"Qualidade: {_qualidade}";
            //    }
            //    else
            //    {
            //        var _qualidade = Nfiq.FromWsq(_arquivoBytes);

            //        txtFileResult.Text = $"Qualidade: {_qualidade}";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    txtFileResult.Text = $"Erro ao analisar os arquivos. Erro: {ex}";
            //}
        }

        private void CutFingerFile()
        {
            try
            {
                #region Convertendo o arquivo WSQ para Bitmap

                var _arquivo = new StreamReader(txtFileA.Text);
                var _arquivoBytes = default(byte[]);

                using (var _memoria = new MemoryStream())
                {
                    _arquivo.BaseStream.CopyTo(_memoria);
                    _arquivoBytes = _memoria.ToArray();
                }

                var _digitalByteArray = ConversoesImagem.WSQParaByteArray(_arquivoBytes, ImageFormat.Bmp);

                Bitmap _arquivoConvertido;

                using (var _memoria = new MemoryStream(_digitalByteArray))
                {
                    _arquivoConvertido = new Bitmap(_memoria);
                }

                #endregion

                // só realizo o recorte em imagens originais - essa cláusula não deixam imagens já recortadas serem recortadas novamente
                if (_arquivoConvertido.Size.Width > 512 && _arquivoConvertido.Size.Height > 512)
                {
                    #region Calculando posição para recorte da imagem

                    var _imagemNova = default(Bitmap);
                    Graphics _graphics = null;
                    var _sizeImageRes = new Size(512, 512);
                    var _posicaoInicial = default(Point);
                    var _posicaoFinal = default(Point);

                    _arquivoConvertido.SetResolution(512, 512);

                    _imagemNova = new Bitmap(512, 512, PixelFormat.Format24bppRgb); //estava com: Format24bppRgb
                    _imagemNova.SetResolution(512, 512);
                    _graphics = Graphics.FromImage(_imagemNova);
                    _graphics.Clear(Color.White);
                    _graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    CalcularPosicao(_arquivoConvertido.Size, _sizeImageRes, ref _posicaoInicial, ref _posicaoFinal);

                    var _retangulo = new Rectangle(_posicaoInicial.X, _posicaoInicial.Y, _sizeImageRes.Width, _sizeImageRes.Height);
                    _graphics.DrawImage(_arquivoConvertido, _posicaoFinal.X, _posicaoFinal.Y, _retangulo, GraphicsUnit.Pixel);
                    _imagemNova.SetResolution(512, 512);

                    #endregion

                    #region Convertendo a imagem de BMP para WSQ

                    var _arquivoConvertidoWSQ = ConversoesImagem.ImagemParaWSQ(_imagemNova);

                    var _arquivoSaveWSQ = $"{_localArquivos}RecorteDigital/RecorteDigitalWSQ{DateTime.Now:ddMMyyyyhhmmss}.wsq";

                    using (var _fileStream = File.Create(_arquivoSaveWSQ))
                    {
                        _fileStream.Write(_arquivoConvertidoWSQ, 0, _arquivoConvertidoWSQ.Length);
                    }

                    #endregion
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GenerateImageText(string _text = "NÃO ALFABETIZADO", int _largura = 550, int _altura = 117)
        {
            Graphics g = null;
            Bitmap _bmp = null;
            byte[] teste = null;

            try
            {
                _bmp = new Bitmap(_largura, _altura);
                g = Graphics.FromImage(_bmp);
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, _largura, _altura));
                Font ft = new Font("Tahoma", 36, FontStyle.Bold);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                Rectangle r = new Rectangle(0, 0, _bmp.Width, ft.Height * 2);
                g.DrawString(_text, ft, Brushes.Red, r, sf);
                g.DrawImage(_bmp, 0, 0);

                var _arquivoSave = $"{_localArquivos}NaoAlfabetizado{DateTime.Now:ddMMyyyyhhmmss}.bmp";
                _bmp.Save(_arquivoSave, ImageFormat.Bmp);

                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    _bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    teste = ms.ToArray();
                }

                var _arquivoSaveTXT = $"{_localArquivos}Menor7Anos{DateTime.Now:ddMMyyyyhhmmss}.png";

                using (var _fileStream = File.Create(_arquivoSaveTXT))
                {
                    _fileStream.Write(teste, 0, teste.Length);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private byte[] ConvertToGrayScale(Bitmap imagem)
        {
            byte[] ret = null;
            try
            {
                ImageConverter imageConverter = new ImageConverter();
                using (MemoryStream ms = new MemoryStream((byte[])imageConverter.ConvertTo((object)imagem, typeof(byte[]))))
                {
                    var fingerprintDib = FreeImage.LoadFromStream(ms);
                    var fingerprint8bppDib = FreeImage.ConvertTo8Bits(fingerprintDib);
                    using (MemoryStream ms2 = new MemoryStream())
                    {
                        FreeImage.SaveToStream(fingerprint8bppDib, ms2, FREE_IMAGE_FORMAT.FIF_BMP);
                        ret = ms2.ToArray();
                    }
                    FreeImage.Unload(fingerprintDib);
                    FreeImage.Unload(fingerprint8bppDib);
                }
                imageConverter = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        private static void CalcularPosicao(Size tamOriginal, Size tamFinal, ref Point posOrigemRecorte, ref Point posFinalRecorte)
        {
            try
            {
                //Calculando o X
                if (tamOriginal.Width <= tamFinal.Width)
                {
                    posOrigemRecorte.X = 0;
                    posFinalRecorte.X = (tamFinal.Width - tamOriginal.Width) / 2;
                }
                else
                {
                    posOrigemRecorte.X = (tamOriginal.Width - tamFinal.Width) / 2;
                    posFinalRecorte.X = 0;
                }

                //Calculando o Y
                posOrigemRecorte.Y = (tamOriginal.Height <= tamFinal.Height) ? 0 : (tamFinal.Height / 5) * 2;
                posFinalRecorte.Y = (tamOriginal.Height <= tamFinal.Height) ? (tamFinal.Height / 5) * 2 : 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
        }
    }
}
