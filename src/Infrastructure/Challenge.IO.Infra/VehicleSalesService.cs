using Challenge.Core.Domain.Entities;
using Challenge.Core.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.IO.Infra
{
    public class VehicleSalesService : IVehicleSalesService
    {
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _hostingEnvironment;

        public VehicleSalesService(IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<IEnumerable<VehicleSale>> GetSoldVehiclesAsync()
        {
            var vehicleSales = new List<VehicleSale>();

            var file = _hostingEnvironment.ContentRootPath
                       + Path.DirectorySeparatorChar.ToString()
                       + "Sample"
                       + Path.DirectorySeparatorChar.ToString()
                       + $"{_configuration["Csv-Data"]}";

            var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                //ignore header
                streamReader.ReadLine();

                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var vehicleSale = LineProcessor(line);

                    vehicleSales.Add(vehicleSale);
                }
            }

            return await Task.FromResult(vehicleSales);

        }

        private VehicleSale LineProcessor(string line)
        {
            var split = line.Split(',').ToList();

            JoinQuotedCommaElements(split);

            return new VehicleSale
            {
                DealNumber = int.Parse(split[0]),
                CustomerName = split[1],
                DealershipName = split[2],
                Vehicle = split[3],
                Price = $"CAD${split[4].Replace("\"", "")}",
                Date = split[5]

            };
        }

        /// <summary>
        /// quoted elements will be joined. They were split sequentially
        /// </summary>
        /// <param name="set"></param>
        private void JoinQuotedCommaElements(List<string> set)
        {
            for (int i = 0; i < set.Count; i++)
            {
                var element = set[i];

                if (element.IndexOf('"') > -1)
                {
                    set[i] = $"{element},{set[i + 1]}";
                    set.RemoveAt(i + 1);
                }
            }
        }


    }
}
