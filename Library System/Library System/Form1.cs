using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Library_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Data Source = DESKTOP - HGTDL39\\SQLEXPRESS2019;Initial Catalog = Library Management System; Integrated Security = True
            InitializeComponent();
            SqlConnection sqlCon = new SqlConnection("Data Source = DESKTOP - HGTDL39\\SQLEXPRESS2019;Initial Catalog = LibraryManagementSystem_db; Integrated Security = True");
            
            if (checkBox1.Checked==true)
            {
               
                SqlDataAdapter da4 = new SqlDataAdapter("spBookCount1", sqlCon);
                da4.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                var arlist4 = new ArrayList();
                foreach (DataRow row in dt4.Rows)
                {

                    arlist4.Add(row["Total"]);

                }
                listBox6.DataSource = arlist4; ;
            }





            
            SqlDataAdapter da3 = new SqlDataAdapter("spBurrowCount2", sqlCon);
            da3.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            var arlist3 = new ArrayList();
            foreach (DataRow row in dt3.Rows)
            {

                arlist3.Add(row["BURROWED"]);

            }
            listBox4.DataSource = arlist3;


            //if (checkBox1.Checked == true)
            //{
            //    SqlDataAdapter da4 = new SqlDataAdapter("spBookCount1", sqlCon);
            //    da4.SelectCommand.CommandType = CommandType.StoredProcedure;
            //    DataTable dt4 = new DataTable();
            //    da4.Fill(dt4);
            //    var arlist4 = new ArrayList();
            //    foreach (DataRow row in dt4.Rows)
            //    {

            //        arlist4.Add(row["Total"]);

            //    }
            //    listBox6.DataSource = arlist4;
            //}

            //else{
            //    checkBox1.Refresh();
                
            //        SqlDataAdapter da5 = new SqlDataAdapter("spAllBookCount4", sqlCon);
            //        da5.SelectCommand.CommandType = CommandType.StoredProcedure;
            //        DataTable dt5 = new DataTable();
            //        da5.Fill(dt5);
            //        var arlist5 = new ArrayList();
            //        foreach (DataRow row in dt5.Rows)
            //        {

            //            arlist5.Add(row["TotalBooks"]);

            //        }
            //        listBox6.DataSource = arlist5;
                
               

            //}

           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_book_Click(object sender, EventArgs e)
        {

            SqlConnection sqlCon = new SqlConnection("Data Source = DESKTOP - HGTDL39\\SQLEXPRESS2019;Initial Catalog = LibraryManagementSystem_db; Integrated Security = True");
            SqlDataAdapter da2 = new SqlDataAdapter("spNumberOfCopies", sqlCon);
            da2.SelectCommand.CommandType = CommandType.StoredProcedure;
            da2.SelectCommand.Parameters.Add(new SqlParameter("@BookTitle", book_name.Text));
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            var arlist2 = new ArrayList();
            foreach (DataRow row in dt2.Rows)
            {

                arlist2.Add(row["copy_count"]);

            }
            listBox1.DataSource = arlist2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cat_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source = DESKTOP - HGTDL39\\SQLEXPRESS2019;Initial Catalog = LibraryManagementSystem_db; Integrated Security = True");
            //DataTable dtbl2 = new DataTable();
            //SqlDataAdapter sqlda2 = new SqlDataAdapter(" SET @book_cate  = " + search_cat.Text + "EXEC spBookCate3", sqlCon);
            //sqlda2.Fill(dtbl2);
            //listBox2.DataSource = dtbl2;

           
            SqlDataAdapter da = new SqlDataAdapter("spBookCate5", sqlCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(new SqlParameter("@book_cat", search_cat.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);
            var arlist = new ArrayList();
            foreach (DataRow row in dt.Rows)
            {

                arlist.Add(row["book_title"]);
                
            }
            listBox2.DataSource = arlist;

        }






        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_auth_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source = DESKTOP - HGTDL39\\SQLEXPRESS2019;Initial Catalog = LibraryManagementSystem_db; Integrated Security = True");
            SqlDataAdapter da1 = new SqlDataAdapter("spBookByAuthor2", sqlCon);
            da1.SelectCommand.CommandType = CommandType.StoredProcedure;
            da1.SelectCommand.Parameters.Add(new SqlParameter("@book_auth", auth.Text));
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            var arlist1 = new ArrayList();
            foreach (DataRow row in dt1.Rows)
            {

                arlist1.Add(row["book_title"]);

            }
            listBox3.DataSource = arlist1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }


        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        
            //Data Source = DESKTOP - HGTDL39\\SQLEXPRESS2019;Initial Catalog = Library Management System; Integrated Security = True
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source = DESKTOP - HGTDL39\\SQLEXPRESS2019;Initial Catalog = LibraryManagementSystem_db; Integrated Security = True");
            switch (checkBox1.CheckState)


            {

                case CheckState.Checked:
              
                    SqlDataAdapter da4 = new SqlDataAdapter("spBookCount1", sqlCon);
                    da4.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dt4 = new DataTable();
                    da4.Fill(dt4);
                    var arlist4 = new ArrayList();
                    foreach (DataRow row in dt4.Rows)
                    {

                        arlist4.Add(row["Total"]);

                    }
                    listBox6.DataSource = arlist4;

                    break;

                case CheckState.Unchecked:

                    
                    SqlDataAdapter da5 = new SqlDataAdapter("spAlBookCount4", sqlCon);
                    da5.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dt5 = new DataTable();
                    da5.Fill(dt5);
                    var arlist5 = new ArrayList();
                    foreach (DataRow row in dt5.Rows)
                    {

                        arlist5.Add(row["TotalBooks"]);

                    }
                    listBox6.DataSource = arlist5;

                    break;
                

            }
        }


        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
