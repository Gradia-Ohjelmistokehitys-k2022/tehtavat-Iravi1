using Fingrid.API;
using Fingrid.API.Models;
using Fingrid.API.Models.Pick_Dataset;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace FingridApiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var key = File.ReadAllText("key.secret").Trim();
            var auth = new ApiKeyAuthenticationProvider(key, "x-api-key", ApiKeyAuthenticationProvider.KeyLocation.Header, "data.fingrid.fi");
            var adapter = new HttpClientRequestAdapter(auth);
            var api = new FingridAPI(adapter);

            var task = api.Notifications.Active.GetAsync();
            task.Wait();

            if (!task.IsCompletedSuccessfully)
                throw new Exception("Unsuccessfull!");

            var res = task.Result!;
            Console.WriteLine($"notifications: ({res.Count})");
            foreach (var n in res)
            {
                Console.WriteLine("\t" + n.Id);
                Console.WriteLine("\t\t" + n.MessageEn);
            }

            var task2 = api.Data.GetAsync((req) =>
            {
                req.QueryParameters.Datasets = "193";
                req.QueryParameters.StartTime = DateTimeOffset.Parse("2024-12-18").ToUniversalTime();
                req.QueryParameters.EndTime = DateTimeOffset.Parse("2024-12-19").ToUniversalTime();
                req.QueryParameters.FormatAsGetFormatQueryParameterType = Fingrid.API.Data.GetFormatQueryParameterType.Json;
                req.QueryParameters.PageSize = 20000;
            });
            task2.Wait();

            if (!task.IsCompletedSuccessfully)
                throw new Exception("Unsuccessfull!");

            var res2 = task2.Result!.IWithPaginationTimeseriesDataOrTimeseriesDataOneRowPerTimePeriod!;
            Console.WriteLine($"data: ({res2.Data!.Count})");
            foreach (var point in res2.Data)
            {
                Console.WriteLine("\t" + point.TimeseriesData!.StartTime!.Value.ToLocalTime());
                Console.WriteLine("\t\t" + point.TimeseriesData.Value);
            }

            var id = new IdOrModifiedAtUtcOrTypeOrOrganizationOrNameFiOrNameEnOrDescriptionFiOrDescriptionEnOrContentGroupsFiOrContentGroupsEnOrKeyWordsFiOrKeyWordsEnOrAvailableFormatsOrDataPeriodFiOrDataPeriodEnOrUnitFiOrUnitEn_();

        }

    }
}
