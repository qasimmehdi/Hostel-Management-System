using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using HostelManagement;

namespace HostelManagment.Models
{
    public class Visitor
    {
        public string CNIC { get; set; }
        public int S_ID { get; set; }
        public string Visitor_Name { get; set; }
        public int Times_Visited { get; set; }

        public void Add()
        {
            string q = string.Format
                (@"Insert into Visitor values('{0}',{1},'{2}',{3})"
                ,CNIC, S_ID, Visitor_Name, Times_Visited);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public List<Visitor> ShowAll()
        {
            string q = "Select * from Visitor";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Visitor> lst = new List<Visitor>();
            while (sdr.Read())
            {
                Visitor u = new Visitor();
                u.CNIC = (string)sdr["CNIC"];
                u.S_ID = (int)sdr["S_ID"];
                u.Visitor_Name = (string)sdr["Visitor_Name"];
                u.Times_Visited = (int)sdr["Times_Visited"];
                lst.Add(u);
            }
            sdr.Close();
            return lst;
        }

        public List<Visitor> Search(string CNIC)
        {
            string q = "Select * from Visitor Where CNIC =" + CNIC;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Visitor> a = new List<Visitor>();
            Visitor u = new Visitor();
            while (sdr.Read())
            {
                u.CNIC = (string)sdr["CNIC"];
                u.S_ID = (int)sdr["S_ID"];
                u.Visitor_Name = (string)sdr["Visitor_Name"];
                u.Times_Visited = (int)sdr["Times_Visited"];
            }
            sdr.Close();
            a.Add(u);
            return a;
        }

        public void update()
        {
            string q = string.Format(@"Update Visitor set S_ID = {0}, Visitor_Name = '{1}',Times_Visited = {2}
            where CNIC = {3}"
            , S_ID, Visitor_Name, Times_Visited, CNIC);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public void Delete(string CNIC)
        {
            string q = "Delete from Visitor where CNIC ='" + CNIC + "'";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();

        }

        public Visitor UpItem(string CNIC)
        {
            string q = "Select * from Visitor Where CNIC =" + CNIC;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            Visitor u = new Visitor();
            while (sdr.Read())
            {
                u.CNIC = (string)sdr["CNIC"];
                u.S_ID = (int)sdr["S_ID"];
                u.Visitor_Name = (string)sdr["Visitor_Name"];
                u.Times_Visited = (int)sdr["Times_Visited"];
            }
            sdr.Close();
            return u;
        }
    }
}