using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cCaseModalEigenExtension
    {
		public static string
		    GetInitialCase(this cCaseModalEigen obj, string Name) {
			string InitialCase;
			InitialCase = default(string);
		    var res = obj.GetInitialCase(Name, ref InitialCase);
		    return InitialCase;
		}
		public static (int NumberLoads, string[] LoadType, string[] LoadName, double[] TargetPar, bool[] StaticCorrect)
		    GetLoads(this cCaseModalEigen obj, string Name) {
			int NumberLoads;
			NumberLoads = default(int);
			string[] LoadType, LoadName;
			LoadType = LoadName = default(string[]);
			double[] TargetPar;
			TargetPar = default(double[]);
			bool[] StaticCorrect;
			StaticCorrect = default(bool[]);
		    var res = obj.GetLoads(Name, ref NumberLoads, ref LoadType, ref LoadName, ref TargetPar, ref StaticCorrect);
		    return (NumberLoads, LoadType, LoadName, TargetPar, StaticCorrect);
		}
		public static (int MaxModes, int MinModes)
		    GetNumberModes(this cCaseModalEigen obj, string Name) {
			int MaxModes, MinModes;
			MaxModes = MinModes = default(int);
		    var res = obj.GetNumberModes(Name, ref MaxModes, ref MinModes);
		    return (MaxModes, MinModes);
		}
		public static (double EigenShiftFreq, double EigenCutOff, double EigenTol, int AllowAutoFreqShift)
		    GetParameters(this cCaseModalEigen obj, string Name) {
			double EigenShiftFreq, EigenCutOff, EigenTol;
			EigenShiftFreq = EigenCutOff = EigenTol = default(double);
			int AllowAutoFreqShift;
			AllowAutoFreqShift = default(int);
		    var res = obj.GetParameters(Name, ref EigenShiftFreq, ref EigenCutOff, ref EigenTol, ref AllowAutoFreqShift);
		    return (EigenShiftFreq, EigenCutOff, EigenTol, AllowAutoFreqShift);
		}

    }
}