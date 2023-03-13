using IndianStatesProgram;
using IndianStatesProgram.Files_StatePopulationn;
namespace IndianStateProgramTest
{
    [TestClass]
    public class UnitTest1
    {
        string filePopulationPath = @"C:\Users\hp\Desktop\newBatch2\IndianStatesProgram\IndianStatesProgram\Files_StatePopulationn\StatePopulationFile.csv";
        string fileCodePath = @"C:\Users\hp\Desktop\newBatch2\IndianStatesProgram\IndianStatesProgram\FileIndianCodeState\StateCodeCorrectFile.csv";
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
        ////Uc1-4 TEST CASE FOR DELINE LINE 
        [DataRow(@"C:\Users\hp\Desktop\newBatch2\IndianStatesProgram\IndianStatesProgram\Files_StatePopulationn\delineFileStatePopulation.csv", "File deline is incorrect")]
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
        /// <summary>
        /// Uc1_5 test case for Header // Spealling mistake in file header name -pass correct file name 
        /// </summary>
        [TestMethod]
        [DataRow(@"C:\Users\hp\Desktop\newBatch2\IndianStatesProgram\IndianStatesProgram\Files_StatePopulationn\StatePopulationFile.csv", "File header is incorrect")]
        public void GivenStateCensusData_IncorrectHeader_WhenAnalyzer_ShouldReturnExceptionMessage(string Incorrectfile, string expectMsg)
        {
            try
            {
                bool record = csv.ReadStateDataHeader(Incorrectfile, "State/Population,AreaInSqKm,DensityPerSqKm");
                Assert.IsTrue(record);
            }
            catch (ExceptionStateCensus ex)
            {
                Assert.AreEqual(ex.Message, expectMsg);
            }
        }



        /// <summary>
        /// Uc 2.1 Indian code Analyzer
        /// </summary>
        [TestMethod]
        public void EnsureTheNumber_Recordmatches_ShouldReturnMatches_IndianCodeFile()
        {
            int actual = csv.ReadStae_CodeData(fileCodePath);
            Assert.AreEqual(36, actual);
        }

        /// <summary>
        /// Uc 2.2 Test case For file 
        /// </summary>
        [TestMethod]

        ////Uc 2_2Test case For file is Exist or not(incorrectpath)
        [DataRow(@"C:\Users\hp\Desktop\newBatch2\IndianStatesProgram\IndianStatesProgram\FileIndianCodeState1\StateCodeCorrectFile.csv", "File path is incorrect")]
        ////Uc2_3 Test case for incorrect file type
        [DataRow(@"C:\Users\hp\Desktop\newBatch2\IndianStatesProgram\IndianStatesProgram\FileIndianCodeState\StateCodeTxtFile.txt", "File type is incorrect")]
        ////Uc2-4 TEST CASE FOR DELINE LINE 
        [DataRow(@"C:\Users\hp\Desktop\newBatch2\IndianStatesProgram\IndianStatesProgram\FileIndianCodeState\stateCodeDelineFile.csv", "File deline is incorrect")]
        public void GivenStateCodeData_IncorrectFiledata_WhenAnalyzer_ShouldReturnExceptionMessage(string Incorrectfile, string expectMsg)
        {
            try
            {
                int Records = csv.ReadStae_CodeData(Incorrectfile);
            }
            catch (ExceptionStateCensus ex)
            {
                Assert.AreEqual(ex.Message, expectMsg);
            }
        }
        /// <summary>
        /// Uc1_5 test case for Header // Spealling mistake in file header name -pass correct file name 
        /// </summary>
        [TestMethod]
        [DataRow(@"C:\Users\hp\Desktop\newBatch2\IndianStatesProgram\IndianStatesProgram\FileIndianCodeState\stateCodeDelineFile.csv", "File header is incorrect")]
        public void GivenStateCodeData_IncorrectHeader_WhenAnalyzer_ShouldReturnExceptionMessage(string Incorrectfile, string expectMsg)
        {
            try
            {
                bool record = csv.ReadStateDataHeader(Incorrectfile, "SrNo,State,NameNos,TIN");
                Assert.IsTrue(record);
            }
            catch (ExceptionStateCensus ex)
            {
                Assert.AreEqual(ex.Message, expectMsg);
            }
        }
    }
}