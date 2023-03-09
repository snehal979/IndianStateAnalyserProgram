using IndianStatesProgram.Files_StatePopulationn;

namespace IndianStateProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Indian State Program");
            string filePopulationPath = @"C:\Users\hp\Desktop\newBatch2\IndianStatesProgram\IndianStatesProgram\Files_StatePopulationn\StatePopulationFile.csv";
            CSVStateCensus cSVStateCensus = new CSVStateCensus();
            cSVStateCensus.ReadStateCencusData(filePopulationPath);
            Console.ReadLine();
        }
    }
}