using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Development_ControlStock_LP
{
    public partial class Login : Form
    {
        SqlConnection sqlConn = null;
        private string strConn = @"Data Source=.\SQLEXPRESS;AttachDbFilename="C:\Users\Dário Moreira\Documents\GitHub\LP1213_M17_02\Documentação\Development_ControlStock_LP\Development_ControlStock_LP\Database1.mdf";Integrated Security=True;User Instance=True";
        private string _Sql = string.Empty;

        public bool logado = false;
        public Login()
        {
            InitializeComponent();
        }

        public void logar()
        {
            sqlConn = new SqlConnection(strConn);
            string usu, pwd;

            try
            {
                usu = TB_Utilizador.Text;
                pwd = TB_Senha.Text;

                _Sql = "SELECT COUNT(ID_Utilizador) FROM Nome WHERE Nome = @Nome AND Senha = @Senha";

                SqlCommand cmd = new SqlCommand(_Sql,sqlConn);

                cmd.Parameters.Add("@Nome",SqlDbType.VarChar).Value = usu;
                cmd.Parameters.Add("@Senha",SqlDbType.VarChar).Value = pwd;

                sqlConn.Open();

                int v = (int)cmd.ExecuteScalar();

                if (v > 0)
                {
                    MessageBox.Show("Entrou com Sucesso");
                    logado = true;
                }
                else
                {
                    logado = false;
                    this.Dispose();
                }

            }catch(SqlException erro)
            {
                MessageBox.Show(erro+"Na Base dados");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
