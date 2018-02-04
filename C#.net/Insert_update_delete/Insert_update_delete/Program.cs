using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_update_delete
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
    public class CustomerDal
    {
        string connectionString = "Data Source=KHALEDA-ISLAM;Initial Catalog=BluechipDB_Dragon;User ID=sa; password=leads@123";
        private SqlConnection sqlConn = null;
        private SqlCommand cmd = null;
        string msg = string.Empty;
        public CustomerDal()
        {
            sqlConn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.Connection = sqlConn;
        }
        public string InsertCustomer(Customer objCustomer)
        {
            string msg = String.Empty;
            int noOfRowEffected = 0;
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CUSTOMERS (NAME,AGE,ADDRESS)" + "VALUES ('" + objCustomer.Name + "'," + objCustomer.Age + ",'" + objCustomer.Address
                    + "')";
                noOfRowEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                throw (exp);
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
            }
            if (noOfRowEffected > 0)
                return "Customer information saved successfully!";
            else
                return msg;
        }
        public DataTable GetAllCustomer()
        {
            DataTable tblCustomers = new DataTable();
            SqlDataReader rdr = null;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM CUSTOMERS";
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                rdr = cmd.ExecuteReader();
                tblCustomers.Load(rdr);

            }
            catch (Exception exp)
            {
                throw (exp);
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
            }
            return tblCustomers;
        }
        public string updateCustomer(Customer objCustomer)
        {
            string msg = string.Empty;
            int noOfRowEffected = 0;
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE CUSTOMERS SET NAME = '" + objCustomer.Name + "',AGE = " + objCustomer.Age + " WHERE ID=" + objCustomer.Id;
                noOfRowEffected = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception exp)
            {
                throw (exp);
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
            }
            if (noOfRowEffected > 0)
                return "Customer information updated successfully!";
            else
                return msg;
            
        }
    }
    public class CustomerBLL
    {
        CustomerDal objCustomerDAL;
        public CustomerBLL()
        {
            objCustomerDAL = new CustomerDal();
        }
        public string AddCustomer(Customer objCustomer)
        {
            try
            {
                return objCustomerDAL.InsertCustomer(objCustomer);
            }
            catch (Exception exp)
            {
                throw (exp);
            }
            
        }
        public DataTable GetAllCustomer()
        {
            try
            {
                return objCustomerDAL.GetAllCustomer();
            }
            catch (Exception exp)
            {
                throw (exp);
            }
        }
        public string EditCustomer(Customer objCustomer)
        {
            try
            {
                return objCustomerDAL.updateCustomer(objCustomer);
            }
            catch (Exception exp)
            {
                throw (exp);
            }
        }
    }
    class Program
    {
        public static void DisplayCustomerInfo(DataTable dataTable)
        {
            DataColumn column = dataTable.Columns[0];
            Console.WriteLine(dataTable.Columns[0].ColumnName+"   "+dataTable.Columns[1].ColumnName+"     "+dataTable.Columns[2].ColumnName+"     "+dataTable.Columns[3]+"    ");
            Console.WriteLine("_________________________________________");
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row[0].ToString()+" "+row[1].ToString()+" " + row[2].ToString() + row[3].ToString());
            }
        }
        static void Main(string[] args)
        {
            string msg = string.Empty;
            Customer objCustomer = new Customer();
            objCustomer.Name = "Mahedee Hasan";
            objCustomer.Age = 32;
            objCustomer.Address = "Chandpur";

            CustomerBLL customerBLL = new CustomerBLL();
            msg = customerBLL.AddCustomer(objCustomer);
            Console.WriteLine(msg);

            DisplayCustomerInfo(customerBLL.GetAllCustomer());


            objCustomer.Id = 2;
            objCustomer.Name = "Khaleda Islam";
            objCustomer.Age = 28;
            msg = customerBLL.EditCustomer(objCustomer);
            Console.WriteLine(msg);


            DisplayCustomerInfo(customerBLL.GetAllCustomer());
            Console.ReadKey();
        }

     
    }
}
