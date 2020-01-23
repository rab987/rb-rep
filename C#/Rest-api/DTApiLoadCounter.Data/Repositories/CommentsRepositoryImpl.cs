using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using DTApiLoadCounter.DTO;

namespace DTApiLoadCounter.Data.Repositories
{
    public class CommentsRepositoryImpl : ICommentsRepository
    {

        public CommentsRepositoryImpl()
        {

        }

        public IEnumerable<LoadCounterCommentDTO> GetDailyComments(int JobId)
        {
            var con = ConfigurationManager.AppSettings["DefaultConnection"];

            try
            {
                using (SqlConnection myConnection = new SqlConnection("Server=185.168.100.139;Database=MockDB;User ID=Username;Password=NewPassword;TrustServerCertificate=True;Trusted_Connection=False;Connection Timeout=30;Integrated Security=False;Persist Security Info=False;Encrypt=True;MultipleActiveResultSets=True;"))
                {
                    myConnection.Open();

                    var sql = "apiGetLoadCounterDailyJobComments";
                    var param = new DynamicParameters();
                    param.Add("@JobId", JobId);

                    IEnumerable<LoadCounterCommentDTO> dailyComments = myConnection.Query<LoadCounterCommentDTO>(sql, param, commandType: System.Data.CommandType.StoredProcedure);

                    myConnection.Close();
                    return dailyComments;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
