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
    public partial class HomePage : System.Web.UI.Page
    {
        string cn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnhome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx",true);
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx", true);
        }

        protected void btnAddStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddStudentPage.aspx",true);
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            using (SqlConnection con=new SqlConnection(cn))
            {
                using (SqlCommand cmd = new SqlCommand("DISPLAYStudent01", con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        //creating a list to show the student details in grid view
                        List<Student> studentlist = new List<Student>();
                        while (dr.Read())
                        {

                            //creating object for property
                            Student S = new Student();
                            //assign data into object
                            S._sname = dr["StudentName"].ToString();
                            S._phnno = dr["PhnNo"].ToString();

                            S._email = dr["Email"].ToString();

                            S._course = dr["Course"].ToString();

                            S._city = dr["City"].ToString();
                            studentlist.Add(S);
                        }
                        dr.Close();
                        grview.DataSource = studentlist;
                        grview.DataBind();
                        

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
    public class Student
    {
        public string _sname { get; set; }
        public string _phnno{ get; set; } 
        public string _email { get; set; }
        public string _course { get; set; }
        public string _city { get; set; }
    
    
    }
}