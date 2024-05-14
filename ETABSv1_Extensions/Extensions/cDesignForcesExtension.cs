using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cDesignForcesExtension
    {
		public static (int NumberResults, string[] FrameName, string[] ComboName, double[] Station, double[] P, double[] V2, double[] V3, double[] T, double[] M2, double[] M3)
		    BeamDesignForces(this cDesignForces obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberResults;
			NumberResults = default(int);
			string[] FrameName, ComboName;
			FrameName = ComboName = default(string[]);
			double[] Station, P, V2, V3, T, M2, M3;
			Station = P = V2 = V3 = T = M2 = M3 = default(double[]);
		    var res = obj.BeamDesignForces(Name, ref NumberResults, ref FrameName, ref ComboName, ref Station, ref P, ref V2, ref V3, ref T, ref M2, ref M3, ItemType);
		    return (NumberResults, FrameName, ComboName, Station, P, V2, V3, T, M2, M3);
		}
		public static (int NumberResults, string[] FrameName, string[] ComboName, double[] Station, double[] P, double[] V2, double[] V3, double[] T, double[] M2, double[] M3)
		    BraceDesignForces(this cDesignForces obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberResults;
			NumberResults = default(int);
			string[] FrameName, ComboName;
			FrameName = ComboName = default(string[]);
			double[] Station, P, V2, V3, T, M2, M3;
			Station = P = V2 = V3 = T = M2 = M3 = default(double[]);
		    var res = obj.BraceDesignForces(Name, ref NumberResults, ref FrameName, ref ComboName, ref Station, ref P, ref V2, ref V3, ref T, ref M2, ref M3, ItemType);
		    return (NumberResults, FrameName, ComboName, Station, P, V2, V3, T, M2, M3);
		}
		public static (int NumberResults, string[] FrameName, string[] ComboName, double[] Station, double[] P, double[] V2, double[] V3, double[] T, double[] M2, double[] M3)
		    ColumnDesignForces(this cDesignForces obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberResults;
			NumberResults = default(int);
			string[] FrameName, ComboName;
			FrameName = ComboName = default(string[]);
			double[] Station, P, V2, V3, T, M2, M3;
			Station = P = V2 = V3 = T = M2 = M3 = default(double[]);
		    var res = obj.ColumnDesignForces(Name, ref NumberResults, ref FrameName, ref ComboName, ref Station, ref P, ref V2, ref V3, ref T, ref M2, ref M3, ItemType);
		    return (NumberResults, FrameName, ComboName, Station, P, V2, V3, T, M2, M3);
		}
		public static (int NumberResults, string[] Story, string[] PierLabel, string[] ComboName, string[] Location, double[] P, double[] V2, double[] V3, double[] T, double[] M2, double[] M3)
		    PierDesignForces(this cDesignForces obj, string InputPierLabel, string InputStoryName) {
			int NumberResults;
			NumberResults = default(int);
			string[] Story, PierLabel, ComboName, Location;
			Story = PierLabel = ComboName = Location = default(string[]);
			double[] P, V2, V3, T, M2, M3;
			P = V2 = V3 = T = M2 = M3 = default(double[]);
		    var res = obj.PierDesignForces(InputPierLabel, InputStoryName, ref NumberResults, ref Story, ref PierLabel, ref ComboName, ref Location, ref P, ref V2, ref V3, ref T, ref M2, ref M3);
		    return (NumberResults, Story, PierLabel, ComboName, Location, P, V2, V3, T, M2, M3);
		}
		public static (int NumberResults, string[] Story, string[] SpandrelLabel, string[] ComboName, string[] Location, double[] P, double[] V2, double[] V3, double[] T, double[] M2, double[] M3)
		    SpandrelDesignForces(this cDesignForces obj, string InputSpandrelLabel, string InputStoryName) {
			int NumberResults;
			NumberResults = default(int);
			string[] Story, SpandrelLabel, ComboName, Location;
			Story = SpandrelLabel = ComboName = Location = default(string[]);
			double[] P, V2, V3, T, M2, M3;
			P = V2 = V3 = T = M2 = M3 = default(double[]);
		    var res = obj.SpandrelDesignForces(InputSpandrelLabel, InputStoryName, ref NumberResults, ref Story, ref SpandrelLabel, ref ComboName, ref Location, ref P, ref V2, ref V3, ref T, ref M2, ref M3);
		    return (NumberResults, Story, SpandrelLabel, ComboName, Location, P, V2, V3, T, M2, M3);
		}

    }
}