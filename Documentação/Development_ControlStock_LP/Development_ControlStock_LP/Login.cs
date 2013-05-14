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
        private string strConn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True";
        private string _Sql = string.Empty;

        public bool logado = false;
        public Login()
        {
            InitializeComponent();
        }

        public bool logar()
        {
            sqlConn = new SqlConnection(strConn);
            string usu, pwd;

            try
            {
                usu = TB_Utilizador.Text;
                pwd = TB_Senha.Text;

                _Sql = "SELECT COUNT(ID_Utilizador) FROM TB_Utilizador WHERE Nome = @Nome AND Senha = @Senha";

                SqlCommand cmd = new SqlCommand(_Sql,sqlConn);

                cmd.Parameters.Add("@Nome",SqlDbType.VarChar).Value = usu;
                cmd.Parameters.Add("@Senha",SqlDbType.VarChar).Value = pwd;

                sqlConn.Open();

                int v = (int) cmd.ExecuteScalar();

                if (v > 0)
                {                  
                    logado = true;
                }
                else
                {
                    logado = false;                        
                }

            }catch(SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }

            return logado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (logar())
            {
                Bem_Vindo frm = new Bem_Vindo();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Acesso não permitido");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TB_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logar();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
