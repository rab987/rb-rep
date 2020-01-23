using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LoadCounterMobile.DTOs;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace LoadCounterMobile.Services
{
    public class GetDailyJobService : IGetDailyJobService
    {
        HttpClient _client;
        public LoadCounterDailyJobDTO dailyJob { get; private set; }

        public GetDailyJobService()
        {
            _client = new HttpClient();
        }

        public async Task<LoadCounterDailyJobDTO> GetDailyJobs()
        {
            dailyJob = new LoadCounterDailyJobDTO();

            //Url logic will change once login authentication is created and Job Id is determined that way
            //string BaseAddress = Device.RuntimePlatform == Device.Android ? "https://10.0.2.2:5001" : "https://192.168.0.16:45456";
            string BaseAddress = "https://192.168.0.16:45456";
            string DailyJobUrl = BaseAddress + "/api/LoadCounter/GetDailyJob/test/15336";

            var uri = new Uri(string.Format("https://192.168.0.16:45456/api/LoadCounter/GetDailyJob/test/15336", string.Empty));
            //https://192.168.0.16:45456/api/LoadCounter/GetDailyJob/15536
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    dailyJob = JsonConvert.DeserializeObject<LoadCounterDailyJobDTO>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return dailyJob;
        }

        public async Task<LoadCounterUnitTypeDTO> GetDailyUnitType()
        {
            dailyJob = new LoadCounterDailyJobDTO();
            LoadCounterUnitTypeDTO driverUnitType = new LoadCounterUnitTypeDTO();

            //Url logic will change once login authentication is created and Job Id is determined that way
            //string BaseAddress = Device.RuntimePlatform == Device.Android ? "https://10.0.2.2:5001" : "https://192.168.0.16:45456";
            string BaseAddress = "https://192.168.0.16:45456";
            string DailyJobUrl = BaseAddress + "/api/LoadCounter/GetDailyJob/test/15336";

            var uri = new Uri(string.Format(DailyJobUrl, string.Empty));
            //https://192.168.0.16:45456/api/LoadCounter/GetDailyJob/15536
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    dailyJob = JsonConvert.DeserializeObject<LoadCounterDailyJobDTO>(content);
                    foreach(var x in dailyJob.Units)
                    {
                        driverUnitType = x;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return driverUnitType;
        }

        public async Task<IEnumerable<LoadCounterDriverDTO>> GetDailyDrivers()
        {
            dailyJob = new LoadCounterDailyJobDTO();
            List<LoadCounterDriverDTO> driverList = new List<LoadCounterDriverDTO>();
            IEnumerable<LoadCounterDriverDTO> dailyDrivers = driverList;

            //Url logic will change once login authentication is created and Job Id is determined that way
            //string BaseAddress = Device.RuntimePlatform == Device.Android ? "https://10.0.2.2:5001" : "https://192.168.0.16:45456";
            string BaseAddress = "https://192.168.0.16:45456";
            string DailyJobUrl = BaseAddress + "/api/LoadCounter/GetDailyJob/test/15336";

            var uri = new Uri(string.Format(DailyJobUrl, string.Empty));
            //https://192.168.0.16:45456/api/LoadCounter/GetDailyJob/15536
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    dailyJob = JsonConvert.DeserializeObject<LoadCounterDailyJobDTO>(content);
                    dailyDrivers = dailyJob.Drivers;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return dailyDrivers;
        }
    }
}
