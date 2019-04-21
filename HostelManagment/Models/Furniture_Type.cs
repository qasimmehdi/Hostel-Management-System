using HostelManagement;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HostelManagment.Models
{
    public class Furniture_type
    {
        public int Furniture_ID { get; set; }
        public string Furniture_Type { get; set; }

       public static List<Furniture_type> ab = new List<Furniture_type>();
        public void dropdown1()
        {
            ab.Clear();
            SqlCommand a = new SqlCommand("select * from Furniture_Type",Connection.get());
            SqlDataReader aa =a.ExecuteReader();
            while (aa.Read())
            {
                Furniture_type ao = new Furniture_type() {Furniture_ID = (int)aa[0], Furniture_Type = (string)aa[1]};
                ab.Add(ao);
            }
            aa.Close();
            
        }

        public void Add()
        {
            string q = string.Format
                (@"Insert into Furniture_Type values('{0}')"
                , Furniture_Type);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public List<Furniture_type> ShowAll()
        {
            string q = "Select * from Furniture_Type";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Furniture_type> lst = new List<Furniture_type>();
            while (sdr.Read())
            {
                Furniture_type u = new Furniture_type();
                u.Furniture_ID = (int)sdr["Furniture_ID"];
                u.Furniture_Type = (string)sdr["Furniture_Type"];
                lst.Add(u);
            }
            sdr.Close();
            return lst;
        }

        public List<Furniture_type> Search(int Furniture_ID)
        {
            string q = "Select * from Furniture_Type Where Furniture_ID =" + Furniture_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Furniture_type> a = new List<Furniture_type>();
            Furniture_type u = new Furniture_type();
            while (sdr.Read())
            {
                u.Furniture_ID = (int)sdr["Furniture_ID"];
                u.Furniture_Type = (string)sdr["Furniture_Type"];
            }
            sdr.Close();
            a.Add(u);
            return a;
        }

        public void update()
        {
            string q = string.Format(@"Update Furniture_Type set Furniture_Type = '{0}'
            where Furniture_ID = {1}"
            , Furniture_Type, Furniture_ID);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public void Delete(int Furniture_ID)
        {
            string q = "Delete from Furniture_Type where Furniture_ID ='" + Furniture_ID + "'";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();

        }

        public Furniture_type UpItem(int Furniture_ID)
        {
            string q = "Select * from Furniture_Type Where Furniture_ID =" + Furniture_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            Furniture_type u = new Furniture_type();
            while (sdr.Read())
            {
                u.Furniture_ID = (int)sdr["Furniture_ID"];
                u.Furniture_Type = (string)sdr["Furniture_Type"];
            }
            sdr.Close();
            return u;
        }
    }
}