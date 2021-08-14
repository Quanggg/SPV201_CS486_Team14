using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPV201_CS486_Team14
{
    class SQLHelper
    {
        SqlConnection connection = null;
        SQLText sqlText = null;

        public SQLHelper()
        {
            // TODO: Insert ConnectionString name tag
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string connectionStr = config.ConnectionStrings.ConnectionStrings[""].ConnectionString;

            connection = new SqlConnection(connectionStr);
            sqlText = new SQLText();

            try
            {
                connection.Open();
                connection.Close();
            }
            catch (SqlException excep)
            {
                ShowWarningBox(excep);
            }
        }


        #region Public Getter 

        public string[] GetContestantsName()
        {
            DataTable table = ExecFuncTable(sqlText.DisplayContestants);

            if (table != null)
            {
                return DatatableToStrArray(table, "Name");
            }
            else
            {
                ShowNullWarningBox();
                return null;
            }
        }

        public int[] GetContestantsID()
        {
            DataTable table = ExecFuncTable(sqlText.DisplayContestants);

            if (table != null)
            {
                return DatatableToIntArray(table, "ID");
            }
            else
            {
                ShowNullWarningBox();
                return null;
            }
        }

        public string[] GetExaminersName()
        {
            DataTable table = ExecFuncTable(sqlText.DisplayContestants);

            if (table != null)
            {
                return DatatableToStrArray(table, "Name");
            }
            else
            {
                ShowNullWarningBox();
                return null;
            }
        }

        public int[] GetExaminersID()
        {
            DataTable table = ExecFuncTable(sqlText.DisplayExaminers);

            if (table != null)
            {
                return DatatableToIntArray(table, "ID");
            }
            else
            {
                ShowNullWarningBox();
                return null;
            }
        }

        public string[] GetOfficialMembersName()
        {
            DataTable table = ExecFuncTable(sqlText.DisplayOfficialMembers);

            if (table != null)
            {
                return DatatableToStrArray(table, "Name");
            }
            else
            {
                ShowNullWarningBox();
                return null;
            }
        }

        public int[] GetOfficialMembersID()
        {
            DataTable table = ExecFuncTable(sqlText.DisplayOfficialMembers);

            if (table != null)
            {
                return DatatableToIntArray(table, "ID");
            }
            else
            {
                ShowNullWarningBox();
                return null;
            }
        }

        public string[] GetReserveMembersName()
        {
            DataTable table = ExecFuncTable(sqlText.DisplayReserveMembers);

            if (table != null)
            {
                return DatatableToStrArray(table, "Name");
            }
            else
            {
                ShowNullWarningBox();
                return null;
            }
        }

        public int[] GetReserveMembersID()
        {
            DataTable table = ExecFuncTable(sqlText.DisplayReserveMembers);

            if (table != null)
            {
                return DatatableToIntArray(table, "ID");
            }
            else
            {
                ShowNullWarningBox();
                return null;
            }
        }

        #endregion


        #region SQL Execute Functions

        private DataTable ExecFuncTable(string funcCall)
        {
            try
            {
                SqlCommand command = new SqlCommand(funcCall, connection)
                {
                    CommandType = CommandType.Text
                };

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                connection.Close();

                DataTable table = new DataTable();
                table.Load(reader);

                return table;
            }
            catch (SqlException excep)
            {
                ShowWarningBox(excep);
                return null;
            }
        }

        private DataTable ExecResult(string SP_Name, SqlParameter[] paramArr = null)
        {
            try
            {
                SqlCommand command = new SqlCommand(SP_Name, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (paramArr != null)
                {
                    foreach (var param in paramArr)
                    {
                        command.Parameters.Add(param);
                    }
                }

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                
                connection.Close();

                DataTable table = new DataTable();
                table.Load(reader);

                return table;
            }
            catch (SqlException excep)
            {
                ShowWarningBox(excep);
                return null;
            }
        }

        private object ExecScalar(string SP_Name, SqlParameter[] paramArr = null)
        {
            try
            {
                SqlCommand command = new SqlCommand(SP_Name, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (paramArr != null)
                {
                    foreach (var param in paramArr)
                    {
                        command.Parameters.Add(param);
                    }
                }

                connection.Open();

                object result = command.ExecuteScalar();

                connection.Close();

                return result;
            }
            catch (SqlException excep)
            {
                ShowWarningBox(excep);
                return null;
            }
        }

        private void ExecPerform(string SP_Name, SqlParameter[] paramArr = null)
        {
            try
            {
                SqlCommand command = new SqlCommand(SP_Name, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (paramArr != null)
                {
                    foreach (var param in paramArr)
                    {
                        command.Parameters.Add(param);
                    }
                }

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (SqlException excep)
            {
                ShowWarningBox(excep);
            }
        }

        #endregion


        #region Data Post-Process Functions

        private string[] DatatableToStrArray(DataTable table)
        {
            return table.Rows[0].ItemArray.Select(val => val.ToString()).ToArray();
        }

        private string[] DatatableToStrArray(DataTable table, string colName)
        {
            return table.AsEnumerable().Select(row => row.Field<string>(colName)).ToArray();
        }

        private int[] DatatableToIntArray(DataTable table, string colName)
        {
            return table.AsEnumerable().Select(row => row.Field<int>(colName)).ToArray();
        }

        private string ObjectToStr(object result)
        {
            return (string)result;
        }

        private int ObjectToInt(object result)
        {
            return (int)result;
        }

        #endregion


        #region Warning Box Creation

        private void ShowWarningBox(SqlException excep)
        {
            MessageBox.Show("SQLHelper Task raised the following SQL error:\n" +
                "Code: " + excep.ErrorCode + "\n" +
                "Message: " + excep.Message, "Error!", MessageBoxButtons.OK);
        }

        private void ShowNullWarningBox()
        {
            MessageBox.Show("The previous SQLHelper task returns a null value\n" +
                "May cause unexpected behaviour", "Warning!", MessageBoxButtons.OK);
        }

        #endregion
    }
}
