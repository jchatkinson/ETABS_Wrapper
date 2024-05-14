using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cDesignConcreteExtension
    {
		public static string
		    GetCode(this cDesignConcrete obj) {
			string CodeName;
			CodeName = default(string);
		    var res = obj.GetCode(ref CodeName);
		    return CodeName;
		}
		public static string
		    GetDesignSection(this cDesignConcrete obj, string Name) {
			string PropName;
			PropName = default(string);
		    var res = obj.GetDesignSection(Name, ref PropName);
		    return PropName;
		}
		public static (int NumberItems, string[] FrameName, double[] Location, string[] TopCombo, double[] TopArea, string[] BotCombo, double[] BotArea, string[] VMajorCombo, double[] VMajorArea, string[] TLCombo, double[] TLArea, string[] TTCombo, double[] TTArea, string[] ErrorSummary, string[] WarningSummary)
		    GetSummaryResultsBeam(this cDesignConcrete obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] FrameName, TopCombo, BotCombo, VMajorCombo, TLCombo, TTCombo, ErrorSummary, WarningSummary;
			FrameName = TopCombo = BotCombo = VMajorCombo = TLCombo = TTCombo = ErrorSummary = WarningSummary = default(string[]);
			double[] Location, TopArea, BotArea, VMajorArea, TLArea, TTArea;
			Location = TopArea = BotArea = VMajorArea = TLArea = TTArea = default(double[]);
		    var res = obj.GetSummaryResultsBeam(Name, ref NumberItems, ref FrameName, ref Location, ref TopCombo, ref TopArea, ref BotCombo, ref BotArea, ref VMajorCombo, ref VMajorArea, ref TLCombo, ref TLArea, ref TTCombo, ref TTArea, ref ErrorSummary, ref WarningSummary, ItemType);
		    return (NumberItems, FrameName, Location, TopCombo, TopArea, BotCombo, BotArea, VMajorCombo, VMajorArea, TLCombo, TLArea, TTCombo, TTArea, ErrorSummary, WarningSummary);
		}
		public static (int NumberItems, string[] FrameName, int[] MyOption, double[] Location, string[] PMMCombo, double[] PMMArea, double[] PMMRatio, string[] VMajorCombo, double[] AVMajor, string[] VMinorCombo, double[] AVMinor, string[] ErrorSummary, string[] WarningSummary)
		    GetSummaryResultsColumn(this cDesignConcrete obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] FrameName, PMMCombo, VMajorCombo, VMinorCombo, ErrorSummary, WarningSummary;
			FrameName = PMMCombo = VMajorCombo = VMinorCombo = ErrorSummary = WarningSummary = default(string[]);
			int[] MyOption;
			MyOption = default(int[]);
			double[] Location, PMMArea, PMMRatio, AVMajor, AVMinor;
			Location = PMMArea = PMMRatio = AVMajor = AVMinor = default(double[]);
		    var res = obj.GetSummaryResultsColumn(Name, ref NumberItems, ref FrameName, ref MyOption, ref Location, ref PMMCombo, ref PMMArea, ref PMMRatio, ref VMajorCombo, ref AVMajor, ref VMinorCombo, ref AVMinor, ref ErrorSummary, ref WarningSummary, ItemType);
		    return (NumberItems, FrameName, MyOption, Location, PMMCombo, PMMArea, PMMRatio, VMajorCombo, AVMajor, VMinorCombo, AVMinor, ErrorSummary, WarningSummary);
		}
		public static (int NumberItems, string[] FrameName, string[] LCJSRatioMajor, double[] JSRatioMajor, string[] LCJSRatioMinor, double[] JSRatioMinor, string[] LCBCCRatioMajor, double[] BCCRatioMajor, string[] LCBCCRatioMinor, double[] BCCRatioMinor, string[] ErrorSummary, string[] WarningSummary)
		    GetSummaryResultsJoint(this cDesignConcrete obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] FrameName, LCJSRatioMajor, LCJSRatioMinor, LCBCCRatioMajor, LCBCCRatioMinor, ErrorSummary, WarningSummary;
			FrameName = LCJSRatioMajor = LCJSRatioMinor = LCBCCRatioMajor = LCBCCRatioMinor = ErrorSummary = WarningSummary = default(string[]);
			double[] JSRatioMajor, JSRatioMinor, BCCRatioMajor, BCCRatioMinor;
			JSRatioMajor = JSRatioMinor = BCCRatioMajor = BCCRatioMinor = default(double[]);
		    var res = obj.GetSummaryResultsJoint(Name, ref NumberItems, ref FrameName, ref LCJSRatioMajor, ref JSRatioMajor, ref LCJSRatioMinor, ref JSRatioMinor, ref LCBCCRatioMajor, ref BCCRatioMajor, ref LCBCCRatioMinor, ref BCCRatioMinor, ref ErrorSummary, ref WarningSummary, ItemType);
		    return (NumberItems, FrameName, LCJSRatioMajor, JSRatioMajor, LCJSRatioMinor, JSRatioMinor, LCBCCRatioMajor, BCCRatioMajor, LCBCCRatioMinor, BCCRatioMinor, ErrorSummary, WarningSummary);
		}
		public static string
		    GetRebarPrefsBeam(this cDesignConcrete obj, int Item) {
			string Value;
			Value = default(string);
		    var res = obj.GetRebarPrefsBeam(Item, ref Value);
		    return Value;
		}
		public static string
		    GetRebarPrefsColumn(this cDesignConcrete obj, int Item) {
			string Value;
			Value = default(string);
		    var res = obj.GetRebarPrefsColumn(Item, ref Value);
		    return Value;
		}
		public static (int NumberItems, string[] FrameName, double[] Location, string[] TopCombo, double[] TopArea, double[] TopAreaReq, double[] TopAreaMin, double[] TopAreaProvided, string[] BotCombo, double[] BotArea, double[] BotAreaReq, double[] BotAreaMin, double[] BotAreaProvided, string[] VmajorCombo, double[] VmajorArea, double[] VmajorAreaReq, double[] VmajorAreaMin, double[] VmajorAreaProvided, string[] TLCombo, double[] TLArea, string[] TTCombo, double[] TTArea, string[] ErrorSummary, string[] WarningSummary)
		    GetSummaryResultsBeam_2(this cDesignConcrete obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] FrameName, TopCombo, BotCombo, VmajorCombo, TLCombo, TTCombo, ErrorSummary, WarningSummary;
			FrameName = TopCombo = BotCombo = VmajorCombo = TLCombo = TTCombo = ErrorSummary = WarningSummary = default(string[]);
			double[] Location, TopArea, TopAreaReq, TopAreaMin, TopAreaProvided, BotArea, BotAreaReq, BotAreaMin, BotAreaProvided, VmajorArea, VmajorAreaReq, VmajorAreaMin, VmajorAreaProvided, TLArea, TTArea;
			Location = TopArea = TopAreaReq = TopAreaMin = TopAreaProvided = BotArea = BotAreaReq = BotAreaMin = BotAreaProvided = VmajorArea = VmajorAreaReq = VmajorAreaMin = VmajorAreaProvided = TLArea = TTArea = default(double[]);
		    var res = obj.GetSummaryResultsBeam_2(Name, ref NumberItems, ref FrameName, ref Location, ref TopCombo, ref TopArea, ref TopAreaReq, ref TopAreaMin, ref TopAreaProvided, ref BotCombo, ref BotArea, ref BotAreaReq, ref BotAreaMin, ref BotAreaProvided, ref VmajorCombo, ref VmajorArea, ref VmajorAreaReq, ref VmajorAreaMin, ref VmajorAreaProvided, ref TLCombo, ref TLArea, ref TTCombo, ref TTArea, ref ErrorSummary, ref WarningSummary, ItemType);
		    return (NumberItems, FrameName, Location, TopCombo, TopArea, TopAreaReq, TopAreaMin, TopAreaProvided, BotCombo, BotArea, BotAreaReq, BotAreaMin, BotAreaProvided, VmajorCombo, VmajorArea, VmajorAreaReq, VmajorAreaMin, VmajorAreaProvided, TLCombo, TLArea, TTCombo, TTArea, ErrorSummary, WarningSummary);
		}
		public static (int NumberItems, string[] FrameName, int[] FramingType)
		    GetSeismicFramingType(this cDesignConcrete obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] FrameName;
			FrameName = default(string[]);
			int[] FramingType;
			FramingType = default(int[]);
		    var res = obj.GetSeismicFramingType(Name, ref NumberItems, ref FrameName, ref FramingType, ItemType);
		    return (NumberItems, FrameName, FramingType);
		}

    }
}