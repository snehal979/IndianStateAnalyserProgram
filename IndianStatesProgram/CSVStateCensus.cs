﻿using CsvHelper;
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
            if (!filepath.EndsWith(".csv"))
            {
                throw new ExceptionStateCensus(ExceptionStateCensus.ExceptionTypes.TYPE_INCORRECT, "File type is incorrect");
            }
            var read = File.ReadAllLines(filepath);
            string hrader = read[0];
            if (hrader.Contains("/"))
            {
                throw new ExceptionStateCensus(ExceptionStateCensus.ExceptionTypes.DELINE_INCORRECT, "File deline is incorrect");
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
        /// <summary>
        /// Uc1.5,2.5 check Header is correct or not
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="actualHeader"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionStateCensus"></exception>
        public bool ReadStateDataHeader(string filepath, string actualHeader)
        {
            var read = File.ReadAllLines(filepath);
            string header = read[0];
            if (header.Equals(actualHeader))
            {
                return true;
            }
            else
            {
                throw new ExceptionStateCensus(ExceptionStateCensus.ExceptionTypes.HEADER_INCORRECT, "File header is incorrect");
            }
        }
        /// <summary>
        /// Uc2 States Code Information
        /// </summary>
        /// <param name="codeFilePath"></param>
        /// <returns></returns>
        public int ReadStae_CodeData(string codeFilePath)
        {
            if (!File.Exists(codeFilePath))
            {
                throw new ExceptionStateCensus(ExceptionStateCensus.ExceptionTypes.FILE_INCORRECT_PATH, "File path is incorrect");
            }
            if (!codeFilePath.EndsWith(".csv"))
            {
                throw new ExceptionStateCensus(ExceptionStateCensus.ExceptionTypes.TYPE_INCORRECT, "File type is incorrect");
            }
            var read = File.ReadAllLines(codeFilePath);
            string hrader = read[0];
            if (hrader.Contains("/"))
            {
                throw new ExceptionStateCensus(ExceptionStateCensus.ExceptionTypes.DELINE_INCORRECT, "File deline is incorrect");
            }

            using (var readCode = new StreamReader(codeFilePath))
            using (var csvReaderCode = new CsvReader(readCode, CultureInfo.InvariantCulture))
            {
                var records = csvReaderCode.GetRecords<CodeStateDOA>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine(data.SrNo+" "+data.State+" "+data.NameNos+" "+data.TIN);
                }
                return records.Count() -1;
            }
        }
    }
}
