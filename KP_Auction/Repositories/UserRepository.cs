using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using KP_Auction.Models;
using System.Data;

namespace KP_Auction.Repositories
{
    public class UserRepository
    {
        public List<UserModel> GetAll()
        {
            using (SqlConnection db = SQLConnector.Connect())
            {
                db.Open();

                SqlCommand com = new SqlCommand("GetUsers", db);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return FillTable(dt);
            }
        }

        private List<UserModel> FillTable(DataTable dt)
        {
            List<UserModel> ModelObjects = new List<UserModel>();
            foreach (DataRow dr in dt.Rows)
            {
                ModelObjects.Add(new UserModel
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Username = Convert.ToString(dr["Login"]),
                    Password = Convert.ToString(dr["Password"]),
                    Role = Convert.ToString(dr["Role"])
                });
            }
            return ModelObjects;
        }
    }
}