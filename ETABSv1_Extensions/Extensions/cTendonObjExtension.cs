using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cTendonObjExtension
    {
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cTendonObj obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static string
		    GetProperty(this cTendonObj obj, string Name) {
			string PropName;
			PropName = default(string);
		    var res = obj.GetProperty(Name, ref PropName);
		    return PropName;
		}
		public static bool
		    GetSelected(this cTendonObj obj, string Name) {
			bool Selected;
			Selected = default(bool);
		    var res = obj.GetSelected(Name, ref Selected);
		    return Selected;
		}
		public static (int NumberPoints, double[] X, double[] Y, double[] Z)
		    GetTendonGeometry(this cTendonObj obj, string Name, string CSys = "Global") {
			int NumberPoints;
			NumberPoints = default(int);
			double[] X, Y, Z;
			X = Y = Z = default(double[]);
		    var res = obj.GetTendonGeometry(Name, ref NumberPoints, ref X, ref Y, ref Z, CSys);
		    return (NumberPoints, X, Y, Z);
		}
		public static (int NumberGroups, string[] Groups)
		    GetGroupAssign(this cTendonObj obj, string Name) {
			int NumberGroups;
			NumberGroups = default(int);
			string[] Groups;
			Groups = default(string[]);
		    var res = obj.GetGroupAssign(Name, ref NumberGroups, ref Groups);
		    return (NumberGroups, Groups);
		}
		public static (int NumberNames, string[] MyName)
		    GetNameListOnStory(this cTendonObj obj, string StoryName) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameListOnStory(StoryName, ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (int NumberItems, string[] TendonName, string[] LoadPatFinal, string[] LoadPatTransfer, int[] JackFrom, int[] LoadType, double[] LoadValue, int[] LossSpecification)
		    GetLoadForceStress_1(this cTendonObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] TendonName, LoadPatFinal, LoadPatTransfer;
			TendonName = LoadPatFinal = LoadPatTransfer = default(string[]);
			int[] JackFrom, LoadType, LossSpecification;
			JackFrom = LoadType = LossSpecification = default(int[]);
			double[] LoadValue;
			LoadValue = default(double[]);
		    var res = obj.GetLoadForceStress_1(Name, ref NumberItems, ref TendonName, ref LoadPatFinal, ref LoadPatTransfer, ref JackFrom, ref LoadType, ref LoadValue, ref LossSpecification, ItemType);
		    return (NumberItems, TendonName, LoadPatFinal, LoadPatTransfer, JackFrom, LoadType, LoadValue, LossSpecification);
		}
		public static (int NumberItems, string[] TendonName, double[] CurvatureCoeff, double[] WobbleCoeff, double[] LossAnchorage, double[] LossShortening, double[] LossCreep, double[] LossShrinkage, double[] LossSteelRelax)
		    GetLossesDetailed(this cTendonObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] TendonName;
			TendonName = default(string[]);
			double[] CurvatureCoeff, WobbleCoeff, LossAnchorage, LossShortening, LossCreep, LossShrinkage, LossSteelRelax;
			CurvatureCoeff = WobbleCoeff = LossAnchorage = LossShortening = LossCreep = LossShrinkage = LossSteelRelax = default(double[]);
		    var res = obj.GetLossesDetailed(Name, ref NumberItems, ref TendonName, ref CurvatureCoeff, ref WobbleCoeff, ref LossAnchorage, ref LossShortening, ref LossCreep, ref LossShrinkage, ref LossSteelRelax, ItemType);
		    return (NumberItems, TendonName, CurvatureCoeff, WobbleCoeff, LossAnchorage, LossShortening, LossCreep, LossShrinkage, LossSteelRelax);
		}
		public static (int NumberItems, string[] TendonName, double[] StressingFixed, double[] LongTermFixed)
		    GetLossesFixed(this cTendonObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] TendonName;
			TendonName = default(string[]);
			double[] StressingFixed, LongTermFixed;
			StressingFixed = LongTermFixed = default(double[]);
		    var res = obj.GetLossesFixed(Name, ref NumberItems, ref TendonName, ref StressingFixed, ref LongTermFixed, ItemType);
		    return (NumberItems, TendonName, StressingFixed, LongTermFixed);
		}
		public static (int NumberItems, string[] TendonName, double[] StressingPercent, double[] LongTermPercent)
		    GetLossesPercent(this cTendonObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] TendonName;
			TendonName = default(string[]);
			double[] StressingPercent, LongTermPercent;
			StressingPercent = LongTermPercent = default(double[]);
		    var res = obj.GetLossesPercent(Name, ref NumberItems, ref TendonName, ref StressingPercent, ref LongTermPercent, ItemType);
		    return (NumberItems, TendonName, StressingPercent, LongTermPercent);
		}
		public static (int NumberItems, string[] TendonName, int[] NumberStrands)
		    GetNumberStrands(this cTendonObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] TendonName;
			TendonName = default(string[]);
			int[] NumberStrands;
			NumberStrands = default(int[]);
		    var res = obj.GetNumberStrands(Name, ref NumberItems, ref TendonName, ref NumberStrands, ItemType);
		    return (NumberItems, TendonName, NumberStrands);
		}
		public static (int NumberItems, string[] TendonName, double[] DatumOffset)
		    GetDatumOffset(this cTendonObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] TendonName;
			TendonName = default(string[]);
			double[] DatumOffset;
			DatumOffset = default(double[]);
		    var res = obj.GetDatumOffset(Name, ref NumberItems, ref TendonName, ref DatumOffset, ItemType);
		    return (NumberItems, TendonName, DatumOffset);
		}
		public static (int NumberItems, string[] TendonName, string[] DrawingPointID, double[] gx, double[] gy, double[] gz)
		    GetDrawingPoint(this cTendonObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] TendonName, DrawingPointID;
			TendonName = DrawingPointID = default(string[]);
			double[] gx, gy, gz;
			gx = gy = gz = default(double[]);
		    var res = obj.GetDrawingPoint(Name, ref NumberItems, ref TendonName, ref DrawingPointID, ref gx, ref gy, ref gz, ItemType);
		    return (NumberItems, TendonName, DrawingPointID, gx, gy, gz);
		}

    }
}