using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BazarCRUD
{
    class cadastroPessoa
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string cidade { get; set; }
        public string endereco { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string data_nascimento { get; set; }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Senai CTM\BazarCRUD\BazarCRUD\BazarCRUD\PessoaDB.mdf"";Integrated Security=True");

        public List<cadastroPessoa> listapessoas()
        {
            List<cadastroPessoa> li = new List<cadastroPessoa>();
            string sql = "SELECT * FROM Pessoa";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cadastroPessoa p = new cadastroPessoa();
                p.Id = (int)dr["Id"];
                p.nome = dr["nome"].ToString();
                p.cidade = dr["cidade"].ToString();
                p.endereco = dr["endereco"].ToString();
                p.celular = dr["celular"].ToString();
                p.email = dr["email"].ToString();
                p.data_nascimento = dr["data_nascimento"].ToString();
                li.Add(p);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void Inserir(string nome, string cidade, string endereco, string celular, string email, string data_nascimento)
        {
            string sql = "INSERT INTO Pessoa(nome,cidade,endereco,celular,email,data_nascimento) VALUES ('" + nome + "','" + cidade + "','" + endereco + "','" + celular + "','" + email + "','" + data_nascimento + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Atualizar(int Id, string nome, string cidade, string endereco, string celular, string email, string data_nascimento)
        {
            string sql = "UPDATE Pessoa SET nome='" + nome + "',cidade='" + cidade + "',endereco='" + endereco + "',celular='" + celular + "',email='" + email + "',data_nascimento='" + data_nascimento + "' WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Excluir(int Id)
        {
            string sql = "DELETE FROM Pessoa WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Listar(int Id)
        {
            string sql = "SELECT * FROM Pessoa WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                cidade = dr["cidade"].ToString();
                endereco = dr["endereco"].ToString();
                celular = dr["celular"].ToString();
                email = dr["email"].ToString();
                data_nascimento = dr["data_nascimento"].ToString();
            }
            dr.Close();
            con.Close();
        }
    }
}