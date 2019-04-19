using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using HostelManagement;

namespace HostelManagment.Models
{
    public class Employees
    {
        public int Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public string Job { get; set; }
        public string Address { get; set; }
        public int Emp_Salary { get; set; }
        public string Phone_No { get; set; }
        public int Building_ID { get; set; }

        public void Add()
        {
            string q = string.Format
                (@"Insert into Employees values('{0}','{1}','{2}',{3},'{4}',{5})"
                , Emp_Name, Job, Address, Emp_Salary, Phone_No, Building_ID);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public List<Employees> ShowAll()
        {
            string q = "Select * from Employees";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Employees> lst = new List<Employees>();
            while (sdr.Read())
            {
                Employees u = new Employees();
                u.Emp_ID = (int)sdr["Emp_ID"];
                u.Emp_Name = (string)sdr["Emp_Name"];
                u.Job = (string)sdr["Job"];
                u.Address = (string)sdr["Address"];
                u.Emp_Salary = (int)sdr["Emp_Salary"];
                u.Phone_No = (string)sdr["Phone_No"];
                u.Building_ID = (int)sdr["Building_ID"];
                lst.Add(u);
            }
            sdr.Close();
            return lst;
        }

        public List<Employees> Search(int Emp_ID)
        {
            string q = "Select * from Employees Where Emp_ID =" + Emp_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            List<Employees> a = new List<Employees>();
            Employees u = new Employees();
            while (sdr.Read())
            {
                u.Emp_ID = (int)sdr["Emp_ID"];
                u.Emp_Name = (string)sdr["Emp_Name"];
                u.Job = (string)sdr["Job"];
                u.Address = (string)sdr["Address"];
                u.Emp_Salary = (int)sdr["Emp_Salary"];
                u.Phone_No = (string)sdr["Phone_No"];
                u.Building_ID = (int)sdr["Building_ID"];
            }
            sdr.Close();
            a.Add(u);
            return a;
        }

        public void update()
        {
            string q = string.Format(@"Update Employees set  Emp_Name = '{0}', Job = '{1}', Address = '{2}',
            Emp_Salary = {3}, Phone_No = '{4}', Building_ID = {5}
            where Emp_ID = {6}"
            , Emp_Name, Job, Address, Emp_Salary, Phone_No, Building_ID, Emp_ID);
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }
        public void Delete(int Emp_ID)
        {
            string q = "Delete from Employees where Emp_ID ='" + Emp_ID + "'";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();

        }

        public Employees UpItem(int Emp_ID)
        {
            string q = "Select * from Employees Where Emp_ID =" + Emp_ID;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sdr = sc.ExecuteReader();
            Employees u = new Employees();
            while (sdr.Read())
            {
                u.Emp_ID = (int)sdr["Emp_ID"];
                u.Emp_Name = (string)sdr["Emp_Name"];
                u.Job = (string)sdr["Job"];
                u.Address = (string)sdr["Address"];
                u.Emp_Salary = (int)sdr["Emp_Salary"];
                u.Phone_No = (string)sdr["Phone_No"];
                u.Building_ID = (int)sdr["Building_ID"];
            }
            sdr.Close();
            return u;
        }
    }
}