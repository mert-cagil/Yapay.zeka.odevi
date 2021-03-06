// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace ConsoleApp9ML.Model
{
    public class ModelInput
    {
        [ColumnName("HomeTeam"), LoadColumn(0)]
        public string HomeTeam { get; set; }


        [ColumnName("AwayTeam"), LoadColumn(1)]
        public string AwayTeam { get; set; }


        [ColumnName("FTHomeGol"), LoadColumn(2)]
        public float FTHomeGol { get; set; }


        [ColumnName("FTAwayGol"), LoadColumn(3)]
        public float FTAwayGol { get; set; }


        [ColumnName("HomeShot"), LoadColumn(4)]
        public float HomeShot { get; set; }


        [ColumnName("AwayShot"), LoadColumn(5)]
        public float AwayShot { get; set; }


        [ColumnName("HomeCorner"), LoadColumn(6)]
        public float HomeCorner { get; set; }


        [ColumnName("AwayCorner"), LoadColumn(7)]
        public float AwayCorner { get; set; }


    }
}
