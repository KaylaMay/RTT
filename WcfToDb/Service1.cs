using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WcfToDb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public Service1()
        {
            ConnectToDb();
        }

        SqlConnection conn;
        SqlCommand comm;
        SqlConnectionStringBuilder connStringBuilder;
        void ConnectToDb()
        {
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "BOOTCAMP21";
            connStringBuilder.InitialCatalog = "ClientRegistrationDB";
            connStringBuilder.Encrypt = true;
            connStringBuilder.TrustServerCertificate = true;
            connStringBuilder.ConnectTimeout = 30;
            connStringBuilder.AsynchronousProcessing = true;
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());
            comm = conn.CreateCommand();
        }


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;

        }
            public int InsertClient(Client c)
        {   
            try
            {
               
                
                comm.CommandText = "insert into Customer values(@Name, @Surname, @Gender, @Residential_Address, @Work_Address, @Postal_Address, @Cell_nr, @Work_nr)";
                comm.Parameters.AddWithValue("Name", c.Name);
                comm.Parameters.AddWithValue("Surname", c.Surname);
                comm.Parameters.AddWithValue("Gender", c.Gender);
                comm.Parameters.AddWithValue("Residential_Address", c.Residential_Address);
                comm.Parameters.AddWithValue("Work_address", c.Work_Address);
                comm.Parameters.AddWithValue("Postal_Address", c.Postal_Address);
                comm.Parameters.AddWithValue("Cell_nr", c.Cell_nr);
                comm.Parameters.AddWithValue("Work_nr", c.Work_nr);

                comm.CommandType = CommandType.Text;

                conn.Open();
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public int UpdateClient(Client c)
        {
            try
            {
                comm.CommandText = "Update Customer set Name=@name, Surname=@Surname, Gender=@Gender, Residential_Address=@Residential_Address, Work_Address=@Work_Address, Postal_Address=@Postal_Address, Cell_nr=@Cell_nr, Work_nr=@Work_nr where Cust_id=@Cust_id";
                comm.Parameters.AddWithValue("Cust_id", c.Cust_id);
                comm.Parameters.AddWithValue("Name", c.Name);
                comm.Parameters.AddWithValue("Surname", c.Surname);
                comm.Parameters.AddWithValue("Gender", c.Gender);
                comm.Parameters.AddWithValue("Residential_Address", c.Residential_Address);
                comm.Parameters.AddWithValue("Work_Address", c.Work_Address);
                comm.Parameters.AddWithValue("Postal_Address", c.Postal_Address);
                comm.Parameters.AddWithValue("Cell_nr", c.Cell_nr);
                comm.Parameters.AddWithValue("Work_nr", c.Work_nr);
                comm.CommandType = CommandType.Text;

                conn.Open();

                return comm.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }
        public int DeleteClient(Client c)
        {
            try
            {
                comm.CommandText = "Delete from Customer where Cust_id=@Cust_id";
                comm.Parameters.AddWithValue("Cust_id", c.Cust_id);

                comm.CommandType = CommandType.Text;

                conn.Open();

                return comm.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }

        public List<Client> GetClient()
        {
           List<Client> clientl = new List<Client>();
            try
            {
                comm.CommandText = "select Cust_id, Name, Surname, Gender, Residential_Address, Work_Address, Postal_Address, Cell_nr, Work_nr from Customer";
                comm.CommandType = CommandType.Text;

                conn.Open();

                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Client client = new Client()
                    {
                        Cust_id=Convert.ToInt32(reader[0]),
                        Name = reader[1].ToString(),
                        Surname = reader[2].ToString(),
                        Gender = reader[3].ToString(),
                        Residential_Address = reader[4].ToString(),
                        Work_Address = reader[5].ToString(),
                        Postal_Address = reader[6].ToString(),
                        Cell_nr = reader[7].ToString(),
                        Work_nr = reader[8].ToString()
                    };
                    clientl.Add(client);
                }

                
                return clientl;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
         
        
    }
}
