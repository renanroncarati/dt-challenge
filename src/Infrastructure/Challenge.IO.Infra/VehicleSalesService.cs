using Challenge.Core.Domain.Entities;
using Challenge.Core.Domain.Services.Interfaces;
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
        public async Task<IEnumerable<VehicleSale>> GetSoldVehiclesAsync()
        {
            var vehicleSales = new List<VehicleSale>();

            var fileStream = new FileStream(@"D:\Renan\workspaces\dt-challenge\dt-challenge\sample\Dealertrack-CSV-Example.csv", FileMode.Open, FileAccess.Read);
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
                Price = $"CAD${split[4].Replace("\"","")}",
                Date = split[5]

            };
        }

        private void JoinQuotedCommaElements(List<string> set)
        {
            for (int i = 0; i < set.Count; i++)
            {
                var element = set[i];

                if (element.IndexOf('"') > -1)
                {
                    set[i] = $"{element},{set[i + 1]}";
                    set.RemoveAt(i + 1);
                    //i += 1;
                }
            }
        }


    }
}
