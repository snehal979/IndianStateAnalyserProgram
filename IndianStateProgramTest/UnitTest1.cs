using IndianStatesProgram;
using IndianStatesProgram.Files_StatePopulationn;
namespace IndianStateProgramTest
{
    [TestClass]
    public class UnitTest1
    {
        string filePopulationPath = @"C:\Users\hp\Desktop\newBatch2\IndianStatesProgram\IndianStatesProgram\Files_StatePopulationn\StatePopulationFile.csv";

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
        /// Uc 1 Test case For file 
        /// </summary>
        [TestMethod]

        ////Uc 1_2Test case For file is Exist or not(incorrectpath)
        [DataRow(@"C:\Users\hp\Desktop\newBatch2\IndianStatesProgram\IndianStatesProgram\Files1_StatePopulationn\StatePopulationFile.csv", "File path is incorrect")]
        ////Uc1_3 Test case for incorrect file type
        [DataRow(@"C:\Users\hp\Desktop\newBatch2\IndianStatesProgram\IndianStatesProgram\Files_StatePopulationn\StateTxtFile.txt", "File type is incorrect")]
        public void GivenStateCensusData_IncorrectFiledata_WhenAnalyzer_ShouldReturnExceptionMessage(string Incorrectfile,string expectMsg)
        {
            try
            {
                int Records = csv.ReadStateCencusData(Incorrectfile);
            }
            catch (ExceptionStateCensus ex)
            {
                Assert.AreEqual(ex.Message, expectMsg);
            }
        }
    }
}