using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Development_ControlStock_LP
{
    class sisDBADM
    {
        private const string _strCon = "@";
        private string vsql = "";
        SqlConnection objCon = null;

        #region "Metodo de ligação com BD"
        private bool Conectar()
        {
            if(objCon.State != ConnectionState.Closed)
            {
                objCon.Close();
                return true;
            }
            else
            {
                objCon.Dispose();
                return false;

            }
        }

        private bool Disconectar()
        {
            objCon = new SqlConnection(_strCon);
            try
            {
                objCon.Open();
                return true;
            }
            catch
            {
                return false;
            }

        }
        #endregion

        #region "Metodo de Exucução SQL"
        public bool Inserir(/*ArrayList p_arrInserir*/)
        {
            vsql = "INSERT INTO CAMPO VALUES (VALORES);";

            if (this.Conectar())
            {
                try
                {   
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add( new SqlParameter("@NOME", p_arrInserir[0]));
                    objcmd.Parameters.Add(new SqlParameter("@MORADA", p_arrInserir[1]));
                    objcmd.Parameters.Add(new SqlParameter("@CONTATO", p_arrInserir[0]));
                }
                catch (SqlException Sqlerro)
                {
                    throw Sqlerro;

                }
                finally
                {
                    this.Disconectar();
                }
            }
            else
            {
                return false;
            }
        }

        public bool Alterar()
        {
        }

        public bool Eliminar()
        {
        }
        #endregion

        #region "Metodo que listaGrid e faz Pesquisa"
        public DataTable ListaGrid()
        {
        }
        public DataTable Pesquisar()
        {
        }
        #endregion

        internal bool Conectar()
        {
            throw new NotImplementedException();
        }
    }
}
