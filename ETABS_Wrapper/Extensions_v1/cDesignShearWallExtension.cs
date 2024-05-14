using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cDesignShearWallExtension
    {
		public static (string[] Story, string[] PierLabel, string[] Station, string[] DesignType, string[] PierSecType, string[] EdgeBar, string[] EndBar, double[] BarSpacing, double[] ReinfPercent, double[] CurrPercent, double[] DCRatio, string[] PierLeg, double[] LegX1, double[] LegY1, double[] LegX2, double[] LegY2, double[] EdgeLeft, double[] EdgeRight, double[] AsLeft, double[] AsRight, double[] ShearAv, double[] StressCompLeft, double[] StressCompRight, double[] StressLimitLeft, double[] StressLimitRight, double[] CDepthLeft, double[] CLimitLeft, double[] CDepthRight, double[] CLimitRight, double[] InelasticRotDemand, double[] InelasticRotCapacity, double[] NormCompStress, double[] NormCompStressLimit, double[] CDepth, double[] BZoneL, double[] BZoneR, double[] BZoneLength, string[] WarnMsg, string[] ErrMsg)
		    GetPierSummaryResults(this cDesignShearWall obj) {
			string[] Story, PierLabel, Station, DesignType, PierSecType, EdgeBar, EndBar, PierLeg, WarnMsg, ErrMsg;
			Story = PierLabel = Station = DesignType = PierSecType = EdgeBar = EndBar = PierLeg = WarnMsg = ErrMsg = default(string[]);
			double[] BarSpacing, ReinfPercent, CurrPercent, DCRatio, LegX1, LegY1, LegX2, LegY2, EdgeLeft, EdgeRight, AsLeft, AsRight, ShearAv, StressCompLeft, StressCompRight, StressLimitLeft, StressLimitRight, CDepthLeft, CLimitLeft, CDepthRight, CLimitRight, InelasticRotDemand, InelasticRotCapacity, NormCompStress, NormCompStressLimit, CDepth, BZoneL, BZoneR, BZoneLength;
			BarSpacing = ReinfPercent = CurrPercent = DCRatio = LegX1 = LegY1 = LegX2 = LegY2 = EdgeLeft = EdgeRight = AsLeft = AsRight = ShearAv = StressCompLeft = StressCompRight = StressLimitLeft = StressLimitRight = CDepthLeft = CLimitLeft = CDepthRight = CLimitRight = InelasticRotDemand = InelasticRotCapacity = NormCompStress = NormCompStressLimit = CDepth = BZoneL = BZoneR = BZoneLength = default(double[]);
		    var res = obj.GetPierSummaryResults(ref Story, ref PierLabel, ref Station, ref DesignType, ref PierSecType, ref EdgeBar, ref EndBar, ref BarSpacing, ref ReinfPercent, ref CurrPercent, ref DCRatio, ref PierLeg, ref LegX1, ref LegY1, ref LegX2, ref LegY2, ref EdgeLeft, ref EdgeRight, ref AsLeft, ref AsRight, ref ShearAv, ref StressCompLeft, ref StressCompRight, ref StressLimitLeft, ref StressLimitRight, ref CDepthLeft, ref CLimitLeft, ref CDepthRight, ref CLimitRight, ref InelasticRotDemand, ref InelasticRotCapacity, ref NormCompStress, ref NormCompStressLimit, ref CDepth, ref BZoneL, ref BZoneR, ref BZoneLength, ref WarnMsg, ref ErrMsg);
		    return (Story, PierLabel, Station, DesignType, PierSecType, EdgeBar, EndBar, BarSpacing, ReinfPercent, CurrPercent, DCRatio, PierLeg, LegX1, LegY1, LegX2, LegY2, EdgeLeft, EdgeRight, AsLeft, AsRight, ShearAv, StressCompLeft, StressCompRight, StressLimitLeft, StressLimitRight, CDepthLeft, CLimitLeft, CDepthRight, CLimitRight, InelasticRotDemand, InelasticRotCapacity, NormCompStress, NormCompStressLimit, CDepth, BZoneL, BZoneR, BZoneLength, WarnMsg, ErrMsg);
		}
		public static (string[] AreaObjName, string[] StoryName, string[] PierLabel, string[] StationLocation, string[] LegID, double[] LeftX1, double[] LeftY1, double[] RightX2, double[] RightY2, double[] Length, double[] Thickness, double[] fc, double[] fy, double[] fys, string[] Flexural, string[] ShearAndConfinement)
		    GetRebar(this cDesignShearWall obj) {
			string[] AreaObjName, StoryName, PierLabel, StationLocation, LegID, Flexural, ShearAndConfinement;
			AreaObjName = StoryName = PierLabel = StationLocation = LegID = Flexural = ShearAndConfinement = default(string[]);
			double[] LeftX1, LeftY1, RightX2, RightY2, Length, Thickness, fc, fy, fys;
			LeftX1 = LeftY1 = RightX2 = RightY2 = Length = Thickness = fc = fy = fys = default(double[]);
		    var res = obj.GetRebar(ref AreaObjName, ref StoryName, ref PierLabel, ref StationLocation, ref LegID, ref LeftX1, ref LeftY1, ref RightX2, ref RightY2, ref Length, ref Thickness, ref fc, ref fy, ref fys, ref Flexural, ref ShearAndConfinement);
		    return (AreaObjName, StoryName, PierLabel, StationLocation, LegID, LeftX1, LeftY1, RightX2, RightY2, Length, Thickness, fc, fy, fys, Flexural, ShearAndConfinement);
		}
		public static (string[] Story, string[] Spandrel, string[] Station, double[] TopRebar, double[] TopRebarRatio, string[] TopRebarCombo, double[] MuTop, double[] BotRebar, double[] BotRebarRatio, string[] BotRebarCombo, double[] MuBot, double[] AVert, double[] AHorz, string[] ShearCombo, double[] Vu, double[] ADiag, string[] ShearDiagCombo, double[] VuDiag, string[] WarnMsg, string[] ErrMsg)
		    GetSpandrelSummaryResults(this cDesignShearWall obj) {
			string[] Story, Spandrel, Station, TopRebarCombo, BotRebarCombo, ShearCombo, ShearDiagCombo, WarnMsg, ErrMsg;
			Story = Spandrel = Station = TopRebarCombo = BotRebarCombo = ShearCombo = ShearDiagCombo = WarnMsg = ErrMsg = default(string[]);
			double[] TopRebar, TopRebarRatio, MuTop, BotRebar, BotRebarRatio, MuBot, AVert, AHorz, Vu, ADiag, VuDiag;
			TopRebar = TopRebarRatio = MuTop = BotRebar = BotRebarRatio = MuBot = AVert = AHorz = Vu = ADiag = VuDiag = default(double[]);
		    var res = obj.GetSpandrelSummaryResults(ref Story, ref Spandrel, ref Station, ref TopRebar, ref TopRebarRatio, ref TopRebarCombo, ref MuTop, ref BotRebar, ref BotRebarRatio, ref BotRebarCombo, ref MuBot, ref AVert, ref AHorz, ref ShearCombo, ref Vu, ref ADiag, ref ShearDiagCombo, ref VuDiag, ref WarnMsg, ref ErrMsg);
		    return (Story, Spandrel, Station, TopRebar, TopRebarRatio, TopRebarCombo, MuTop, BotRebar, BotRebarRatio, BotRebarCombo, MuBot, AVert, AHorz, ShearCombo, Vu, ADiag, ShearDiagCombo, VuDiag, WarnMsg, ErrMsg);
		}
		public static string
		    GetRebarPrefsPier(this cDesignShearWall obj, int Item) {
			string Value;
			Value = default(string);
		    var res = obj.GetRebarPrefsPier(Item, ref Value);
		    return Value;
		}
		public static string
		    GetRebarPrefsSpandrel(this cDesignShearWall obj, int Item) {
			string Value;
			Value = default(string);
		    var res = obj.GetRebarPrefsSpandrel(Item, ref Value);
		    return Value;
		}

    }
}