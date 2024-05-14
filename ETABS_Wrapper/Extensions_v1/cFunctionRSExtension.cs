using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cFunctionRSExtension
    {
		public static (int ParamsOption, double Latitude, double Longitude, int Island, int LimitState, int UsageClass, double NomLife, double PeakAccel, double F0, double Tcs, int SpecType, int SoilType, int Topography, double hRatio, double Damping, double q)
		    GetNTC2008(this cFunctionRS obj, string Name) {
			int ParamsOption, Island, LimitState, UsageClass, SpecType, SoilType, Topography;
			ParamsOption = Island = LimitState = UsageClass = SpecType = SoilType = Topography = default(int);
			double Latitude, Longitude, NomLife, PeakAccel, F0, Tcs, hRatio, Damping, q;
			Latitude = Longitude = NomLife = PeakAccel = F0 = Tcs = hRatio = Damping = q = default(double);
		    var res = obj.GetNTC2008(Name, ref ParamsOption, ref Latitude, ref Longitude, ref Island, ref LimitState, ref UsageClass, ref NomLife, ref PeakAccel, ref F0, ref Tcs, ref SpecType, ref SoilType, ref Topography, ref hRatio, ref Damping, ref q);
		    return (ParamsOption, Latitude, Longitude, Island, LimitState, UsageClass, NomLife, PeakAccel, F0, Tcs, SpecType, SoilType, Topography, hRatio, Damping, q);
		}
		public static (int ParamsOption, double Latitude, double Longitude, int Island, int LimitState, int UsageClass, double NomLife, double PeakAccel, double F0, double Tcs, int SpecType, int SoilType, int Topography, double hRatio, double Damping, double q)
		    GetNTC2018(this cFunctionRS obj, string Name) {
			int ParamsOption, Island, LimitState, UsageClass, SpecType, SoilType, Topography;
			ParamsOption = Island = LimitState = UsageClass = SpecType = SoilType = Topography = default(int);
			double Latitude, Longitude, NomLife, PeakAccel, F0, Tcs, hRatio, Damping, q;
			Latitude = Longitude = NomLife = PeakAccel = F0 = Tcs = hRatio = Damping = q = default(double);
		    var res = obj.GetNTC2018(Name, ref ParamsOption, ref Latitude, ref Longitude, ref Island, ref LimitState, ref UsageClass, ref NomLife, ref PeakAccel, ref F0, ref Tcs, ref SpecType, ref SoilType, ref Topography, ref hRatio, ref Damping, ref q);
		    return (ParamsOption, Latitude, Longitude, Island, LimitState, UsageClass, NomLife, PeakAccel, F0, Tcs, SpecType, SoilType, Topography, hRatio, Damping, q);
		}

    }
}