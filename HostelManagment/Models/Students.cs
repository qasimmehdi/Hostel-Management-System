using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using HostelManagement;

namespace HostelManagment.Models
{
    public class Students
    {
        public int S_ID { get; set; }
        public string S_Name { get; set; }
        public string S_FatherName { get; set; }
        public string S_University { get; set; }
        public string Department { get; set; }
        public string Phone_No { get; set; }
        public int Age { get; set; }
        public string Address_of_Origin { get; set; }
        public string City_of_Origin { get; set; }


        public void Add()
        {
            string q = string.Format
                (@"Insert into Students values('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}')"
                , S_Name, S_FatherName, S_University, Department, Phone_No, Age, Address_of_Origin, City_of_Origin);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public List<Students> ShowAll()
        {
            string q = "Select * from Students";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Students> lst = new List<Students>();
            while (sdr.Read())
            {
                Students u = new Students();
                u.S_ID = (int)sdr["S_ID"];
                u.S_Name = (string)sdr["S_Name"];
                u.S_FatherName = (string)sdr["S_FatherName"];
                u.S_University = (string)sdr["S_University"];
                u.Department = (string)sdr["Department"];
                u.Phone_No = (string)sdr["Phone_No"];
                u.Age = (int)sdr["Age"];
                u.Address_of_Origin = (string)sdr["Address_of_Origin"];
                u.City_of_Origin = (string)sdr["City_of_Origin"];
                lst.Add(u);
            }
            sdr.Close();
            return lst;
        }

        public List<Students> Search(int S_ID)
        {
            string q = "Select * from Students Where S_ID =" + S_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Students> a = new List<Students>();
            Students u = new Students();
            while (sdr.Read())
            {
                u.S_ID = (int)sdr["S_ID"];
                u.S_Name = (string)sdr["S_Name"];
                u.S_FatherName = (string)sdr["S_FatherName"];
                u.S_University = (string)sdr["S_University"];
                u.Department = (string)sdr["Department"];
                u.Phone_No = (string)sdr["Phone_No"];
                u.Age = (int)sdr["Age"];
                u.Address_of_Origin = (string)sdr["Address_of_Origin"];
                u.City_of_Origin = (string)sdr["City_of_Origin"];
            }
            sdr.Close();
            a.Add(u);
            return a;
        }

        public void update()
        {
            string q = string.Format(@"Update Students set S_Name = '{0}', S_FatherName = '{1}', S_University = '{2}',
            Department = '{3}', Phone_No = '{4}', Age = {5}, Address_of_Origin = '{6}', City_of_Origin = '{7}'
             where S_ID = {8}"
            , S_Name, S_FatherName, S_University, Department, Phone_No, Age, Address_of_Origin, City_of_Origin,S_ID);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public void Delete(int S_ID)
        {
            string q = "Delete from Students where S_ID ='" + S_ID + "'";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();

        }

        public Students UpItem(int S_ID)
        {
            string q = "Select * from Students Where S_ID =" + S_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            Students u = new Students();
            while (sdr.Read())
            {
                u.S_ID = (int)sdr["S_ID"];
                u.S_Name = (string)sdr["S_Name"];
                u.S_FatherName = (string)sdr["S_FatherName"];
                u.S_University = (string)sdr["S_University"];
                u.Department = (string)sdr["Department"];
                u.Phone_No = (string)sdr["Phone_No"];
                u.Age = (int)sdr["Age"];
                u.Address_of_Origin = (string)sdr["Address_of_Origin"];
                u.City_of_Origin = (string)sdr["City_of_Origin"];
            }
            sdr.Close();
            return u;
        }

    }
    }