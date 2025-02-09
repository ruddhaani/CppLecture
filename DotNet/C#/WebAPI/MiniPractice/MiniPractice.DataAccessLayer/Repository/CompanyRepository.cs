using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using MiniPractice.BusinessLayer.IRepository;
using MiniPractice.BusinessLayer.Models;

namespace MiniPractice.DataAccessLayer.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=PracticeDb;Trusted_connection=True;TrustServerCertificate=True";
        public int Create(Company company)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("CreateCompany", connection);
            command.Parameters.AddWithValue("@CompanyName", company.Name);
            command.Parameters.AddWithValue("@CompanyCity", company.City);
            command.CommandType = CommandType.StoredProcedure;
            var result = command.ExecuteNonQuery();

            connection.Close();
            return result;
        }

        public void Delete(Company company)
        {
            throw new NotImplementedException();
        }

        public Company GetById()
        {
            throw new NotImplementedException();
        }

        public List<Company> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
