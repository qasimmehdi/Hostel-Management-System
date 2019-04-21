using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using HostelManagement;

namespace HostelManagment.Models
{
    public class Room
    {
        public int Room_ID { get; set; }
        public int Capacity { get; set; }
        public int Building_ID { get; set; }


        public static List<Room> ab1 = new List<Room>();
        public void dropdown1()
        {
            ab1.Clear();
            SqlCommand a = new SqlCommand("select * from Room", Connection.get());
            SqlDataReader aa = a.ExecuteReader();
            while (aa.Read())
            {
                Room ao = new Room() { Room_ID = (int)aa[0] };
                ab1.Add(ao);
            }
            aa.Close();

        }


        public void Add()
        {
            string q = string.Format
                (@"Insert into Room values({0},{1})"
                , Capacity, Building_ID);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public List<Room> ShowAll()
        {
            string q = "Select * from Room";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Room> lst = new List<Room>();
            while (sdr.Read())
            {
                Room u = new Room();
                u.Room_ID = (int)sdr["Room_ID"];
                u.Capacity = (int)sdr["Capacity"];
                u.Building_ID = (int)sdr["Building_ID"];
                lst.Add(u);
            }
            sdr.Close();
            return lst;
        }


        public List<Room> Search(int Room_ID)
        {
            string q = "Select * from Room Where Room_ID =" + Room_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Room> a = new List<Room>();
            Room u = new Room();
            while (sdr.Read())
            {
                u.Room_ID = (int)sdr["Room_ID"];
                u.Capacity = (int)sdr["Capacity"];
                u.Building_ID = (int)sdr["Building_ID"];

            }
            sdr.Close();
            a.Add(u);
            return a;
        }

        public void update()
        {
            string q = string.Format(@"Update Room set  Capacity = {0},Building_ID = {1}
            where Room_ID = {2}"
            , Capacity, Building_ID, Room_ID);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public void Delete(int Room_ID)
        {
            string q = "Delete from Room where Room_ID ='" + Room_ID + "'";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public Room UpItems(int Room_ID)
        {
            string q = "Select * from Room Where Room_ID =" + Room_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            Room u = new Room();
            while (sdr.Read())
            {
                u.Room_ID = (int)sdr["Room_ID"];
                u.Capacity = (int)sdr["Capacity"];
                u.Building_ID = (int)sdr["Building_ID"];

            }
            sdr.Close();
            return u;
        }
    }
}