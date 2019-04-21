using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using HostelManagement;

namespace HostelManagment.Models
{
    public class Payment
    {
        //public string Payment_ID { get; set; }
        public int Payment_ID { get; set; }
        public int Allocation_ID { get; set; }
        public string Status { get; set; }

        public static List<string> ab = new List<string>(3) { "Paid", "Unpaid" };
        public void Add()
        {
            string q = string.Format
                (@"Insert into Payment values({0},'{1}')"
                ,Allocation_ID, Status);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public List<Payment> ShowAll()
        {
            string q = "Select * from Payment";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Payment> lst = new List<Payment>();
            while (sdr.Read())
            {
                Payment u = new Payment();
                //u.Payment_ID = (string)sdr["Payment_ID"];
                u.Payment_ID = (int)sdr["Payment_ID"];
                u.Allocation_ID = (int)sdr["Allocation_ID"];
                u.Status = (string)sdr["Status"];

                lst.Add(u);
            }
            sdr.Close();
            return lst;
        }

        public List<Payment> Search(int Payment_ID)
        {
            string q = "Select * from Payment Where Payment_ID =" + Payment_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Payment> a = new List<Payment>();
            Payment u = new Payment();
            while (sdr.Read())
            {
                u.Payment_ID = (int)sdr["Payment_ID"];
                u.Allocation_ID = (int)sdr["Allocation_ID"];
                u.Status = (string)sdr["Status"];

            }
            sdr.Close();
            a.Add(u);
            return a;
        }

        public void update()
        {
            string q = string.Format(@"Update Payment set Allocation_ID = {0}, Status = '{1}'
            where Payment_ID = '{2}'"
            , Allocation_ID, Status, Payment_ID);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public void Delete(int Payment_ID)
        {
            string q = "Delete from Payment where Payment_ID ='" + Payment_ID + "'";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();

        }

        public Payment UpItem(int Payment_ID)
        {
            string q = "Select * from Payment Where Payment_ID =" + Payment_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            Payment u = new Payment();
            while (sdr.Read())
            {
                u.Payment_ID = (int)sdr["Payment_ID"];
                u.Allocation_ID = (int)sdr["Allocation_ID"];
                u.Status = (string)sdr["Status"];

            }
            sdr.Close();
            return u;
        }
    }
}