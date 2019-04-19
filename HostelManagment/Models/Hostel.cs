using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using HostelManagement;

namespace HostelManagment.Models
{
    public class Hostel
    {
        public int Building_ID { get; set; }
        public int Total_Rooms { get; set; }
        public int Students_Residing { get; set; }
        public int Annual_Expenses { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Building_Name { get; set; }

        public void Add()
        {
            string q = string.Format
                (@"Insert into Hostel values({0},{1},{2},'{3}','{4}','{5}')"
                , Total_Rooms,Students_Residing,Annual_Expenses,Address,City,Building_Name);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public List<Hostel> ShowAll()
        {
            string q = "Select * from Hostel";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Hostel> lst = new List<Hostel>();
            while (sdr.Read())
            {
                Hostel u = new Hostel();
                u.Building_ID = (int)sdr["Building_ID"];
                u.Students_Residing = (int)sdr["Students_Residing"];
                u.Students_Residing = (int)sdr["Students_Residing"];
                u.Annual_Expenses = (int)sdr["Annual_Expenses"];
                u.Address = (string)sdr["Address"];
                u.City = (string)sdr["City"];
                u.Building_Name = (string)sdr["Building_Name"];
                lst.Add(u);
            }
            sdr.Close();
            return lst;
        }


        public List<Hostel> Search(int Building_ID)
        {
            string q = "Select * from Hostel Where Building_ID =" + Building_ID;
            SqlCommand sc = new SqlCommand(q,Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Hostel> a = new List<Hostel>();
            Hostel u = new Hostel();
            while (sdr.Read())
            {
                u.Building_ID = (int)sdr["Building_ID"];
                u.Students_Residing = (int)sdr["Students_Residing"];
                u.Students_Residing = (int)sdr["Students_Residing"];
                u.Annual_Expenses = (int)sdr["Annual_Expenses"];
                u.Address = (string)sdr["Address"];
                u.City = (string)sdr["City"];
                u.Building_Name = (string)sdr["Building_Name"];
                
            }
            sdr.Close();
            a.Add(u);
            return a;
        }

        public void update()
        {
            string q = string.Format(@"Update Hostel set Total_Rooms = {0},Students_Residing = {1},Annual_Expenses = {2},
            Address = '{3}',City = '{4}', Building_Name = '{5}' where Building_ID = {6}"
            , Total_Rooms, Students_Residing, Annual_Expenses, Address, City, Building_Name,Building_ID);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public void Delete(int Building_ID)
        {
            string q = "Delete from Hostel where Building_ID ='" + Building_ID + "'";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();

        }
        public Hostel UpItems(int Building_ID)
        {
            string q = "Select * from Hostel Where Building_ID =" + Building_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            Hostel u = new Hostel();
            while (sdr.Read())
            {
                u.Building_ID = (int)sdr["Building_ID"];
                u.Students_Residing = (int)sdr["Students_Residing"];
                u.Students_Residing = (int)sdr["Students_Residing"];
                u.Annual_Expenses = (int)sdr["Annual_Expenses"];
                u.Address = (string)sdr["Address"];
                u.City = (string)sdr["City"];
                u.Building_Name = (string)sdr["Building_Name"];

            }
            sdr.Close();
            return u;
        }
    }
}