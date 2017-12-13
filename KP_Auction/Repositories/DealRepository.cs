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

                SqlCommand com = new SqlCommand("GetDeals", db);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return FillTable(dt);
            }
        }

        private List<DealModel> FillTable(DataTable dt)
        {
            List<DealModel> ModelObjects = new List<DealModel>();
            foreach (DataRow dr in dt.Rows)
            {
                ModelObjects.Add(new DealModel
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Buyer_Id = Convert.ToInt32(dr["Buyer_Id"]),
                    Seller_Id = Convert.ToInt32(dr["Seller_Id"]),
                    Item_Id = Convert.ToInt32(dr["Item_Id"]),
                    Auction_Id = Convert.ToInt32(dr["Auction_Id"]),
                    DealState_Id = Convert.ToInt32(dr["DealState_Id"]),
                    Time = DateTime.ParseExact(Convert.ToString((dr["Time"])), "HH:mm:ss", CultureInfo.InvariantCulture),
                    Price = Convert.ToInt32(dr["Price"])
                });
            }
            return ModelObjects;
        }

        public DealModel GetById(int id)
        {
            using (SqlConnection db = SQLConnector.Connect())
            {
                db.Open();

                DealModel ModelObject = new DealModel();

                SqlCommand com = new SqlCommand("GetDealById", db);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", id);
                com.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return FillTable(dt)[0];
            }
        }

        public bool Update(DealModel obj)
        {
            using (SqlConnection db = SQLConnector.Connect())
            {
                db.Open();

                SqlCommand com = new SqlCommand("UpdateDeal", db);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", obj.Id);
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