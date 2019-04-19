using HostelManagement;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HostelManagment.Models
{
    public class S_Allocation
    {
        public int Allocation_ID { get; set; }
        public int S_ID { get; set; }
        public int Room_ID { get; set; }
        public string Start_Date { get; set; }
        public string End_Date { get; set; }

        public void Add()
        {
            string q = string.Format
                (@"Insert into S_Allocation values({0},{1},'{2}','{3}')"
                ,S_ID,Room_ID,Start_Date,End_Date);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public List<S_Allocation> ShowAll()
        {
            string q = "Select * from S_Allocation";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<S_Allocation> lst = new List<S_Allocation>();
            while (sdr.Read())
            {
                S_Allocation u = new S_Allocation();
                u.Allocation_ID = (int)sdr["Allocation_ID"];
                u.S_ID = (int)sdr["S_ID"];
                u.Room_ID = (int)sdr["Room_ID"];
                u.Start_Date = (string)sdr["Start_Date"];
                u.End_Date = (string)sdr["End_Date"];
                lst.Add(u);
            }
            sdr.Close();
            return lst;
        }


        public List<S_Allocation> Search(int Allocation_ID)
        {
            string q = "Select * from S_Allocation Where Allocation_ID =" + Allocation_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<S_Allocation> a = new List<S_Allocation>();
            S_Allocation u = new S_Allocation();
            while (sdr.Read())
            {
                u.Allocation_ID = (int)sdr["Allocation_ID"];
                u.S_ID = (int)sdr["S_ID"];
                u.Room_ID = (int)sdr["Room_ID"];
                u.Start_Date = (string)sdr["Start_Date"];
                u.End_Date = (string)sdr["End_Date"];

            }
            sdr.Close();
            a.Add(u);
            return a;
        }

        public void update()
        {
            string q = string.Format(@"Update S_Allocation set   S_ID = {0}, Room_ID = {1}, Start_Date= '{2}'
                                        , End_Date = '{3}'
                                        where Allocation_ID = {4}"
            , S_ID, Room_ID, Start_Date, End_Date,Allocation_ID);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public void Delete(int Allocation_ID)
        {
            string q = "Delete from S_Allocation where Allocation_ID ='" + Allocation_ID + "'";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public S_Allocation UpItem(int Allocation_ID)
        {
            string q = "Select * from S_Allocation Where Allocation_ID =" + Allocation_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            S_Allocation u = new S_Allocation();
            while (sdr.Read())
            {
                u.Allocation_ID = (int)sdr["Allocation_ID"];
                u.S_ID = (int)sdr["S_ID"];
                u.Room_ID = (int)sdr["Room_ID"];
                u.Start_Date = (string)sdr["Start_Date"];
                u.End_Date = (string)sdr["End_Date"];

            }
            sdr.Close();
            return u;
        }

    }
}