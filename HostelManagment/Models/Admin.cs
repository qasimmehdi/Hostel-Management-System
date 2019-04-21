using HostelManagement;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HostelManagment.Models
{
    public class Admin
    {
        public int A_ID { get; set; }
        public string A_Name { get; set; }
        public string A_Username { get; set; }
        public string A_Email { get; set; }
        public string A_Password { get; set; }

        public void Add()
        {
            string q = string.Format
                (@"Insert into Admin values('{0}','{1}','{2}','{3}')"
                , A_Name, A_Username, A_Email, A_Password);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public List<Admin> ShowAll()
        {
            string q = "Select * from Admin";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Admin> lst = new List<Admin>();
            while (sdr.Read())
            {
                Admin u = new Admin();
                u.A_ID = (int)sdr["A_ID"];
                u.A_Name = (string)sdr["A_Name"];
                u.A_Username = (string)sdr["A_Username"];
                u.A_Email = (string)sdr["A_Email"];
                u.A_Password = (string)sdr["A_Password"];
                lst.Add(u);
            }
            sdr.Close();
            return lst;
        }


        public List<Admin> Search(int A_ID)
        {
            string q = "Select * from Admin Where A_ID =" + A_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Admin> a = new List<Admin>();
            Admin u = new Admin();
            while (sdr.Read())
            {
                u.A_ID = (int)sdr["A_ID"];
                u.A_Name = (string)sdr["A_Name"];
                u.A_Username = (string)sdr["A_Username"];
                u.A_Email = (string)sdr["A_Email"];
                u.A_Password = (string)sdr["A_Password"];

            }
            sdr.Close();
            a.Add(u);
            return a;
        }

        public void update()
        {
            string q = string.Format(@"Update Admin set   A_Name = '{0}', A_Username = '{1}', A_Email= '{2}'
                                        , A_Password = '{3}'
                                        where A_ID = {4}"
            , A_Name, A_Username, A_Email, A_Password, A_ID);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public void Delete(int A_ID)
        {
            string q = "Delete from Admin where A_ID ='" + A_ID + "'";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public Admin UpItem(int A_ID)
        {
            string q = "Select * from Admin Where A_ID =" + A_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            Admin u = new Admin();
            while (sdr.Read())
            {
                u.A_ID = (int)sdr["A_ID"];
                u.A_Name = (string)sdr["A_Name"];
                u.A_Username = (string)sdr["A_Username"];
                u.A_Email = (string)sdr["A_Email"];
                u.A_Password = (string)sdr["A_Password"];

            }
            sdr.Close();
            return u;
        }
    }
}