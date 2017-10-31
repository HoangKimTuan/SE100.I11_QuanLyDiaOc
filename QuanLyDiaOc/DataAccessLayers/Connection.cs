using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Xml;
using System.Configuration;

namespace QuanLyDiaOc.DataAccessLayers
{
    class Connection
    {
        public static string connectPath = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        public static SqlConnection connect;
        public static SqlCommand sqlCommand;
        public static SqlDataAdapter sqlAdapter;

        public void OpenConnect()
        {
            try
            {
                connect = new SqlConnection(connectPath);
                connect.Open();
                System.Console.WriteLine("Kết nối CSDL thành công!!");
            }
            catch (SqlException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        public void CloseConnect()
        {
            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
                connect.Dispose();
            }
        }

        public void updateConfigFile(string con)
        {
            //updating config file
            XmlDocument XmlDoc = new XmlDocument();
            //Loading the Config file
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    //setting the coonection string
                    xElement.FirstChild.Attributes[2].Value = con;
                    connectPath = con;
                }
            }
            //writing the connection string in config file
            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        public void Config(string nameComputer, string server, string database)
        {
            try
            {
                //Constructing connection string from the inputs
                StringBuilder Con = new StringBuilder("Data Source=" + nameComputer);
                Con.Append(server);
                Con.Append(";Initial Catalog=");
                Con.Append(database);
                Con.Append(";Integrated Security=SSPI;");
                string strCon = Con.ToString();
                updateConfigFile(strCon);
            }
            catch
            {
                
            }
        }

        public bool CheckConnect()
        {
            try
            {
                connect = new SqlConnection(connectPath);
                connect.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
