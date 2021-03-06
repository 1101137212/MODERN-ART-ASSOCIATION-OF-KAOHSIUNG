﻿using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using System.Web.Configuration;
using System.Text;
using System.Reflection;
using System;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models
{
    public class SharedMethod
    {
        /// <summary>
        /// ConnectDBToGetData 連線DB並取得資料(無參數)
        /// </summary>
        /// <param name="sql">sql</param>            
        /// <returns></returns>
        public DataTable ConnectDBToGetData(StringBuilder sql)
        {
            DataTable dt = new DataTable(); //Server=(LocalDB)\v11.0;DataBase=MAAK;Trusted_Connection=True;
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql.ToString(), conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);                    
                    return dt;
                }
            }
        }

        /// <summary>
        /// ConnectDBToGetData 連線DB並取得資料(有參數)
        /// </summary>
        /// <param name="sql">sql</param>            
        /// <param name="parameter">parameter</param>            
        /// <returns></returns>
        public DataTable ConnectDBToGetData(StringBuilder sql, List<SqlParameter> parameter)
        {
            DataTable dt = new DataTable(); //Server=(LocalDB)\v11.0;DataBase=MAAK;Trusted_Connection=True;
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql.ToString(), conn))
                {
                    cmd.Parameters.AddRange(parameter.ToArray());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// ConnectDBToGetData 連線DB並取得資料
        /// </summary>
        /// <param name="sql">sql</param>            
        /// <param name="parameter">parameter</param>            
        /// <returns></returns>
        public static void ConnectDBToSendData(StringBuilder sql, List<SqlParameter> parameter)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MAAKDB"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql.ToString(), conn))
                {
                    cmd.Parameters.AddRange(parameter.ToArray());
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        Console.Write("error");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        /// <summary>
        /// DataTableToList DataTable轉換成List
        /// </summary>
        /// <param name="DataTable">DataTable</param>            
        /// <returns>List</returns>
        public static List<T> DataTableToList<T>(DataTable dataTableList) where T : new()
         {
            try
            {
                List<T> list = new List<T>();

                foreach (var row in dataTableList.AsEnumerable())
                {
                    T obj = new T();

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    list.Add(obj);
                }
                return list;
            }
            catch
            {
                return null;
            }

        }

        #region SqlBuilder
        public class SqlBuilder
        {
            /// <summary>
            /// 自動產生SELECT語法
            /// </summary>
            /// <param name="obj">資料物件</param>
            /// <returns></returns>
            public static StringBuilder Query(object obj)
            {
                SharedMethod objSharedMethod = new SharedMethod();
                StringBuilder strSql = new StringBuilder();
                string strTableName = string.Empty;
                StringBuilder strFieldName = new StringBuilder();
                int index = 0;

                foreach (PropertyInfo objItem in obj.GetType().GetProperties())
                {
                    //將TABLE_NAME記錄至strTableName中
                    if (objItem.Name == "TABLE_NAME")
                    {
                        strTableName = objItem.GetValue(obj, null).ToString();
                    }
                    else
                    {
                        if (index == 0)
                        {
                            strFieldName.AppendLine(objItem.Name + " ");
                        }
                        else
                        {
                            strFieldName.AppendLine(", " + objItem.Name + " ");
                        }
                        index = 1;
                    }
                }
                strSql.AppendLine("SELECT ");
                strSql.AppendLine(strFieldName + " ");
                strSql.AppendLine("FROM " + strTableName + " ");
                strSql.AppendLine("WHERE 1=1 ");

                return strSql;
            }

            /// <summary>
            /// Insert
            /// </summary>
            /// <param name="obj">資料物件</param>
            /// <returns></returns>
            public static StringBuilder Insert(object obj)
            {
                SharedMethod objSharedMethod = new SharedMethod();
                StringBuilder strSql = new StringBuilder();
                string strTableName = string.Empty;
                string strTag = "@";
                StringBuilder strFieldName = new StringBuilder();
                StringBuilder strParameter = new StringBuilder();
                string strDateString = "GETDATE()";
                int index = 0;

                foreach (PropertyInfo objItem in obj.GetType().GetProperties())
                {
                    //將TABLE_NAME記錄至strTableName中
                    if (objItem.Name == "TABLE_NAME")
                    {
                        strTableName = objItem.GetValue(obj, null).ToString();
                    }
                    else
                    {
                        if (objItem.GetValue(obj, null) != null && objItem.Name != "TABLE_NAME")
                        {
                            if (index == 0)
                            {
                                if (objItem.GetValue(obj, null) != null && objItem.GetValue(obj, null).ToString() == strDateString)
                                {
                                    strFieldName.AppendLine(objItem.Name + "  ");
                                    strParameter.AppendLine(strDateString + "  ");
                                }
                                else
                                {
                                    strFieldName.AppendLine(objItem.Name + "  ");
                                    strParameter.AppendLine(strTag + objItem.Name + "  ");
                                }
                            }
                            else
                            {
                                if (objItem.GetValue(obj, null) != null && objItem.GetValue(obj, null).ToString() == strDateString)
                                {
                                    strFieldName.AppendLine(", " + objItem.Name + "  ");
                                    strParameter.AppendLine(", " + strDateString + "  ");
                                }
                                else
                                {
                                    strFieldName.AppendLine(", " + objItem.Name + "  ");
                                    strParameter.AppendLine(", " + strTag + objItem.Name + "  ");
                                }
                            }
                            index = 1;
                        }
                    }
                }

                strSql.AppendLine("INSERT INTO " + strTableName + " ");
                strSql.AppendLine("( ");
                strSql.AppendLine(strFieldName.ToString());
                strSql.AppendLine(") ");
                strSql.AppendLine("VALUES ");
                strSql.AppendLine("( ");
                strSql.AppendLine(strParameter.ToString());
                strSql.AppendLine(") ");

                return strSql;
            }

            /// <summary>
            /// Update
            /// </summary>
            /// <param name="obj">資料物件</param>
            /// <param name="strFunctionName">Where條件的method name</param>
            /// <returns></returns>
            public static StringBuilder Update(object obj, string strFunctionName = "PK_")
            {
                SharedMethod objSharedMethod = new SharedMethod();
                StringBuilder strSql = new StringBuilder();
                StringBuilder strParameter = new StringBuilder();
                string strTableName = string.Empty;
                string strTag = "@";
                List<string> liPrimaryKey = new List<string>();     //暫存PK值
                int index = 0;
                string strDateString = "GETDATE()";

                //取得物件的PK值
                foreach (MethodInfo objMethod in obj.GetType().GetMethods())
                {
                    if (objMethod.Name.Substring(0, 3) == "PK_")
                    {
                        if (strFunctionName == "PK_")
                        {
                            strFunctionName = objMethod.Name;
                        }

                        foreach (ParameterInfo objParameter in objMethod.GetParameters())
                        {
                            liPrimaryKey.Add(objParameter.Name);
                        }
                    }
                }

                //設定Update語法
                foreach (PropertyInfo objItem in obj.GetType().GetProperties())
                {
                    //將TABLE_NAME記錄至strTableName中
                    if (objItem.Name == "TABLE_NAME")
                    {
                        strTableName = objItem.GetValue(obj, null).ToString();
                    }
                    else
                    {
                        if (objItem.GetValue(obj, null) != null && objItem.Name != "TABLE_NAME" && !objSharedMethod.ChkIsPrimaryKey(liPrimaryKey, objItem.Name))
                        {
                            if (index == 0)
                            {
                                if (objItem.GetValue(obj, null) != null && objItem.GetValue(obj, null).ToString() == strDateString)
                                {
                                    strParameter.AppendLine(objItem.Name + "= " + strDateString + " ");
                                }
                                else
                                {
                                    strParameter.AppendLine(objItem.Name + "= " + strTag + objItem.Name + " ");
                                }
                            }
                            else
                            {
                                if (objItem.GetValue(obj, null) != null && objItem.GetValue(obj, null).ToString() == strDateString)
                                {
                                    strParameter.AppendLine(", " + objItem.Name + " = " + strDateString + " ");
                                }
                                else
                                {
                                    strParameter.AppendLine(", " + objItem.Name + " = " + strTag + objItem.Name + " ");
                                }
                            }
                            index = 1;
                        }
                    }
                }

                strSql.AppendLine("UPDATE " + strTableName + " ");
                strSql.AppendLine("SET ");
                strSql.AppendLine(strParameter.ToString());
                strSql.AppendLine("WHERE 1=1 ");

                //根據FunctionName的傳入參數組出Where條件
                if (!string.IsNullOrEmpty(strFunctionName))
                {
                    //取得物件的Funtion
                    foreach (MethodInfo objMethod in obj.GetType().GetMethods())
                    {
                        if (objMethod.Name == strFunctionName)
                        {
                            foreach (ParameterInfo objParameter in objMethod.GetParameters())
                            {
                                strSql.AppendLine(" AND " + objParameter.Name + " = " + strTag + objParameter.Name);
                            }
                        }
                    }
                }

                return strSql;
            }

            /// <summary>
            /// Delete
            /// </summary>
            /// <param name="obj">資料物件</param>            
            /// <param name="strFunctionName">Where條件的method name</param>
            /// <returns></returns>
            public static StringBuilder Delete(object obj, string strFunctionName = "PK_")
            {
                SharedMethod objSharedMethod = new SharedMethod();
                StringBuilder strSql = new StringBuilder();
                string strTableName = string.Empty;
                string strTag = "@";

                foreach (PropertyInfo objItem in obj.GetType().GetProperties())
                {
                    if (objItem.Name == "TABLE_NAME")
                    {
                        strTableName = objItem.GetValue(obj, null).ToString();
                    }
                }

                strSql.AppendLine("DELETE " + strTableName + " ");
                strSql.AppendLine("WHERE 1=1 ");

                //若strFunctionName為empty或null,則預設為該物件PK_開頭的method name
                if (strFunctionName == "PK_")
                {
                    foreach (MethodInfo objMethod in obj.GetType().GetMethods())
                    {
                        if (objMethod.Name.Substring(0, 3) == "PK_")
                        {
                            strFunctionName = objMethod.Name;
                        }
                    }
                }

                //根據FunctionName的傳入參數組出Where條件
                if (!string.IsNullOrEmpty(strFunctionName))
                {
                    //取得物件的Funtion
                    foreach (MethodInfo objMethod in obj.GetType().GetMethods())
                    {
                        if (objMethod.Name == strFunctionName)
                        {
                            foreach (ParameterInfo objParameter in objMethod.GetParameters())
                            {
                                strSql.AppendLine("AND " + objParameter.Name + " = " + strTag + objParameter.Name + " ");
                            }
                        }
                    }
                }

                return strSql;
            }
        }
        #endregion

        /// <summary>
        /// 檢核是否為PrimaryKey
        /// </summary>
        /// <param name="liPrimaryKey">PrimaryKey資料集</param>
        /// <param name="strPropertyName">PropertyName</param>
        /// <returns></returns>
        /// <history>
        /// 2015/10/01 George Liu Create
        /// </history>
        private bool ChkIsPrimaryKey(List<string> liPrimaryKey, string strPropertyName)
        {
            bool blResult = false;

            foreach (string strPrimaryKey in liPrimaryKey)
            {
                if (strPrimaryKey == strPropertyName)
                {
                    blResult = true;
                }
            }

            return blResult;
        }
    }
}