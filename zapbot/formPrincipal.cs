using botclass;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace zapbot
{
    public partial class formPrincipal : Form
    {        
        public List<Contato> contatos;

        public formPrincipal()
        {
            InitializeComponent();
        }

        private void carregarContatos(List<Contato> cs)
        {
            int cont = 1;

            dgvListas.Rows.Clear();

            foreach (Contato c in cs)
                dgvListas.Rows.Add(cont++, c.nome);


            int qtdLinhas = dgvListas.Rows.Count;
            lblMensagem.Text = qtdLinhas + " Contatos";
        }

        //lista de transmissão do mercado para teste
        private void listaTransmissao()
        {
            try
            {
                contatos = new List<Contato>();

                Contato A = new Contato();
                A.nome = "Lista A";
                contatos.Add(A);


                Contato B = new Contato();
                B.nome = "Lista B";
                contatos.Add(B);


                Contato C = new Contato();
                C.nome = "Lista C";
                contatos.Add(C);


                Contato D = new Contato();
                D.nome = "Lista D";
                contatos.Add(D);


                Contato E = new Contato();
                E.nome = "Lista E";
                contatos.Add(E);


                Contato F = new Contato();
                F.nome = "Lista F";
                contatos.Add(F);


                Contato G = new Contato();
                G.nome = "Lista G";
                contatos.Add(G);


                Contato H = new Contato();
                H.nome = "Lista H";
                contatos.Add(H);


                Contato I = new Contato();
                I.nome = "Lista I";
                contatos.Add(I);


                Contato J = new Contato();
                J.nome = "Lista J";
                contatos.Add(J);


                Contato K = new Contato();
                K.nome = "Lista K";
                contatos.Add(K);


                Contato L = new Contato();
                L.nome = "Lista L";
                contatos.Add(L);


                Contato M = new Contato();
                M.nome = "Lista M";
                contatos.Add(M);


                Contato N = new Contato();
                N.nome = "Lista N";
                contatos.Add(N);


                Contato O = new Contato();
                O.nome = "Lista O";
                contatos.Add(O);


                Contato P = new Contato();
                P.nome = "Lista P";
                contatos.Add(P);


                Contato R = new Contato();
                R.nome = "Lista R";
                contatos.Add(R);


                Contato S = new Contato();
                S.nome = "Lista S";
                contatos.Add(S);

                Contato T = new Contato();
                T.nome = "Lista T";
                contatos.Add(T);


                Contato U = new Contato();
                U.nome = "Lista U";
                contatos.Add(U);


                Contato V = new Contato();
                V.nome = "Lista V";
                contatos.Add(V);


                Contato X = new Contato();
                X.nome = "Lista X Y Z";
                contatos.Add(X);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //teste remover este trecho de codigo
        private void meusContatos()
        {
            try
            {
                contatos = new List<Contato>();

                Contato c = new Contato
                {
                    nome = "Teste Automatizado 1"
                };
                contatos.Add(c);

                Contato d = new Contato
                {
                    nome = "Teste Automatizado 2"
                };
                contatos.Add(d);


                Contato e = new Contato
                {
                    nome = "Teste 1"
                };
                contatos.Add(e);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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

        //private void abrirNavegador()
        //{
        //    Process.Start("https://web.whatsapp.com");
        //}


        //private void teste()
        //{
        //    try
        //    {
        //        timer1.Enabled = true;
        //        int intervalo = 10;
        //        timer1.Interval = intervalo * 1000;               
                
        //    }
        //    catch
        //    {
        //        timer1.Enabled = false;
        //        MessageBox.Show("Erro");
        //    }
        //}


        ////adicionar contatos na datagrid
        //private void adicionarListaContatos(string contato)
        //{            
        //    try
        //    {
        //        dgvListas.Rows.Add(cont++, contato);
        //        lblMensagem.Text = "Novo contato adicionado";
        //    }
        //    catch
        //    {

        //    }
        //}


        private void enviarMensagens(int tempo, List<Contato> contatos)
        {
            Process.Start("https://web.whatsapp.com");

            string mensagem = txtMsg.Text;

            try
            {
                //percorre a lista de contatos
                foreach(Contato c in contatos)
                {
                    Thread.Sleep(tempo);
                    Clipboard.SetText(c.nome);

                    Thread.Sleep(tempo);
                    SendKeys.Send("{TAB}");

                    Thread.Sleep(tempo);
                    SendKeys.Send("^{v}");

                    Thread.Sleep(tempo);
                    Clipboard.SetText(mensagem);

                    Thread.Sleep(tempo);
                    SendKeys.Send("{ENTER}");

                    Thread.Sleep(tempo);
                    SendKeys.Send("^{v}");

                    Thread.Sleep(tempo);
                    SendKeys.Send("{ENTER}");

                    carregarImagens(2000);

                    //SE ESTIVER EM UMA COVERSA ABERTA TERA QUE DAR DOIS TAB PARA SELECIONAR O CAMPO DE UMA NOVA CONVERSA

                    Thread.Sleep(1000);
                    SendKeys.Send("{TAB}");

                    Thread.Sleep(1000);
                    SendKeys.Send("{TAB}");
                }
               
                MessageBox.Show("Processo finalizado com sucesso!", "Enviar Mensagens", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblMensagem.Text = "Mensagens enviadas com sucesso!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar envio.\nMais detalhes: " + ex.Message, "Colar Imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //SE ESTIVER EM UMA COVERSA ABERTA TERA QUE DAR DOIS TAB PARA SELECIONAR O CAMPO DE UMA NOVA CONVERSA

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

        //private void btnEnviar_Click(object sender, EventArgs e)
        //{
        //    teste();
        //}

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


        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Iniciar envio de mensagens? \n ATENÇÃO: Durante o processo de envio de mensagens o computador não poderá ser utilizado!",
                                                "Enviar mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lblMensagem.Text = "aguarde, enviado mensagens...";

                tabControle.Enabled = false;
                btnEnviar.Enabled = false;

                enviarMensagens(3000, contatos);

            }            

        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {
            meusContatos();
            carregarContatos(contatos);
        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Carregando listas";
            listaTransmissao();
            carregarContatos(contatos);
        }
    }
}
