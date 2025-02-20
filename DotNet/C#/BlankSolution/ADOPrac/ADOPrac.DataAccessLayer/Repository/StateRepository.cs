using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOPrac.BusinessLogicLayer.IRepository;
using ADOPrac.BusinessLogicLayer.Models;
using Microsoft.Data.SqlClient;

namespace ADOPrac.DataAccessLayer.Repository
{
    public class StateRepository : IStateRepository
    {
        public int ChangeIsActive(int id, int flag)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("ChangeIsActiveForState", connection);
            command.Parameters.AddWithValue("@StateId", id);
            command.Parameters.AddWithValue("@isActive", flag);
            command.CommandType = CommandType.StoredProcedure;
            var result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public int Create(State state)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("CreateState", connection);
            command.Parameters.AddWithValue("@StateName", state.StateName);
            command.Parameters.AddWithValue("@StateDescription", state.StateDescription);
            command.Parameters.AddWithValue("@CountryId" , state.CountryId);
            command.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
            command.Parameters.AddWithValue("@CreatedBy", 1);
            command.Parameters.AddWithValue("@UpdatedBy", 1);
            command.Parameters.AddWithValue("@UpdatedOn", DateTime.Now);
            command.Parameters.AddWithValue("@isActive", 1);
            command.CommandType = CommandType.StoredProcedure;
            var result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public int Delete(int id)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("DeleteState", connection);
            command.Parameters.AddWithValue("@StateId", id);
            command.CommandType = CommandType.StoredProcedure;
            var result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public StateListResponse GetStateById(int id)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("GetStateById", connection);
            command.Parameters.AddWithValue("@StateId", id);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = command.ExecuteReader();
            StateListResponse state = new StateListResponse();
            while (sqlDataReader.Read())
            {
                state.StateId = Convert.ToInt32(sqlDataReader["StateId"]);
                state.CountryId = Convert.ToInt32(sqlDataReader["CountryId"]);
                state.StateName = Convert.ToString(sqlDataReader["StateName"]);
                state.CountryName = Convert.ToString(sqlDataReader["CountryName"]);
                state.StateDescription = Convert.ToString(sqlDataReader["StateDescription"]);
            }

            return state;
        }

        public List<StateListResponse> GetStatesList()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("GetStatesList", connection);
            SqlDataReader reader = command.ExecuteReader();
            var stateList = new List<StateListResponse>();

            while (reader.Read())
            {
                StateListResponse state = new StateListResponse();

                state.StateId = Convert.ToInt32(reader["StateId"]);
                state.StateName= Convert.ToString(reader["StateName"]);
                state.StateDescription= Convert.ToString(reader["StateDescription"]);
                state.CountryName= Convert.ToString(reader["CountryName"]);
                state.CountryId = Convert.ToInt32(reader["CountryId"]);
                state.isActive = Convert.ToInt32(reader["isActive"]);

                stateList.Add(state);
            }

            return stateList;
        }

        public int Update(State state)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("UpdateState", connection);
            command.Parameters.AddWithValue("@StateId", state.StateId);
            command.Parameters.AddWithValue("@StateName", state.StateName);
            command.Parameters.AddWithValue("@StateDescription", state.StateDescription);
            command.Parameters.AddWithValue("@CountryId", state.CountryId);
            command.Parameters.AddWithValue("@UpdatedOn", DateTime.Now);
            command.Parameters.AddWithValue("@UpdatedBy", 1);
            command.CommandType = CommandType.StoredProcedure;
            var result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
