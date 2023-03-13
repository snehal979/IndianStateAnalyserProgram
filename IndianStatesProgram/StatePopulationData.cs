using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesProgram.Files_StatePopulationn
{
    public class StatePopulationData
    {
        public string State { get; set; }
        public string Population { get; set; }
        public string AreaInSqKm { get; set; }
        public string DensityPerSqKm { get; set; }
    }
    /// <summary>
    /// Uc2
    /// </summary>
    public class CodeStateDOA
    {
        public int SrNo { get; set; }
        public string State { get; set; }
        public string NameNos { get; set; }
        public string TIN { get; set; }
    }
}
