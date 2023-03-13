using IndianStatesProgram;
using IndianStatesProgram.Files_StatePopulationn;
namespace IndianStateProgramTest
{
    [TestClass]
    public class UnitTest1
    {
        string filePopulationPath = @"C:\Users\hp\Desktop\newBatch2\IndianStatesProgram\IndianStatesProgram\Files_StatePopulationn\StatePopulationFile.csv";
        string Incorrectfilepath = @"C:\Users\hp\Desktop\newBatch2\IndianStatesProgram\IndianStatesProgram\Files1_StatePopulationn\StatePopulationFile.csv";
        CSVStateCensus csv = new CSVStateCensus();
        /// <summary>
        /// Uc1 Check Record Count
        /// </summary>
        [TestMethod]
        public void EnsureTheNumber_Recordmatches_ShouldReturnMatches()
        {
            int actual = csv.ReadStateCencusData(filePopulationPath);
            Assert.AreEqual(28, actual);
        }
        /// <summary>
        /// Uc 1_2Test case For file is Exist or not
        /// </summary>
        [TestMethod]
        public void GivenStateCensusData_IncorrectFilepath_WhenAnalyzer_ShouldReturnExceptionMessage()
        {
            try
            {
                int Records = csv.ReadStateCencusData(Incorrectfilepath);
            }
            catch (ExceptionStateCensus ex)
            {
                Assert.AreEqual(ex.Message, "File path is incorrect");
            }
        }
    }
}