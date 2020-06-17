using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zapbot
{
    public partial class formPrincipal : Form
    {
        //[DllImport("user32.dll")]
        //static extern IntPtr GetForegroundWindow();

        public formPrincipal()
        {
            InitializeComponent();
        }

        private void adicionarImagem(PictureBox pbIMG)
        {
            try
            {
                OpenFileDialog imagem = new OpenFileDialog();
                imagem.Filter = "jpg|*.jpg";

                if (imagem.ShowDialog() == DialogResult.OK)
                {
                    FileInfo arq = new FileInfo(imagem.FileName);

                    //testa se tem menos de 1MB (1MB em bytes = 1048576)
                    if (arq.Length <= 1048576)
                        pbIMG.ImageLocation = imagem.FileName;
                    else
                        MessageBox.Show("O tamanho da imagem não pode exceder 1MB!", "Tamanho inválido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro ao procurar Imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //envia para a area de tranferencia do windows
            //Clipboard.SetText("ENVIANDO TEXTO A AREA DE TRANFERENCIA DO WINDOWS");
            //Clipboard.SetImage(pbIMG_1.Image);
            //tesss();
            processarEnvioWhats("Teste Automatizado");
        }


        private void teste()
        {
            try
            {
                timer1.Enabled = true;
                int intervalo = 10;
                timer1.Interval = intervalo * 1000;               
                
            }
            catch
            {
                timer1.Enabled = false;
                MessageBox.Show("Erro");
            }
        }

        private void processarEnvioWhats(string contato)
        {
            try
            {
                Thread.Sleep(5000);
                Clipboard.SetText(contato);
                
                Thread.Sleep(5000);
                SendKeys.Send("{TAB}");
                
                Thread.Sleep(5000);
                SendKeys.Send("^{v}");
                
                Thread.Sleep(5000);
                Clipboard.SetText("Inicianado testes automatizados......");
                
                Thread.Sleep(5000);
                SendKeys.Send("{ENTER}");
                
                Thread.Sleep(5000);
                SendKeys.Send("^{v}");
                
                Thread.Sleep(5000);
                SendKeys.Send("{ENTER}");

                if((imgFoto1.ImageLocation != "") | (imgFoto2.ImageLocation != ""))
                {
                    Clipboard.SetImage(imgFoto1.Image);
                    Thread.Sleep(5000);
                    SendKeys.Send("^{v}");
                    Thread.Sleep(5000);
                    SendKeys.Send("{ENTER}");

                    Thread.Sleep(5000);
                    Clipboard.SetImage(imgFoto2.Image);
                    Thread.Sleep(5000);
                    SendKeys.Send("^{v}");
                    Thread.Sleep(5000);
                    SendKeys.Send("{ENTER}");
                }       
                Application.Exit();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void carregarImagens(int tempo)
        {
            try
            {
                if (imgFoto1.ImageLocation != "")
                {
                    Clipboard.SetImage(imgFoto1.Image);
                    Thread.Sleep(tempo);
                    SendKeys.Send("^{v}");
                    Thread.Sleep(tempo);
                    SendKeys.Send("{ENTER}");
                }
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            processarEnvioWhats("Teste Automatizado");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            teste();
        }

        private void btnImagem1_Click(object sender, EventArgs e)
        {
            adicionarImagem(imgFoto1);
        }

        private void btnImagem2_Click(object sender, EventArgs e)
        {
            adicionarImagem(imgFoto2);
        }

        private void btnImagem3_Click(object sender, EventArgs e)
        {
            adicionarImagem(imgFoto3);
        }

        private void btnImagem4_Click(object sender, EventArgs e)
        {
            adicionarImagem(imgFoto4);
        }

        private void btnImagem5_Click(object sender, EventArgs e)
        {
            adicionarImagem(imgFoto5);
        }

        private void btnImagem6_Click(object sender, EventArgs e)
        {
            adicionarImagem(imgFoto6);
        }

        private void btnImagem7_Click(object sender, EventArgs e)
        {
            adicionarImagem(imgFoto7);
        }

        private void btnImagem8_Click(object sender, EventArgs e)
        {
            adicionarImagem(imgFoto8);
        }

        private void btnImagem9_Click(object sender, EventArgs e)
        {
            adicionarImagem(imgFoto9);
        }

        private void btnImagem10_Click(object sender, EventArgs e)
        {
            adicionarImagem(imgFoto10);
        }
    }
}
