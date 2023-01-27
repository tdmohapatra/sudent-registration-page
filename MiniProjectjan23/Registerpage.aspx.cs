using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiniProjectjan23
{

    public partial class Registerpage : System.Web.UI.Page
    {
        string con = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(con))
            {
            using(SqlCommand cmd=new SqlCommand("insertAdmin",cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter s1 = new SqlParameter("@username", System.Data.SqlDbType.VarChar,40);
                    s1.Value = txtUname.Text;
                    SqlParameter s2 = new SqlParameter("@password", System.Data.SqlDbType.VarChar, 40);
                    s2.Value = txtPwd.Text;
                    SqlParameter s3 = new SqlParameter("@email", System.Data.SqlDbType.VarChar, 40);
                    s3.Value = txtEmail.Text;

                    cmd.Parameters.Add(s1);
                    cmd.Parameters.Add(s2);
                    cmd.Parameters.Add(s3);
                    try 
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        Response.Redirect("LoginPage.aspx", true);
                    }
                    finally
                    {
                        if (cn.State == ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }



                }

            }

        }
    }
}