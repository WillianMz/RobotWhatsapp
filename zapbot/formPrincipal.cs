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

        private void abrirNavegador()
        {
            Process.Start("https://web.whatsapp.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            string mensagem = txtMsg.Text;

            try
            {
                Thread.Sleep(5000);
                Clipboard.SetText(contato);
                
                Thread.Sleep(5000);
                SendKeys.Send("{TAB}");
                
                Thread.Sleep(5000);
                SendKeys.Send("^{v}");
                
                Thread.Sleep(5000);
                Clipboard.SetText(mensagem);
                
                Thread.Sleep(5000);
                SendKeys.Send("{ENTER}");
                
                Thread.Sleep(5000);
                SendKeys.Send("^{v}");
                
                Thread.Sleep(5000);
                SendKeys.Send("{ENTER}");

                carregarImagens(2000);

                //Application.Exit();
                //return;

                MessageBox.Show("Processo finalizado com sucesso!", "Enviar Mensagens", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar envio.\nMais detalhes: " + ex.Message, "Colar Imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregarImagens(int tempo)
        {
            try
            { 

                if (imgFoto1.Image != null)
                {
                    Clipboard.SetImage(imgFoto1.Image);
                    Thread.Sleep(tempo);
                    SendKeys.Send("^{v}");
                    Thread.Sleep(tempo);
                    SendKeys.Send("{ENTER}");
                }

                Thread.Sleep(2000);

                if (imgFoto2.Image != null)
                {
                    Clipboard.SetImage(imgFoto2.Image);
                    Thread.Sleep(tempo);
                    SendKeys.Send("^{v}");
                    Thread.Sleep(tempo);
                    SendKeys.Send("{ENTER}");
                }

                Thread.Sleep(2000);

                if (imgFoto3.Image != null)
                {
                    Clipboard.SetImage(imgFoto3.Image);
                    Thread.Sleep(tempo);
                    SendKeys.Send("^{v}");
                    Thread.Sleep(tempo);
                    SendKeys.Send("{ENTER}");
                }

                Thread.Sleep(2000);

                if (imgFoto4.Image != null)
                {
                    Clipboard.SetImage(imgFoto4.Image);
                    Thread.Sleep(tempo);
                    SendKeys.Send("^{v}");
                    Thread.Sleep(tempo);
                    SendKeys.Send("{ENTER}");
                }

                Thread.Sleep(2000);

                if (imgFoto5.Image != null)
                {
                    Clipboard.SetImage(imgFoto5.Image);
                    Thread.Sleep(tempo);
                    SendKeys.Send("^{v}");
                    Thread.Sleep(tempo);
                    SendKeys.Send("{ENTER}");
                }

                Thread.Sleep(2000);

                if (imgFoto6.Image != null)
                {
                    Clipboard.SetImage(imgFoto6.Image);
                    Thread.Sleep(tempo);
                    SendKeys.Send("^{v}");
                    Thread.Sleep(tempo);
                    SendKeys.Send("{ENTER}");
                }

                Thread.Sleep(2000);

                if (imgFoto7.Image != null)
                {
                    Clipboard.SetImage(imgFoto7.Image);
                    Thread.Sleep(tempo);
                    SendKeys.Send("^{v}");
                    Thread.Sleep(tempo);
                    SendKeys.Send("{ENTER}");
                }

                Thread.Sleep(2000);

                if (imgFoto8.Image != null)
                {
                    Clipboard.SetImage(imgFoto8.Image);
                    Thread.Sleep(tempo);
                    SendKeys.Send("^{v}");
                    Thread.Sleep(tempo);
                    SendKeys.Send("{ENTER}");
                }

                Thread.Sleep(2000);

                if (imgFoto9.Image != null)
                {
                    Clipboard.SetImage(imgFoto9.Image);
                    Thread.Sleep(tempo);
                    SendKeys.Send("^{v}");
                    Thread.Sleep(tempo);
                    SendKeys.Send("{ENTER}");
                }

                Thread.Sleep(2000);

                if (imgFoto10.Image != null)
                {
                    Clipboard.SetImage(imgFoto10.Image);
                    Thread.Sleep(tempo);
                    SendKeys.Send("^{v}");
                    Thread.Sleep(tempo);
                    SendKeys.Send("{ENTER}");
                }

                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar imagem.\nMais detalhes: " + ex.Message, "Colar Imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            abrirNavegador();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {            
            try
            {
                //teste();
                processarEnvioWhats("Teste Automatizado");
            }
            catch
            {

            }
            finally
            {
                //Application.Exit();
            }
        }
    }
}
