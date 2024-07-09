using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using WebApplication4.Models;

namespace TestApplication.Models
{
    public class TestClass
    {
        DBBridge db = new DBBridge();

        public string Mode { get; set; }    
        public int Id { get; set; }
        public string CatageryName { get; set; }
        public string Name { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public DateTime dob { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public int cnic { get; set; }
        public string address { get; set; }
        public string password { get; set; }
        public string message { get; set; }
        public bool optionOne { get; set; } 
        public bool optionTwo { get; set; }




        public DataTable Insert()
        {
            SqlParameter[] sp = new SqlParameter[15];
            sp[0] = new SqlParameter("@Mode", Mode);
            sp[1] = new SqlParameter("@Id", Id);
            sp[2] = new SqlParameter("@CatageryName", CatageryName);
            sp[3] = new SqlParameter("@Name", CatageryName);
            sp[4] = new SqlParameter("@lastName", lastName);
            sp[5] = new SqlParameter("@userName", userName);
            sp[6] = new SqlParameter("@dob", dob);
            sp[7] = new SqlParameter("@email", email);
            sp[8] = new SqlParameter("@phone", phone);
            sp[9] = new SqlParameter("@cnic", cnic);
            sp[10] = new SqlParameter("@address", address);
            sp[11] = new SqlParameter("@password", password);
            sp[12] = new SqlParameter("@message", message);
            sp[13] = new SqlParameter("@optionOne", optionOne);
            sp[14] = new SqlParameter("@optionTwo", optionTwo);
            





            DataTable dt = new DataTable();
            dt = db.ExecuteDataset("TestProc", sp).Tables[0];

            return dt;


            }



        //public DataTable Update()
        //{
        //    SqlParameter[] sp = new SqlParameter[3];
        //    sp[0] = new SqlParameter("@Mode", Mode);
        //    sp[1] = new SqlParameter("@Id ", Id);
        //    sp[2] = new SqlParameter("@CatageryName", CatageryName);
   

        //    DataTable dt = new DataTable();
        //    dt = db.ExecuteDataset("TestProc", sp).Tables[0];

        //    return dt;


        //}



        public DataTable ReadAll()
        {
            SqlParameter[] sp = new SqlParameter[1];

            sp[0] = new SqlParameter("@Mode", Mode);
          
            DataTable dt = new DataTable();
            dt = db.ExecuteDataset("TestProc", sp).Tables[0];

            return dt;


        }


        public DataTable ReadById()
        {
            SqlParameter[] sp = new SqlParameter[2];

            sp[0] = new SqlParameter("@Mode", Mode);
            sp[1] = new SqlParameter("@Id", Id);

            DataTable dt = new DataTable();
            dt = db.ExecuteDataset("TestProc", sp).Tables[0];

            return dt;


        }



        public DataTable Delete()
        {
            SqlParameter[] sp = new SqlParameter[2];

            sp[0] = new SqlParameter("@Mode", Mode);
            sp[1] = new SqlParameter("@Id", Id);

            DataTable dt = new DataTable();
            dt = db.ExecuteDataset("TestProc", sp).Tables[0];

            return dt;


        }

    }
}
