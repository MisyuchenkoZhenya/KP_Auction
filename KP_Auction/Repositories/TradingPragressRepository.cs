using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Web.Configuration;
using KP_Auction.Models;
using System.Data;
using System.Globalization;

namespace KP_Auction.Repositories
{
    public class TradingPragressRepository
    {
        public bool Add(TradingProgressModel obj)
        {
            using (SqlConnection db = SQLConnector.Connect())
            {
                db.Open();

                SqlCommand com = new SqlCommand("AddTradingProgress", db);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Deal_Id", obj.Deal_Id);
                com.Parameters.AddWithValue("@Byer_Id", obj.Byer_Id);
                com.Parameters.AddWithValue("@StepTime", obj.StepTime);
                com.Parameters.AddWithValue("@StepRate", obj.StepRate);

                if (com.ExecuteNonQuery() == -1)
                    return false;
                return true;
            }
        }

        public List<TradingProgressModel> GetAll()
        {
            using (SqlConnection db = SQLConnector.Connect())
            {
                db.Open();

                SqlCommand com = new SqlCommand("GetTradingProgresses", db);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return FillTable(dt);
            }
        }

        private List<TradingProgressModel> FillTable(DataTable dt)
        {
            List<TradingProgressModel> ModelObjects = new List<TradingProgressModel>();
            foreach (DataRow dr in dt.Rows)
            {
                ModelObjects.Add(new TradingProgressModel
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Deal_Id = Convert.ToInt32(dr["Deal_Id"]),
                    Byer_Id = Convert.ToInt32(dr["Byer_Id"]),
                    StepTime = DateTime.ParseExact(Convert.ToString((dr["StepTime"])), "HH:mm:ss", CultureInfo.InvariantCulture),
                    StepRate = Convert.ToDecimal(dr["StepRate"])
                });
            }
            return ModelObjects;
        }

        public TradingProgressModel GetById(int id)
        {
            using (SqlConnection db = SQLConnector.Connect())
            {
                db.Open();

                TradingProgressModel ModelObject = new TradingProgressModel();

                SqlCommand com = new SqlCommand("GetTradingProgressById", db);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", id);
                com.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return FillTable(dt)[0];
            }
        }

        public bool Update(TradingProgressModel obj)
        {
            using (SqlConnection db = SQLConnector.Connect())
            {
                db.Open();

                SqlCommand com = new SqlCommand("UpdateTradingProgress", db);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", obj.Id);
                com.Parameters.AddWithValue("@Deal_Id", obj.Deal_Id);
                com.Parameters.AddWithValue("@Byer_Id", obj.Byer_Id);
                com.Parameters.AddWithValue("@StepTime", obj.StepTime);
                com.Parameters.AddWithValue("@StepRate", obj.StepRate);

                if (com.ExecuteNonQuery() == -1)
                    return false;
                return true;
            }
        }

        public bool Delete(int Id)
        {
            using (SqlConnection db = SQLConnector.Connect())
            {
                db.Open();

                SqlCommand com = new SqlCommand("DeleteTradingProgress", db);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", Id);

                if (com.ExecuteNonQuery() == -1)
                    return false;
                return true;
            }
        }
    }
}