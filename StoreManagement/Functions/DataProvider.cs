using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StoreManagement.Functions
{
    class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
        }

        public DataProvider() { }

        SqlDataAdapter dataAdapter;

        //Do du lieu vao Datagridview
        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = Connection.Getconnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query,conn);
                    if (parameters != null)
                    {
                        string[] temp = query.Split(' ');
                        List<string> listPara = new List<string>();

                        foreach (string item in temp)
                        {
                            if (item != string.Empty && item[0] == '@')
                            {
                                listPara.Add(item);
                            }
                        }

                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(listPara[i], parameters[i]);
                        }
                    }
                    dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(data);
                }
                catch (Exception ex)
                {
                    throw ex;
                    //MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                return data;
            }
        }
        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = Connection.Getconnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query,conn);
                    if (parameters != null)
                    {
                        string[] temp = query.Split(' ');
                        List<string> listPara = new List<string>();

                        foreach (string item in temp)
                        {
                            if (item != string.Empty && item[0] == '@')
                            {
                                listPara.Add(item);
                            }
                        }

                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(listPara[i], parameters[i]);
                        }
                    }
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                return rowsAffected;
            }
        }
        public bool ExecuteScalar(string query, object[] parameters = null)
        {
            bool result = false;
            //int rowsAffected = 0;
            using (SqlConnection conn = Connection.Getconnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (parameters != null)
                    {
                        string[] temp = query.Split(' ');
                        List<string> listPara = new List<string>();

                        foreach (string item in temp)
                        {
                            if (item != string.Empty && item[0] == '@')
                            {
                                listPara.Add(item);
                            }
                        }

                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(listPara[i], parameters[i]);
                        }
                    }
                    if(cmd.ExecuteScalar() != null)
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                return result;
            }
        }
    }
}
