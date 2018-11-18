﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SocialLacasa.DataLayer
{
    public class User
    {
        String strConnString = ConfigurationManager.ConnectionStrings["DBSocialLacasa"].ConnectionString;

        public string CheckUser(string userName, string password)
        {
            string isExist = string.Empty;
            try
            {
                SqlConnection cn = new SqlConnection(strConnString);
                SqlCommand cmd = new SqlCommand("usp_GetUser", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", password);

                cn.Open();
                object o = cmd.ExecuteScalar();
                isExist = o.ToString();

                cn.Close();

            }
            catch (Exception ex)
            {

            }
            return isExist;
        }
        public DataTable Getorders(string UserId, string status = "")
        {

            DataTable dtOrders = new DataTable();
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetOrders";
            cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = status;
            cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = Convert.ToInt32(UserId);
            cmd.Connection = con;
            try
            {
                con.Open();

                reader = cmd.ExecuteReader();

                dtOrders.Load(reader);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dtOrders;
        }
        public void SaveUser(string userName, string password, string email)
        {

            try
            {
                SqlConnection cn = new SqlConnection(strConnString);
                SqlCommand cmd = new SqlCommand("usp_SaveUser", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Email", email);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {

            }
        }

        public DataTable GetAllCategory()
        {

            DataTable dtCategory = new DataTable();
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetAllCategory";


            cmd.Connection = con;
            try
            {
                con.Open();

                reader = cmd.ExecuteReader();

                dtCategory.Load(reader);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dtCategory;
        }
        public void SaveNewOrder(string category, string service, string link, string quantity, decimal charge, string userId)
        {

            try
            {
                SqlConnection cn = new SqlConnection(strConnString);
                SqlCommand cmd = new SqlCommand("usp_SaveNewOrder", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Service", service);
                cmd.Parameters.AddWithValue("@Link", link);
                cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(quantity));
                cmd.Parameters.AddWithValue("@Charge", charge);
                cmd.Parameters.AddWithValue("@UserId", Convert.ToInt32(userId));

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {

            }
        }
    }
}