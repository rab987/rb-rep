using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using AutoMapper;
using Dapper;
using DTApiLoadCounter.Data.Entities;
using DTApiLoadCounter.DTO;

namespace DTApiLoadCounter.Data.Repositories
{
    public class DailyJobDriversRepositoryImpl : IDailyJobDriversRepository
    {
        private readonly DTApiLoadCounterContext _DTApiLoadCounterContext;
        private readonly IMapper _mapper;
        public DailyJobDriversRepositoryImpl()
        {
        }

        public IEnumerable<LoadCounterDriverDTO> GetDailyJobDrivers(int JobId)
        {
            var con = ConfigurationManager.AppSettings["DefaultConnection"];

            try
            {
                using (SqlConnection myConnection = new SqlConnection("Server=185.168.100.139;Database=MockDB;User ID=Username;Password=NewPassword;TrustServerCertificate=True;Trusted_Connection=False;Connection Timeout=30;Integrated Security=False;Persist Security Info=False;Encrypt=True;MultipleActiveResultSets=True;"))
                {
                    myConnection.Open();

                    var sql = "apiGetLoadCounterDailyJobDrivers";
                    var param = new DynamicParameters();
                    param.Add("@JobId", JobId);

                    IEnumerable<LoadCounterDriverDTO> dailyJobDrivers = myConnection.Query<LoadCounterDriverDTO>(sql, param, commandType: System.Data.CommandType.StoredProcedure);

                    myConnection.Close();
                    return dailyJobDrivers;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            /*   var con = ConfigurationManager.AppSettings["DefaultConnection"];


               List<LoadCounterDriverDTO> dailyJobDrivers = new List<LoadCounterDriverDTO>();
               using (SqlConnection myConnection = new SqlConnection("Server=185.168.100.139;Database=MockDB;User ID=Username;Password=NewPassword;TrustServerCertificate=True;Trusted_Connection=False;Connection Timeout=30;Integrated Security=False;Persist Security Info=False;Encrypt=True;MultipleActiveResultSets=True;"))
               {
                   SqlCommand oCmd = new SqlCommand("apiGetLoadCounterDailyJobDrivers", myConnection);
                   oCmd.CommandType = CommandType.StoredProcedure;
                   oCmd.Parameters.Add(new SqlParameter("@JobId", JobId));
                   myConnection.Open();
                   using (SqlDataReader oReader = oCmd.ExecuteReader())
                   {
                       while (oReader.Read())
                       {
                               foreach (var x in oReader)
                           {
                             LoadCounterDriverDTO  dailyDriver = new LoadCounterDriverDTO
                               {
                                   DailyJobDriverId = (long)oReader["AId"],
                                   DriverId = (long)oReader["ADriverID"],
                                   FirstName = oReader["BFirstName"].ToString(),
                                   LastName = oReader["BLastName"].ToString(),
                                   MobileNumber = oReader["BMobile1"].ToString(),
                                   UnitNumber = (int)oReader["AUnitNumber"],
                                   UnitReference = oReader["AUnitReference"].ToString(),
                                   UnitTypeId = oReader["AUnitTypeID"].ToString(),
                                   StartTime = (DateTime)oReader["AWorkDate"],
                                   PayCode = oReader["BPayCode"].ToString(),
                                   DivisionName = oReader["BDivision"].ToString()
                               };

                               dailyJobDrivers.Add(dailyDriver);
                           }
                       }
                   }

                       myConnection.Close();
                   }
               return dailyJobDrivers; */
        }
    }
}
