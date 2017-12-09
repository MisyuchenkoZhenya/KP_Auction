using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Web.Configuration;
using KP_Auction.Models;
using System.Data;

namespace KP_Auction.Repositories
{
    public class AuctionRepository
    {   
        public bool Add(AuctionModel obj)
        {
            using (SqlConnection db = SQLConnector.Connect())
            {
                db.Open();

                SqlCommand com = new SqlCommand("AddAuction", db);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Date", obj.Date);
                com.Parameters.AddWithValue("@StartTime", obj.StartTime);
                com.Parameters.AddWithValue("@EndTime", obj.EndTime);
                com.Parameters.AddWithValue("@Income", obj.Income);

                if (com.ExecuteNonQuery() == -1)
                    return false;
                return true;
            }
        }
       
        public List<AuctionModel> GetAll()
        {
            using (SqlConnection db = SQLConnector.Connect())
            {
                db.Open();

                List<AuctionModel> ModelObjects = new List<AuctionModel>();

                SqlCommand com = new SqlCommand("GetAuctions", db);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ModelObjects.Add(new AuctionModel {
                        Id = Convert.ToInt32(dr["Id"]),
                        Date = Convert.ToDateTime(dr["Date"]),
                        StartTime = Convert.ToDateTime(dr["StartTime"]),
                        EndTime = Convert.ToDateTime(dr["EndTime"]),
                        Income = Convert.ToInt32(dr["Income"])
                    });
                }
                return ModelObjects;
            }
        }
        
        public bool Update(AuctionModel obj)
        {
            using (SqlConnection db = SQLConnector.Connect())
            {
                db.Open();

                SqlCommand com = new SqlCommand("UpdateAuction", db);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", obj.Id);
                com.Parameters.AddWithValue("@Date", obj.Date);
                com.Parameters.AddWithValue("@StartTime", obj.StartTime);
                com.Parameters.AddWithValue("@EndTime", obj.EndTime);
                com.Parameters.AddWithValue("@Income", obj.Income);

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

                SqlCommand com = new SqlCommand("DeleteAuction", db);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", Id);

                if (com.ExecuteNonQuery() == -1)
                    return false;
                return true;
            }
        }
    }
}