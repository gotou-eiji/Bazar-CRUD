namespace BazarCRUD
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvPessoa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(23, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(23, 63);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 1;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(23, 113);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(23, 167);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 5;
            this.lblCelular.Text = "Celular";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 219);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(23, 270);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(104, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data de Nascimento";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(414, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "ID";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(26, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(269, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(26, 79);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(269, 20);
            this.txtCidade.TabIndex = 8;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(26, 183);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(269, 20);
            this.txtCelular.TabIndex = 10;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(26, 129);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(269, 20);
            this.txtEndereco.TabIndex = 9;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(26, 286);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(269, 20);
            this.txtData.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(26, 235);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(417, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(129, 20);
            this.txtId.TabIndex = 13;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Cyan;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.Black;
            this.btnListar.Location = new System.Drawing.Point(584, 12);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(95, 36);
            this.btnListar.TabIndex = 14;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(446, 103);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(95, 36);
            this.btnInserir.TabIndex = 15;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.Blue;
            this.btnAtualizar.Location = new System.Drawing.Point(584, 103);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(95, 36);
            this.btnAtualizar.TabIndex = 16;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(584, 167);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 36);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(446, 167);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 36);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvPessoa
            // 
            this.dgvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoa.Location = new System.Drawing.Point(3, 329);
            this.dgvPessoa.Name = "dgvPessoa";
            this.dgvPessoa.Size = new System.Drawing.Size(734, 257);
            this.dgvPessoa.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 587);
            this.Controls.Add(this.dgvPessoa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bazar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvPessoa;
    }
}

