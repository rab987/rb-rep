using AutoMapper;
using Dapper;
using DTApiLoadCounter.Data.Entities;
using DTApiLoadCounter.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DTApiLoadCounter.Data.Repositories
{
    public class DailyJobRepositoryImpl : IDailyJobRepository
    {
        private readonly DTApiLoadCounterContext _DTApiLoadCounterContext;
        private readonly IMapper _mapper;
        public DailyJobRepositoryImpl()
        {
        }

        public IEnumerable<LoadCounterDailyJobDTO> GetDailyJobs(int JobId)
        {
            var con = ConfigurationManager.AppSettings["DefaultConnection"];

            try
            {
                using (SqlConnection myConnection = new SqlConnection("Server=185.168.100.139;Database=MockDB;User ID=Username;Password=NewPassword;TrustServerCertificate=True;Trusted_Connection=False;Connection Timeout=30;Integrated Security=False;Persist Security Info=False;Encrypt=True;MultipleActiveResultSets=True;"))
                {
                    myConnection.Open();

                    var sql = "apiGetLoadCounterDailyJob";
                    var param = new DynamicParameters();
                    param.Add("@JobId", JobId);

                    //var result = myConnection.Query<ApiGetLoadCounterDailyJobResult>(sql, param, commandType: System.Data.CommandType.StoredProcedure).SingleOrDefault();
                    //var dailyJob = _mapper.Map<LoadCounterDailyJobDTO>(result);

                   IEnumerable<LoadCounterDailyJobDTO> dailyJob = myConnection.Query<LoadCounterDailyJobDTO>(sql, param, commandType: System.Data.CommandType.StoredProcedure);

                    myConnection.Close();
                    return dailyJob;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
