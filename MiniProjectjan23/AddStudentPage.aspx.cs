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
    public partial class AddStudentPage : System.Web.UI.Page
    {
        string cn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
            
        {
            if (!IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(cn))
                {


                    using (SqlCommand cmd = new SqlCommand("SelectCourse01", con))


                    {
                        try
                        {
                            con.Open();
                            SqlDataReader dr = cmd.ExecuteReader();

                            List<string> lstdata = new List<string>();
                            while (dr.Read())
                            {
                                lstdata.Add(dr["CourseName"].ToString());
                            }
                            ddlCourse.DataSource = lstdata;
                            ddlCourse.DataBind();
                        }
                        finally
                        {
                            if (con.State == ConnectionState.Open)
                            {
                                con.Close();
                            }

                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SelectCity", con))


                    {
                        try
                        {
                            con.Open();
                            SqlDataReader dr = cmd.ExecuteReader();

                            List<string> lstdata = new List<string>();
                            while (dr.Read())
                            {
                                lstdata.Add(dr["CityName"].ToString());
                            }
                           ddlCity.DataSource = lstdata;
                            ddlCity.DataBind();
                        }
                        finally
                        {
                            if (con.State == ConnectionState.Open)
                            {
                                con.Close();
                            }

                        }
                    }
                }
            }
            
        }
    


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using(SqlConnection con= new SqlConnection(cn))
            {
                //string sname=txtName.Text;
                //String phn = txtphn.Text;
                //string email=txtEmail.Text;
                //string course = ddlCourse.SelectedValue;
                //string city=ddlCity.SelectedValue;
                using (SqlCommand cmd = new SqlCommand("InsertStudent001", con))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter s1 = new SqlParameter("@sname", System.Data.SqlDbType.VarChar, 40);
                    s1.Value = txtName.Text;
                    SqlParameter s2 = new SqlParameter("@phnno", System.Data.SqlDbType.BigInt);
                    s2.Value = txtphn.Text;
                    SqlParameter s3 = new SqlParameter("@email", System.Data.SqlDbType.VarChar, 40);
                    s3.Value = txtEmail.Text;
                    SqlParameter s4 = new SqlParameter("@course", System.Data.SqlDbType.VarChar,40);
                    s4.Value=ddlCourse.SelectedValue;
                    SqlParameter s5 = new SqlParameter("@city", System.Data.SqlDbType.VarChar,40);
                    s5.Value=ddlCity.SelectedValue;

                    cmd.Parameters.Add(s1);
                    cmd.Parameters.Add(s2);
                    cmd.Parameters.Add(s3);
                    cmd.Parameters.Add(s4);
                    cmd.Parameters.Add(s5);


                    try
                    { 
                    con.Open();
                       int  dr= cmd.ExecuteNonQuery();
                        if(dr==1)
                        {
                            Response.Output.WriteLine($"inserted sucessfully");
                        }
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                        { 
                        con.Close();
                        }
                    }
                
                }
            }

        }
    }
}