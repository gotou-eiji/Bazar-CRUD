using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazarCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtNome.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cadastroPessoa pessoa = new cadastroPessoa();
            List<cadastroPessoa> pessoas = pessoa.listapessoas();
            dgvPessoa.DataSource = pessoas;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                cadastroPessoa pessoa = new cadastroPessoa();
                pessoa.Inserir(txtNome.Text, txtCidade.Text, txtEndereco.Text, txtCelular.Text, txtEmail.Text, txtData.Text);
                MessageBox.Show("Pessoa cadastrada com sucesso!");
                List<cadastroPessoa> pessoas = pessoa.listapessoas();
                dgvPessoa.DataSource = pessoas;
                txtNome.Text = "";
                txtCidade.Text = "";
                txtEndereco.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
                txtData.Text = "";
                txtId.Text = "";
            }
            catch(Exception){
                MessageBox.Show("Insira informações no registro!");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                cadastroPessoa pessoa = new cadastroPessoa();
                pessoa.Atualizar(Id, txtNome.Text, txtCidade.Text, txtEndereco.Text, txtCelular.Text, txtEmail.Text, txtData.Text);
                MessageBox.Show("Pessoa atualizada com sucesso!");
                List<cadastroPessoa> pessoas = pessoa.listapessoas();
                dgvPessoa.DataSource = pessoas;
                txtNome.Text = "";
                txtCidade.Text = "";
                txtEndereco.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
                txtData.Text = "";
                txtId.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Não há usuário listado para atualizar!");
                txtId.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                cadastroPessoa pessoa = new cadastroPessoa();
                pessoa.Excluir(Id);
                MessageBox.Show("Pessoa excluída com sucesso!");
                List<cadastroPessoa> pessoas = pessoa.listapessoas();
                dgvPessoa.DataSource = pessoas;
                txtId.Text = "";
                txtNome.Text = "";
                txtCidade.Text = "";
                txtEndereco.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
                txtData.Text = "";
            }
            catch(Exception)
            {
                MessageBox.Show("Não há usuário listado para deletar!");
                txtId.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Deseja realmente sair?", "Sair da Aplicação", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                cadastroPessoa pessoa = new cadastroPessoa();
                pessoa.Listar(Id);
                txtNome.Text = pessoa.nome;
                txtCidade.Text = pessoa.cidade;
                txtEndereco.Text = pessoa.endereco;
                txtCelular.Text = pessoa.celular;
                txtEmail.Text = pessoa.email;
                txtData.Text = pessoa.data_nascimento;
            }
            catch(Exception)
            {
                MessageBox.Show("Insira um ID para listar!");
                txtId.Focus();
            }
        }
    }
}
