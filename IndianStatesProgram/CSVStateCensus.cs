using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesProgram.Files_StatePopulationn
{
    public class CSVStateCensus
    {
        /// <summary>
        /// Uc1 State Cencus Data Population
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public int ReadStateCencusData(string filepath)
        {
            if (!File.Exists(filepath))
            {
                throw new ExceptionStateCensus(ExceptionStateCensus.ExceptionTypes.FILE_INCORRECT_PATH, "File path is incorrect");
            }
            using (var reader = new StreamReader(filepath))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<StatePopulationData>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine("State: "+data.State+"\nPopulation: "+data.Population+"\nArea: "+data.AreaInSqKm+"\nDensity:"+data.DensityPerSqKm+"\n ");
                }
                return records.Count()-1;
            }
        }
    }
}
