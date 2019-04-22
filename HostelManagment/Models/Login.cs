using HostelManagement;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HostelManagment.Models
{
    public class Login
    {
        public int S_ID { get; set; }
        public string S_Username { get; set; }
        public string S_Email { get; set; }
        public string S_Password { get; set; }


        public static List<Login> ab1 = new List<Login>();

        public bool check()
        {
            bool oo = false;
            SqlCommand a = new SqlCommand("select S_Email,S_Password from Login", Connection.get());
            SqlDataReader ab = a.ExecuteReader();
            while (ab.Read())
            {
                if (ab[0].ToString() == S_Email && ab[1].ToString() == S_Password)
                {
                    oo = true;
                }

            }
            ab.Close();
            return oo;
        }

        public void dropdown1()
        {
            ab1.Clear();
            SqlCommand a = new SqlCommand("select * from Login", Connection.get());
            SqlDataReader aa = a.ExecuteReader();
            while (aa.Read())
            {
                Login ao = new Login() { S_ID = (int)aa[0] };
                ab1.Add(ao);
            }
            aa.Close();
        }
        public void Add()
        {
            string q = string.Format
                (@"Insert into Login values('{0}','{1}','{2}')"
                , S_Username, S_Email, S_Password);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public List<Login> ShowAll()
        {
            string q = "Select * from Login";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Login> lst = new List<Login>();
            while (sdr.Read())
            {
                Login u = new Login();
                u.S_ID = (int)sdr["S_ID"];
                u.S_Username = (string)sdr["S_Username"];
                u.S_Email = (string)sdr["S_Email"];
                u.S_Password = (string)sdr["S_Password"];
                lst.Add(u);
            }
            sdr.Close();
            return lst;
        }


        public List<Login> Search(int S_ID)
        {
            string q = "Select * from Login Where S_ID =" + S_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Login> a = new List<Login>();
            Login u = new Login();
            while (sdr.Read())
            {
                u.S_ID = (int)sdr["S_ID"];
                u.S_Username = (string)sdr["S_Username"];
                u.S_Email = (string)sdr["S_Email"];
                u.S_Password = (string)sdr["S_Password"];

            }
            sdr.Close();
            a.Add(u);
            return a;
        }

        public void update()
        {
            string q = string.Format(@"Update Login set    S_Username = '{0}', S_Email= '{1}'
                                        , S_Password = '{2}'
                                        where S_ID = {3}"
            , S_Username, S_Email, S_Password, S_ID);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public void Delete(int S_ID)
        {
            string q = "Delete from Login where S_ID ='" + S_ID + "'";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public Login UpItem(int S_ID)
        {
            string q = "Select * from Login Where S_ID =" + S_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            Login u = new Login();
            while (sdr.Read())
            {
                u.S_ID = (int)sdr["S_ID"];
                u.S_Username = (string)sdr["S_Username"];
                u.S_Email = (string)sdr["S_Email"];
                u.S_Password = (string)sdr["S_Password"];

            }
            sdr.Close();
            return u;
        }

    }
}