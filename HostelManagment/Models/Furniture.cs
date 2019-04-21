using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using HostelManagement;

namespace HostelManagment.Models
{
    public class Furniture
    {
        public int Furniture_ID { get; set; }
        public int Room_ID { get; set; }
        public string Furniture_Type { get; set; }

        public static List<string> ab = new List<string>(3) { "Chair", "Bed", "Sofa" };
        
        
        public void Add()
        {
            string q = string.Format
                (@"Insert into Furniture values({0},'{1}')"
                ,Room_ID,Furniture_ID);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public List<Furniture> ShowAll()
        {
            string q = "Select * from Furniture";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Furniture> lst = new List<Furniture>();
            while (sdr.Read())
            {
                Furniture u = new Furniture();
                u.Furniture_ID = (int)sdr["Furniture_ID"];
                u.Room_ID = (int)sdr["Room_ID"];
                u.Furniture_Type = (string)sdr["Furniture_Type"];
                lst.Add(u);
            }
            sdr.Close();
            return lst;
        }

        public List<Furniture> Search(int Furniture_ID)
        {
            string q = "Select * from Furniture Where Furniture_ID =" + Furniture_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Furniture> a = new List<Furniture>();
            Furniture u = new Furniture();
            while (sdr.Read())
            {
                u.Furniture_ID = (int)sdr["Furniture_ID"];
                u.Room_ID = (int)sdr["Room_ID"];
                u.Furniture_Type = (string)sdr["Furniture_Type"];
            }
            sdr.Close();
            a.Add(u);
            return a;
        }

        public void update()
        {
            string q = string.Format(@"Update Furniture set Room_ID = {0}, Furniture_Type = '{1}'
            where Furniture_ID = {2}"
            , Room_ID, Furniture_Type, Furniture_ID);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public void Delete(int Furniture_ID)
        {
            string q = "Delete from Furniture where Furniture_ID ='" + Furniture_ID + "'";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();

        }

        public Furniture UpItem(int Furniture_ID)
        {
            string q = "Select * from Furniture Where Furniture_ID =" + Furniture_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            Furniture u = new Furniture();
            while (sdr.Read())
            {
                u.Furniture_ID = (int)sdr["Furniture_ID"];
                u.Room_ID = (int)sdr["Room_ID"];
                u.Furniture_Type = (string)sdr["Furniture_Type"];
            }
            sdr.Close();
            return u;
        }
    }
}