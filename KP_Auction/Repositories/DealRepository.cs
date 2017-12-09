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
    public class DealRepository
    {
        public bool Add(DealModel obj)
        {
            using (SqlConnection db = SQLConnector.Connect())
            {
                db.Open();

                SqlCommand com = new SqlCommand("AddDeal", db);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Buyer_Id", obj.Buyer_Id);
                com.Parameters.AddWithValue("@Seller_Id", obj.Seller_Id);
                com.Parameters.AddWithValue("@Item_Id", obj.Item_Id);
                com.Parameters.AddWithValue("@Auction_Id", obj.Auction_Id);
                com.Parameters.AddWithValue("@DealState_Id", obj.DealState_Id);
                com.Parameters.AddWithValue("@Time", obj.Time);
                com.Parameters.AddWithValue("@Price", obj.Price);

                if (com.ExecuteNonQuery() == -1)
                    return false;
                return true;
            }
        }

        public List<DealModel> GetAll()
        {
            using (SqlConnection db = SQLConnector.Connect())
            {
                db.Open();

                List<DealModel> ModelObjects = new List<DealModel>();

                SqlCommand com = new SqlCommand("GetDeals", db);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ModelObjects.Add(new DealModel
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Buyer_Id = Convert.ToInt32(dr["Date"]),
                        Seller_Id = Convert.ToInt32(dr["StartTime"]),
                        Item_Id = Convert.ToInt32(dr["EndTime"]),
                        Auction_Id = Convert.ToInt32(dr["Income"]),
                        DealState_Id = Convert.ToInt32(dr["Date"]),
                        Time = Convert.ToDateTime(dr["StartTime"]),
                        Price = Convert.ToDecimal(dr["EndTime"])
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

                SqlCommand com = new SqlCommand("DeleteDeal", db);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", Id);

                if (com.ExecuteNonQuery() == -1)
                    return false;
                return true;
            }
        }
    }
}