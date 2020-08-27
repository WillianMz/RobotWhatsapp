namespace zapbot
{
    partial class formPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.ofdImagens = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControle = new System.Windows.Forms.TabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImagem5 = new System.Windows.Forms.Button();
            this.btnImagem4 = new System.Windows.Forms.Button();
            this.btnImagem3 = new System.Windows.Forms.Button();
            this.imgFoto5 = new System.Windows.Forms.PictureBox();
            this.imgFoto4 = new System.Windows.Forms.PictureBox();
            this.imgFoto3 = new System.Windows.Forms.PictureBox();
            this.btnImagem2 = new System.Windows.Forms.Button();
            this.btnImagem1 = new System.Windows.Forms.Button();
            this.imgFoto2 = new System.Windows.Forms.PictureBox();
            this.imgFoto1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.tabContatos = new System.Windows.Forms.TabPage();
            this.btnListas = new System.Windows.Forms.Button();
            this.btnRemoverContato = new System.Windows.Forms.Button();
            this.btnAddContato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListas = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.tabControle.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto1)).BeginInit();
            this.tabContatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListas)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdImagens
            // 
            this.ofdImagens.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControle
            // 
            this.tabControle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControle.Controls.Add(this.tabPrincipal);
            this.tabControle.Controls.Add(this.tabContatos);
            this.tabControle.Location = new System.Drawing.Point(12, 46);
            this.tabControle.Name = "tabControle";
            this.tabControle.SelectedIndex = 0;
            this.tabControle.Size = new System.Drawing.Size(553, 369);
            this.tabControle.TabIndex = 0;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.label3);
            this.tabPrincipal.Controls.Add(this.btnImagem5);
            this.tabPrincipal.Controls.Add(this.btnImagem4);
            this.tabPrincipal.Controls.Add(this.btnImagem3);
            this.tabPrincipal.Controls.Add(this.imgFoto5);
            this.tabPrincipal.Controls.Add(this.imgFoto4);
            this.tabPrincipal.Controls.Add(this.imgFoto3);
            this.tabPrincipal.Controls.Add(this.btnImagem2);
            this.tabPrincipal.Controls.Add(this.btnImagem1);
            this.tabPrincipal.Controls.Add(this.imgFoto2);
            this.tabPrincipal.Controls.Add(this.imgFoto1);
            this.tabPrincipal.Controls.Add(this.label2);
            this.tabPrincipal.Controls.Add(this.txtMsg);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 26);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(545, 339);
            this.tabPrincipal.TabIndex = 1;
            this.tabPrincipal.Text = "Mensagem";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(4, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Selecione as imagens que deseja enviar";
            // 
            // btnImagem5
            // 
            this.btnImagem5.Location = new System.Drawing.Point(432, 308);
            this.btnImagem5.Name = "btnImagem5";
            this.btnImagem5.Size = new System.Drawing.Size(100, 23);
            this.btnImagem5.TabIndex = 48;
            this.btnImagem5.Text = "...";
            this.btnImagem5.UseVisualStyleBackColor = true;
            this.btnImagem5.Click += new System.EventHandler(this.btnImagem5_Click);
            // 
            // btnImagem4
            // 
            this.btnImagem4.Location = new System.Drawing.Point(326, 308);
            this.btnImagem4.Name = "btnImagem4";
            this.btnImagem4.Size = new System.Drawing.Size(100, 23);
            this.btnImagem4.TabIndex = 47;
            this.btnImagem4.Text = "...";
            this.btnImagem4.UseVisualStyleBackColor = true;
            this.btnImagem4.Click += new System.EventHandler(this.btnImagem4_Click);
            // 
            // btnImagem3
            // 
            this.btnImagem3.Location = new System.Drawing.Point(220, 308);
            this.btnImagem3.Name = "btnImagem3";
            this.btnImagem3.Size = new System.Drawing.Size(100, 23);
            this.btnImagem3.TabIndex = 46;
            this.btnImagem3.Text = "...";
            this.btnImagem3.UseVisualStyleBackColor = true;
            this.btnImagem3.Click += new System.EventHandler(this.btnImagem3_Click);
            // 
            // imgFoto5
            // 
            this.imgFoto5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgFoto5.Location = new System.Drawing.Point(432, 202);
            this.imgFoto5.Name = "imgFoto5";
            this.imgFoto5.Size = new System.Drawing.Size(100, 99);
            this.imgFoto5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto5.TabIndex = 53;
            this.imgFoto5.TabStop = false;
            // 
            // imgFoto4
            // 
            this.imgFoto4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgFoto4.Location = new System.Drawing.Point(326, 202);
            this.imgFoto4.Name = "imgFoto4";
            this.imgFoto4.Size = new System.Drawing.Size(100, 99);
            this.imgFoto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto4.TabIndex = 52;
            this.imgFoto4.TabStop = false;
            // 
            // imgFoto3
            // 
            this.imgFoto3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgFoto3.Location = new System.Drawing.Point(220, 202);
            this.imgFoto3.Name = "imgFoto3";
            this.imgFoto3.Size = new System.Drawing.Size(100, 99);
            this.imgFoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto3.TabIndex = 51;
            this.imgFoto3.TabStop = false;
            // 
            // btnImagem2
            // 
            this.btnImagem2.Location = new System.Drawing.Point(114, 308);
            this.btnImagem2.Name = "btnImagem2";
            this.btnImagem2.Size = new System.Drawing.Size(100, 23);
            this.btnImagem2.TabIndex = 45;
            this.btnImagem2.Text = "...";
            this.btnImagem2.UseVisualStyleBackColor = true;
            this.btnImagem2.Click += new System.EventHandler(this.btnImagem2_Click);
            // 
            // btnImagem1
            // 
            this.btnImagem1.Location = new System.Drawing.Point(8, 308);
            this.btnImagem1.Name = "btnImagem1";
            this.btnImagem1.Size = new System.Drawing.Size(100, 23);
            this.btnImagem1.TabIndex = 44;
            this.btnImagem1.Text = "...";
            this.btnImagem1.UseVisualStyleBackColor = true;
            this.btnImagem1.Click += new System.EventHandler(this.btnImagem1_Click);
            // 
            // imgFoto2
            // 
            this.imgFoto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgFoto2.Location = new System.Drawing.Point(114, 202);
            this.imgFoto2.Name = "imgFoto2";
            this.imgFoto2.Size = new System.Drawing.Size(100, 99);
            this.imgFoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto2.TabIndex = 50;
            this.imgFoto2.TabStop = false;
            // 
            // imgFoto1
            // 
            this.imgFoto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgFoto1.Location = new System.Drawing.Point(8, 202);
            this.imgFoto1.Name = "imgFoto1";
            this.imgFoto1.Size = new System.Drawing.Size(100, 99);
            this.imgFoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto1.TabIndex = 49;
            this.imgFoto1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mensagem";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(6, 31);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(526, 137);
            this.txtMsg.TabIndex = 0;
            // 
            // tabContatos
            // 
            this.tabContatos.Controls.Add(this.btnListas);
            this.tabContatos.Controls.Add(this.btnRemoverContato);
            this.tabContatos.Controls.Add(this.btnAddContato);
            this.tabContatos.Controls.Add(this.label1);
            this.tabContatos.Controls.Add(this.dgvListas);
            this.tabContatos.Location = new System.Drawing.Point(4, 26);
            this.tabContatos.Name = "tabContatos";
            this.tabContatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabContatos.Size = new System.Drawing.Size(545, 339);
            this.tabContatos.TabIndex = 2;
            this.tabContatos.Text = "Contatos";
            this.tabContatos.UseVisualStyleBackColor = true;
            // 
            // btnListas
            // 
            this.btnListas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListas.Location = new System.Drawing.Point(286, 6);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(107, 27);
            this.btnListas.TabIndex = 37;
            this.btnListas.Text = "Carregar Listas";
            this.btnListas.UseVisualStyleBackColor = true;
            this.btnListas.Click += new System.EventHandler(this.btnListas_Click);
            // 
            // btnRemoverContato
            // 
            this.btnRemoverContato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverContato.Location = new System.Drawing.Point(469, 6);
            this.btnRemoverContato.Name = "btnRemoverContato";
            this.btnRemoverContato.Size = new System.Drawing.Size(70, 27);
            this.btnRemoverContato.TabIndex = 36;
            this.btnRemoverContato.Text = "Excluir";
            this.btnRemoverContato.UseVisualStyleBackColor = true;
            // 
            // btnAddContato
            // 
            this.btnAddContato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddContato.Location = new System.Drawing.Point(396, 6);
            this.btnAddContato.Name = "btnAddContato";
            this.btnAddContato.Size = new System.Drawing.Size(70, 27);
            this.btnAddContato.TabIndex = 35;
            this.btnAddContato.Text = "Novo";
            this.btnAddContato.UseVisualStyleBackColor = true;
            this.btnAddContato.Click += new System.EventHandler(this.btnAddContato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Contatos";
            // 
            // dgvListas
            // 
            this.dgvListas.AllowUserToAddRows = false;
            this.dgvListas.AllowUserToDeleteRows = false;
            this.dgvListas.AllowUserToResizeRows = false;
            this.dgvListas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListas.BackgroundColor = System.Drawing.Color.White;
            this.dgvListas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListas.ColumnHeadersHeight = 30;
            this.dgvListas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome});
            this.dgvListas.Location = new System.Drawing.Point(6, 39);
            this.dgvListas.MultiSelect = false;
            this.dgvListas.Name = "dgvListas";
            this.dgvListas.ReadOnly = true;
            this.dgvListas.RowHeadersVisible = false;
            this.dgvListas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListas.Size = new System.Drawing.Size(533, 294);
            this.dgvListas.TabIndex = 32;
            // 
            // colID
            // 
            this.colID.FillWeight = 15F;
            this.colID.HeaderText = "Cód.";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 60;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 350;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(577, 41);
            this.pnlTitulo.TabIndex = 30;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Location = new System.Drawing.Point(7, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Envio de Mensagens";
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.button1);
            this.pnlRodape.Controls.Add(this.btnEnviar);
            this.pnlRodape.Controls.Add(this.btnSelecionar);
            this.pnlRodape.Controls.Add(this.lblMensagem);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 421);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(577, 40);
            this.pnlRodape.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(417, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Teste";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Location = new System.Drawing.Point(495, 5);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 30);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(1062, 10);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 22);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.Text = "&Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Visible = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(9, 13);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(48, 17);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Willian";
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 461);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.tabControle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot v1.0 DESENVOLVIMENTO";
            this.tabControle.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto1)).EndInit();
            this.tabContatos.ResumeLayout(false);
            this.tabContatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListas)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdImagens;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControle;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TabPage tabContatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.Button btnRemoverContato;
        private System.Windows.Forms.Button btnAddContato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImagem5;
        private System.Windows.Forms.Button btnImagem4;
        private System.Windows.Forms.Button btnImagem3;
        private System.Windows.Forms.PictureBox imgFoto5;
        private System.Windows.Forms.PictureBox imgFoto4;
        private System.Windows.Forms.PictureBox imgFoto3;
        private System.Windows.Forms.Button btnImagem2;
        private System.Windows.Forms.Button btnImagem1;
        private System.Windows.Forms.PictureBox imgFoto2;
        private System.Windows.Forms.PictureBox imgFoto1;
        private System.Windows.Forms.Button btnListas;
    }
}

