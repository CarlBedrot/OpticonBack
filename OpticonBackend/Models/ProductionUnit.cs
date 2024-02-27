using System;
using System.Collections.Generic;
namespace OpticonBackend.Models
{
    public class ProductionUnit : Component
    {
        public string StartType { get; set; }
        public int AuxiliaryPowerAbs { get; set; }
        public int AuxiliaryPowerRel { get; set; }
        public string AuxiliaryPowerForm { get; set; }
        public int MaxLoadChangeSpeed { get; set; }
        public double PreparationTimeHeat { get; set; }
        public double PreparationTimeWarm { get; set; }
        public double PreparationTimeCold { get; set; }
        public double CoolingTimeHeat { get; set; }
        public double CoolingTimeWarm { get; set; }
        public string MeasurePoint { get; set; }
        public bool StartRamp { get; set; }
        public string HeatStartRamp { get; set; }
        public string ColdStartRamp { get; set; }
        public double LoadInterval { get; set; }
        public int Performance { get; set; }
    }
}