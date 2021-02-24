using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DMLDemoWindowsFormsApp
{
    public partial class Form1 : Form
    {
        //Global Variable - Connection String
        string sqlDbDetails = ConfigurationManager.ConnectionStrings["userDbConn"].ConnectionString;
        SqlConnection sqlconn;
        public Form1()
        {
            InitializeComponent();
            //Creating Database Connection
            sqlconn = new SqlConnection(sqlDbDetails);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Opening Database Connection
                sqlconn.Open();

                DbConnCheck.Text = "Connected Successfully";

                //SQL Command for getting USERS details
                string getUserDetailsCmd = "SELECT * FROM USERS; ";
                SqlCommand sqlCmd = new SqlCommand(getUserDetailsCmd, sqlconn);

                //Getting User Details to In Memory Table
                DataTable dtdata = new DataTable();
                dtdata.Load(sqlCmd.ExecuteReader());

                //Displaying User details in GridView
                UserDetailsGridView.DataSource = dtdata;

            }
            catch (Exception exc)
            {
                //Display in label if Connection fails
                DbConnCheck.Text = "Connection Failed : " + exc.Message;
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlconn.Open();

                string countQuery = "SELECT COUNT(id) FROM USERS";
                SqlCommand countCmd = new SqlCommand(countQuery,sqlconn);

                int userCount = (int)countCmd.ExecuteScalar();
                userCountLabel.Text = "User Count is " + userCount;
            }
            catch(Exception exc)
            {
                DbConnCheck.Text = "Connection Failed : " + exc.Message;
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlconn.Open();

                string insertQuery = "EXEC ADD_USERS '" + FirstNameBox.Text + "','"
                    + LastNameTextBox.Text + "','" + placeTextBox.Text + "';";

                SqlCommand insertCommand = new SqlCommand(insertQuery,sqlconn);

                insertCommand.ExecuteNonQuery();

            }
            catch(Exception exc)
            {
                DbConnCheck.Text = "Connection Failed : " + exc.Message;
            }
            finally
            {
                sqlconn.Close();
            }
        }


        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Opening Database Connection
                sqlconn.Open();

                DbConnCheck.Text = "Connected Successfully";

                //SQL Command for getting USERS details
                string getUserDetailsCmd = "SELECT * FROM USERS; ";
                SqlCommand sqlCmd = new SqlCommand(getUserDetailsCmd, sqlconn);

                //Getting User Details to In Memory Table
                DataTable dtdata = new DataTable();
                dtdata.Load(sqlCmd.ExecuteReader());

                //Displaying User details in GridView
                UserDetailsGridView.DataSource = dtdata;

            }
            catch (Exception exc)
            {
                //Display in label if Connection fails
                DbConnCheck.Text = "Connection Failed : " + exc.Message;
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlconn.Open();
                string updateQuery;


                if (updateComboBox.SelectedItem.ToString() == "FirstName")
                {
                    
                     updateQuery = "EXEC UPDATE_USERS_FIRSTNAME '" + idTextBox.Text + "','"
                         + valueTextBox.Text + "';";
                }
                else if(updateComboBox.SelectedItem.ToString() == "LastName")
                {
                     updateQuery = "EXEC UPDATE_USERS_LASTNAME '" + idTextBox.Text + "','"
                       + valueTextBox.Text + "';";
                }
                else
                {
                     updateQuery = "EXEC UPDATE_USERS_PLACE '" + idTextBox.Text + "','"
                        + valueTextBox.Text + "';";
                }


                SqlCommand updateCmd = new SqlCommand(updateQuery, sqlconn);

                updateCmd.ExecuteNonQuery();

            }
            catch (Exception exc)
            {
                //Display in label if Connection fails
                DbConnCheck.Text = "Connection Failed : " + exc.Message;
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlconn.Open();

                string deleteQuery = "EXEC DELETE_USERS '" + idTextBoxForDelete.Text + "';";

                SqlCommand deleteCmd = new SqlCommand(deleteQuery, sqlconn);
                deleteCmd.ExecuteNonQuery();
                
            }
            catch(Exception exc)
            {
                DbConnCheck.Text = "Connection Failed : " + exc.Message;
            }
            finally
            {
                sqlconn.Close();
            }
        }
    }
}
