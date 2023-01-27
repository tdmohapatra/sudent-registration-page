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
    public partial class WebForm1 : System.Web.UI.Page
    {
        String cn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con=new  SqlConnection(cn))
            {
                string Uname=txtUname.Text;
                string Pwd=txtpwd.Text;
                string qry = $"select UserName,Password from Admin";
                using (SqlCommand cmd=new SqlCommand(qry,con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader dr= cmd.ExecuteReader();
                        bool x = true;
                        while(dr.Read())
                        {
                            if (dr["UserName"].ToString() == Uname && dr["Password"].ToString() == Pwd)
                            {
                                Response.Redirect("HomePage.aspx",true);

                            }
                            else
                            {
                                x= false;
                            }

                        }
                        if(x==false)
                        {

                            Response.Output.WriteLine($"invalid log in details");
                        }
                    }
                    finally
                    {
                    if(con.State==ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }

                   
                }
            }
            }
    }
}