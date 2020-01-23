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
    public class UnitTypeRepositoryImpl : IUnitTypeRepository
    {
        public UnitTypeRepositoryImpl()
        {

        }

        public IEnumerable<LoadCounterUnitTypeDTO> GetDailyUnitTypes(int JobId)
        {
            var con = ConfigurationManager.AppSettings["DefaultConnection"];

            try
            {
                using (SqlConnection myConnection = new SqlConnection("Server=185.168.100.139;Database=MockDB;User ID=Username;Password=NewPassword;TrustServerCertificate=True;Trusted_Connection=False;Connection Timeout=30;Integrated Security=False;Persist Security Info=False;Encrypt=True;MultipleActiveResultSets=True;"))
                {
                    myConnection.Open();

                    var sql = "apiGetLoadCounterDailyJobUnitTypes";
                    var param = new DynamicParameters();
                    param.Add("@JobId", JobId);

                    IEnumerable<LoadCounterUnitTypeDTO> dailyUnits = myConnection.Query<LoadCounterUnitTypeDTO>(sql, param, commandType: System.Data.CommandType.StoredProcedure);

                    myConnection.Close();
                    return dailyUnits;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
