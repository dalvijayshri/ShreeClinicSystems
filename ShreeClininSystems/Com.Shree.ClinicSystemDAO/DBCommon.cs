using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Com.Shree.ClinicSystemDAO
{
    
   
    public class DBCommon
    {
        public SqlConnection conn;
        string str = ConfigurationManager.ConnectionStrings["Com.Shree.ClinicSystemControllers.Properties.Settings.Db_ClinicConnectionString"].ConnectionString;
        public DBCommon()
        {
            
           
            conn = new SqlConnection(str);
        }
        #region Data Base Connection and Usage Class.

        // private static string str = System.Configuration.ConfigurationManager.AppSettings.Get("ConnectionString").ToString();
        //ORIGINALSTRING
        //public static string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=Db_Imax;Integrated Security=True;";

        //SSH working
        //public static string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=Db_Imax;Integrated Security=True;user id=SSH;Password=SSH123;";

        //public static string str = @"Data Source=192.168.100.1\SQLEXPRESS;Initial Catalog=Db_Imax;Integrated Security=True;user id=SSH;Password=SSH123;";       
       

       
        /// <summary>
        /// Open Connection To the Databse
        /// </summary>
        /// <returns></returns>
        /// 
        /*-----------------------------------------------------------------------
         Author : ETHIC
         Modification Date: 9 Apr 11
         Purpose:- To Open Database Connection.
        --------------------------------------------------------------------------*/

        public SqlConnection OpenConnection()
        {
            try
            {
                if (conn == null || conn.State == ConnectionState.Closed)
                {
                    //str = "Data Source=COM-PC\SQLEXPRESS;Initial Catalog=Db_Imax;user id=sa;Password=123;";

                    conn = new SqlConnection(str);
                    conn.Open();
                }
                return conn;
            }

            catch (SqlException e1)
            {
                throw new Exception(e1.Message);
            }

        }

        /*-----------------------------------------------------------------------
         Author : ETHIC
         Modification Date: 9 Apr 11
         Purpose:- To Close Connection.
        --------------------------------------------------------------------------*/
        /// <summary>
        /// Close Database Connection.
        /// </summary>

        public void CloseConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

            }
            catch (SqlException e1)
            {
                throw new Exception(e1.Message);
            }

        }

        /*-------------------------------------------------------------------------------------------------------------------------------
            Author: ETHIC
            Modified Date : 9 Apr 11
            Purpose:    
		           
         -------------------------------------------------------------------------------------------------------------------------------*/
        public int GetMaxId(string sTableName, string sColumnName)
        {
            try
            {
                string query = "select max(" + sColumnName + ")from " + sTableName;

                /////string quary = "select case when max(" + sColumnName + " ) >0 then max( " + sColumnName + ")+1 else 1 end as 'Result' from " + sTableName;
                int cnt = ExecuteSclar(OpenConnection(), query, true);
                if (cnt != null)
                    return cnt;
                else
                    return 1;

            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {

            }
        }
        //public int KVGetMaxId(string sTableName, string sColumnName)
        //{
        //    try
        //    {
        //        string query = "select max(" + sColumnName + ")from " + sTableName;

        //        //string quary = "select case when max(" + sColumnName + " ) >0 then max( " + sColumnName + ")+1 else 1 end as 'Result' from " + sTableName;
        //        int cnt = ExecuteSclar(OpenConnection(), query, true);
        //        if (cnt != null)
        //            return cnt;
        //        else
        //            return 1;

        //    }
        //    catch (SqlException e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //    finally
        //    {

        //    }
        //}

        /// <summary>
        /// To Return  SqlDataReader
        /// </summary>
        /// <param name=" SqlCon"></param>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <remarks></remarks>


        /*-----------------------------------------------------------------------
        Author : ETHIC
        Modification Date: 9 Apr 11
        Purpose:- To return Reader resulted by specified Stored Procedure.
        --------------------------------------------------------------------------*/
        public SqlDataReader ExecuteDataReader(SqlConnection SqlCon, CommandType cmdType, string cmdText, params  SqlParameter[] parameters)
        {

            SqlCommand cmd = new SqlCommand();
            DataRow dr;
            int i = 0;
            try
            {
                cmd.CommandType = cmdType;
                cmd.CommandText = cmdText;
                cmd.Connection = SqlCon;
                cmd.CommandTimeout = 0;
                if (parameters != null)
                {
                    while (i < parameters.Length)
                    {
                        cmd.Parameters.Add(parameters[i]);
                        i += 1;
                    }
                }
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }



        /*-----------------------------------------------------------------------
        Author : ETHIC
        Modification Date: 9 Apr 11
        Purpose:- To return Reader resulted by specified Query.
        --------------------------------------------------------------------------*/

        /// <summary>
        /// Method Return Data Reader, Parameter Query.
        /// </summary>
        /// <param name=" SqlCon"></param>
        /// <param name="QueryText"></param>
        /// <returns></returns>
        public SqlDataReader ExecuteDataReader(SqlConnection SqlCon, string QueryText)
        {

            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = QueryText;
                cmd.Connection = SqlCon;
                cmd.CommandTimeout = 0;
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }


        /*-----------------------------------------------------------------------
        Author : ETHIC
        Modification Date: 9 Apr 11
        Purpose:- To return Dataset by specified Stored Procedure.
        --------------------------------------------------------------------------*/
        /// <summary>
        /// Return DataSet Result by Stored Procedure.
        /// </summary>
        /// <param name=" SqlCon"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>

        public DataSet ExecuteDataset(SqlConnection SqlCon, string cmdText, bool CloseAfterUse, params  SqlParameter[] parameters)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(cmdText, SqlCon);
            int i = 0;
            try
            {
                DA.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DA.SelectCommand.CommandTimeout = 0;
                if (parameters != null)
                {
                    while (i < parameters.Length)
                    {
                        DA.SelectCommand.Parameters.Add(parameters[i]);
                        i += 1;
                    }
                }
                DA.Fill(DS);
                return DS;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DS = null;
                DA = null;
                if (CloseAfterUse == true)
                    CloseConnection();
            }
        }

        //Added new mehod to load table and return it
        public DataTable ExecuteDatable( string cmdText, bool CloseAfterUse, params  SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(cmdText, OpenConnection());
            int i = 0;
            try
            {
                DA.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DA.SelectCommand.CommandTimeout = 0;
                if (parameters != null)
                {
                    while (i < parameters.Length)
                    {
                        DA.SelectCommand.Parameters.Add(parameters[i]);
                        i += 1;
                    }
                }
                DA.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dt = null;
                DA = null;
                if (CloseAfterUse == true)
                    CloseConnection();
            }
        }

        public DataSet ExecuteDataset(SqlConnection SqlCon, string QueryText, bool CloseAfterUse)
        {
            DataSet DS = new DataSet();

            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = SqlCon;
                cmd.CommandText = QueryText;
                SqlDataAdapter DA = new SqlDataAdapter(QueryText, SqlCon);
                DA.Fill(DS);
                return DS;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Parameters.Clear();
                if (CloseAfterUse == true)
                    CloseConnection();
                CloseAfterUse = false;
            }
        }

        /*-----------------------------------------------------------------------
        Author : ETHIC
        Modification Date: 9 Apr 11
        Purpose:- To return Reader resulted by specified query
        --------------------------------------------------------------------------*/
        /// <summary>
        /// Returns int Result by Specified Stored Procedure.
        /// </summary>
        /// <param name=" SqlCon"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>

        public int ExecuteNonQuery(SqlConnection SqlCon, string cmdText, bool CloseAfterUse, params  SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand();
            int i = 0;
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = SqlCon;
                cmd.CommandText = cmdText;
                if (parameters != null)
                {
                    while (i < parameters.Length)
                    {
                        cmd.Parameters.Add(parameters[i]);
                        i += 1;
                    }
                }
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Parameters.Clear();
                if (CloseAfterUse == true)
                    CloseConnection();

            }
        }

        public int ExecuteNonQueryInTransaction(SqlTransaction ObjTransaction, string cmdText, params  SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand();
            int i = 0;
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = ObjTransaction.Connection;
                cmd.Transaction = ObjTransaction;
                cmd.CommandText = cmdText;
                if (parameters != null)
                {
                    while (i < parameters.Length)
                    {
                        cmd.Parameters.Add(parameters[i]);
                        i += 1;
                    }
                }
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Parameters.Clear();

            }
        }
        /*-----------------------------------------------------------------------
       Author : ETHIC
       Modification Date: 9 Apr 11
       Purpose:- To return Reader resulted by specified query
       --------------------------------------------------------------------------*/
        /// <summary>
        /// Returns int Result by Specified By Query Text..
        /// </summary>
        /// <param name=" SqlCon"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>

        public int ExecuteNonQuery(SqlConnection SqlCon, string QueryText, bool CloseAfterUse)
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = SqlCon;
                cmd.CommandText = QueryText;
                //  SqlCon.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Parameters.Clear();
                if (CloseAfterUse == true)
                    CloseConnection();
            }
        }
        /*-----------------------------------------------------------------------
      Author : ETHIC
      Modification Date: 9 Apr 11
      Purpose:-  Sql Parameter Created.
      --------------------------------------------------------------------------*/

        /// <summary>
        /// To Create  SqlParameters
        /// </summary>
        /// <param name="parName"></param>
        /// <param name="parValue"></param>
        /// <param name="dbType"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// 
        /*-------------------------------
        //     The method GetConverter of TypeDescriptor retrieves the TypeConverter associated with the target object for which conversion is to be performed.
        //     Simply use this function where needed.
        //     It will get you the  SqlDbType equivalent of the System.Type passed to it as far as possible; else, by default,
        //     it will return the String data type equivalent.
        //     For  SqlDbType, it gives NVarChar.
        //     -----------------------------------*/
        /*----------------------------------------------------------------------------------------------------------------
            Author: ETHIC
            Modified Date : 15 sep 09
            Purpose:   Convert to  SqlDBType
         -------------------------------------------------------------------------------------------------------------*/


        private  SqlDbType GetSqlDBType(Type theType)
        {
            SqlParameter SqlParameter = new SqlParameter();
            TypeConverter tc = TypeDescriptor.GetConverter(SqlParameter.DbType);
            if (tc.CanConvertFrom(theType))
                SqlParameter.DbType = (DbType)tc.ConvertFrom(theType.Name);
            else
            {
                try
                {
                    SqlParameter.DbType = (DbType)tc.ConvertFrom(theType.Name);
                }
                catch { }
            }
            return SqlParameter.SqlDbType;
        }
        /// <summary>
        /// Creates Paraters for the stored procedure.
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="parameterValue"></param>
        /// <param name="objType"></param>
        /// <param name="size"></param>
        /// <param name="parameterDirection"></param>
        /// <returns></returns>

        public SqlParameter CreateParameter(string parameterName, object parameterValue, Type objType, int size, ParameterDirection parameterDirection)
        {
            SqlParameter SqlPar = new SqlParameter();
            try
            {
                SqlPar.Value = parameterValue;
                SqlPar.ParameterName = parameterName;
                SqlPar.SqlDbType = GetSqlDBType(objType);
                SqlPar.Size = size;
                SqlPar.Direction = parameterDirection;
                return SqlPar;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //  SqlPar = null;
            }
        }
        //===================================================================================================================================
        /// <summary>
        /// To Execute Scalar
        /// </summary>
        /// <param name=" SqlCon"></param>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <remarks></remarks>

        /*-----------------------------------------------------------------------
        Author : ETHIC
        Modification Date: 9 Apr 11
        Purpose:- To return int value resulted by specified query
        --------------------------------------------------------------------------*/
        public int ExecuteSclar(SqlConnection SqlCon, string QueryText, bool CloseAfterUse)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = SqlCon;
                cmd.CommandText = QueryText;

                string no = cmd.ExecuteScalar().ToString();
                if (no != "")
                    return Convert.ToInt32(no);
                else
                    return 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (CloseAfterUse == true)
                    CloseConnection();
            }
        }

        public int ExecuteSclar(SqlConnection SqlCon, string cmdType, string cmdText, bool CloseAfterUse, params  SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand();
            int i = 0;
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = SqlCon;
                cmd.CommandText = cmdText;
                if (parameters != null)
                {
                    while (i < parameters.Length)
                    {
                        cmd.Parameters.Add(parameters[i]);
                        i += 1;
                    }
                }
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (CloseAfterUse == true)
                    CloseConnection();
            }
        }

        //===================================================================================================================================
        /// <summary>
        /// To Execute Scalar
        /// </summary>
        /// <param name=" SqlCon"></param>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <remarks></remarks>

        /*-----------------------------------------------------------------------
        Author : ETHIC
        Modification Date: 9 Apr 11
        Purpose:- To return int value resulted by specified query
        --------------------------------------------------------------------------*/


        public int ExecuteSclar(SqlConnection SqlCon, string cmdText, bool CloseAfterUse, params  SqlParameter[] parameters)
        {
            //Tested Ok.
            SqlCommand cmd = new SqlCommand();
            int i = 0;
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = SqlCon;
                cmd.CommandText = cmdText;
                //    SqlCon.Open();
                while (i < parameters.Length)
                {
                    cmd.Parameters.Add(parameters[i]);
                    i += 1;
                }
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (CloseAfterUse == true)
                    CloseConnection();
            }
        }

        #endregion private utility methods & constructors
       
        
    }
}
