using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cCaseModalRitzExtension
    {
		public static string
		    GetInitialCase(this cCaseModalRitz obj, string Name) {
			string InitialCase;
			InitialCase = default(string);
		    var res = obj.GetInitialCase(Name, ref InitialCase);
		    return InitialCase;
		}
		public static (int NumberLoads, string[] LoadType, string[] LoadName, int[] RitzMaxCyc, double[] TargetPar)
		    GetLoads(this cCaseModalRitz obj, string Name) {
			int NumberLoads;
			NumberLoads = default(int);
			string[] LoadType, LoadName;
			LoadType = LoadName = default(string[]);
			int[] RitzMaxCyc;
			RitzMaxCyc = default(int[]);
			double[] TargetPar;
			TargetPar = default(double[]);
		    var res = obj.GetLoads(Name, ref NumberLoads, ref LoadType, ref LoadName, ref RitzMaxCyc, ref TargetPar);
		    return (NumberLoads, LoadType, LoadName, RitzMaxCyc, TargetPar);
		}
		public static (int MaxModes, int MinModes)
		    GetNumberModes(this cCaseModalRitz obj, string Name) {
			int MaxModes, MinModes;
			MaxModes = MinModes = default(int);
		    var res = obj.GetNumberModes(Name, ref MaxModes, ref MinModes);
		    return (MaxModes, MinModes);
		}

    }
}