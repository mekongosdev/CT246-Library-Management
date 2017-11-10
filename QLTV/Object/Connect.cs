using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLTV.Object
{
    class Connect
    {

        private SqlConnection conn = new SqlConnection("Server= MYDELL-PC\\SQLEXPRESS; Database=QLTV;User ID = sa; pwd = sa2008;");
        private SqlCommand cmd;

        public Boolean connect(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    conn.Close();
                    return true;
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }


        public DataTable getTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                //doc ra bang 
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);
                conn.Close();
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public Boolean Update(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public void combobox(string sqlcmd, ComboBox cmb, string ma, string ten)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sqlcmd, conn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                cmb.DataSource = ds.Tables[0];
                cmb.DisplayMember = ten;
                cmb.ValueMember = ma;
                conn.Close();
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
        }

        public string getString(string sql)
        {
            string str = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    str = reader[0].ToString();
                }
                conn.Close();
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return str;

        }

        public DataSet getSet(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi !!" + ex);
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }

    }
}
