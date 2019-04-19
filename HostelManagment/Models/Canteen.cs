using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using HostelManagement;

namespace HostelManagment.Models
{
    public class Canteen
    {
        public int Canteen_MGR { get; set; }
        public int Canteen_Expenses { get; set; }
        public string Time_O { get; set; }
        public string Time_C { get; set; }

        public void Add()
        {
            string q = string.Format
                (@"Insert into Canteen values({0},{1},'{2}','{3}')"
                , Canteen_MGR,Canteen_Expenses,Time_O, Time_C);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public List<Canteen> ShowAll()
        {
            string q = "Select * from Canteen";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Canteen> lst = new List<Canteen>();
            while (sdr.Read())
            {
                Canteen u = new Canteen();
                u.Canteen_MGR = (int)sdr["Canteen_MGR"];
                u.Canteen_Expenses = (int)sdr["Canteen_Expenses"];
                u.Time_O = (string)sdr["Time_O"];
                u.Time_C = (string)sdr["Time_C"];
                lst.Add(u);
            }
            sdr.Close();
            return lst;
        }

        public List<Canteen> Search(int Canteen_MGR)
        {
            string q = "Select * from Canteen Where Canteen_MGR =" + Canteen_MGR;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Canteen> a = new List<Canteen>();
            Canteen u = new Canteen();
            while (sdr.Read())
            {
                u.Canteen_MGR = (int)sdr["Canteen_MGR"];
                u.Canteen_Expenses = (int)sdr["Canteen_Expenses"];
                u.Time_O = (string)sdr["Time_O"];
                u.Time_C = (string)sdr["Time_C"];
            }
            sdr.Close();
            a.Add(u);
            return a;
        }

        public void update()
        {
            string q = string.Format(@"Update Canteen set Canteen_MGR = {0},Canteen_Expenses = {1},
            Time_O = '{2}', Time_C = '{3}' 
            where Canteen_MGR = {4}"
            , Canteen_MGR, Canteen_Expenses, Time_O, Time_C,Canteen_MGR);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public void Delete(int Canteen_MGR)
        {
            string q = "Delete from Canteen where Canteen_MGR ='" + Canteen_MGR + "'";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();

        }

        public Canteen UpItem(int Canteen_MGR)
        {
            string q = "Select * from Canteen Where Canteen_MGR =" + Canteen_MGR;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            Canteen u = new Canteen();
            while (sdr.Read())
            {
                u.Canteen_MGR = (int)sdr["Canteen_MGR"];
                u.Canteen_Expenses = (int)sdr["Canteen_Expenses"];
                u.Time_O = (string)sdr["Time_O"];
                u.Time_C = (string)sdr["Time_C"];
            }
            sdr.Close();
            return u;
        }
    }
}