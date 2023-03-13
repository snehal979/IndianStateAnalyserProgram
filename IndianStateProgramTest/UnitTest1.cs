using IndianStatesProgram;
using IndianStatesProgram.Files_StatePopulationn;
namespace IndianStateProgramTest
{
    [TestClass]
    public class UnitTest1
    {
        string filePopulationPath = @"C:\Users\hp\Desktop\newBatch2\IndianStatesProgram\IndianStatesProgram\Files_StatePopulationn\StatePopulationFile.csv";

        CSVStateCensus csv = new CSVStateCensus();
        [TestMethod]
        public void EnsureTheNumber_Recordmatches_ShouldReturnMatches()
        {
            int actual = csv.ReadStateCencusData(filePopulationPath);
            Assert.AreEqual(28, actual);
        }
    }
}