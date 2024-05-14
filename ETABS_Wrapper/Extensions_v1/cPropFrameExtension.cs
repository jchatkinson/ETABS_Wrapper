using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cPropFrameExtension
    {
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, int Color, string Notes, string GUID)
		    GetAngle(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw;
			T3 = T2 = Tf = Tw = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetAngle(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, Color, Notes, GUID);
		}
		public static (int NumberItems, string[] SectName, string AutoStartSection, string Notes, string GUID)
		    GetAutoSelectSteel(this cPropFrame obj, string Name) {
			int NumberItems;
			NumberItems = default(int);
			string[] SectName;
			SectName = default(string[]);
			string AutoStartSection, Notes, GUID;
			AutoStartSection = Notes = GUID = default(string);
		    var res = obj.GetAutoSelectSteel(Name, ref NumberItems, ref SectName, ref AutoStartSection, ref Notes, ref GUID);
		    return (NumberItems, SectName, AutoStartSection, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, int Color, string Notes, string GUID)
		    GetChannel(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw;
			T3 = T2 = Tf = Tw = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetChannel(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, int Color, string Notes, string GUID)
		    GetCircle(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3;
			T3 = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetCircle(Name, ref FileName, ref MatProp, ref T3, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, Color, Notes, GUID);
		}
		public static (string SectName, double FyTopFlange, double FyWeb, double FyBotFlange, double Tc, double Bc, string MatPropTop, double Tcb, double Bcb, string MatPropBot, int Color, string Notes, string GUID)
		    GetCoverPlatedI(this cPropFrame obj, string Name) {
			string SectName, MatPropTop, MatPropBot, Notes, GUID;
			SectName = MatPropTop = MatPropBot = Notes = GUID = default(string);
			double FyTopFlange, FyWeb, FyBotFlange, Tc, Bc, Tcb, Bcb;
			FyTopFlange = FyWeb = FyBotFlange = Tc = Bc = Tcb = Bcb = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetCoverPlatedI(Name, ref SectName, ref FyTopFlange, ref FyWeb, ref FyBotFlange, ref Tc, ref Bc, ref MatPropTop, ref Tcb, ref Bcb, ref MatPropBot, ref Color, ref Notes, ref GUID);
		    return (SectName, FyTopFlange, FyWeb, FyBotFlange, Tc, Bc, MatPropTop, Tcb, Bcb, MatPropBot, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, double Dis, int Color, string Notes, string GUID)
		    GetDblAngle(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw, Dis;
			T3 = T2 = Tf = Tw = Dis = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetDblAngle(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref Dis, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, Dis, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, double Dis, int Color, string Notes, string GUID)
		    GetDblChannel(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw, Dis;
			T3 = T2 = Tf = Tw = Dis = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetDblChannel(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref Dis, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, Dis, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Area, double As2, double As3, double Torsion, double I22, double I33, double S22, double S33, double Z22, double Z33, double R22, double R33, int Color, string Notes, string GUID)
		    GetGeneral(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Area, As2, As3, Torsion, I22, I33, S22, S33, Z22, Z33, R22, R33;
			T3 = T2 = Area = As2 = As3 = Torsion = I22 = I33 = S22 = S33 = Z22 = Z33 = R22 = R33 = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetGeneral(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Area, ref As2, ref As3, ref Torsion, ref I22, ref I33, ref S22, ref S33, ref Z22, ref Z33, ref R22, ref R33, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Area, As2, As3, Torsion, I22, I33, S22, S33, Z22, Z33, R22, R33, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, double T2b, double Tfb, int Color, string Notes, string GUID)
		    GetISection(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw, T2b, Tfb;
			T3 = T2 = Tf = Tw = T2b = Tfb = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetISection(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref T2b, ref Tfb, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, T2b, Tfb, Color, Notes, GUID);
		}
		public static double[]
		    GetModifiers(this cPropFrame obj, string Name) {
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetModifiers(Name, ref Value);
		    return Value;
		}
		public static (string NameInFile, string FileName, string MatProp, eFramePropType PropType)
		    GetNameInPropFile(this cPropFrame obj, string Name) {
			string NameInFile, FileName, MatProp;
			NameInFile = FileName = MatProp = default(string);
			eFramePropType PropType;
			PropType = default(eFramePropType);
		    var res = obj.GetNameInPropFile(Name, ref NameInFile, ref FileName, ref MatProp, ref PropType);
		    return (NameInFile, FileName, MatProp, PropType);
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cPropFrame obj, eFramePropType PropType = (eFramePropType)0) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName, PropType);
		    return (NumberNames, MyName);
		}
		public static (int NumberItems, string[] StartSec, string[] EndSec, double[] MyLength, int[] MyType, int[] EI33, int[] EI22, int Color, string Notes, string GUID)
		    GetNonPrismatic(this cPropFrame obj, string Name) {
			int NumberItems, Color;
			NumberItems = Color = default(int);
			string[] StartSec, EndSec;
			StartSec = EndSec = default(string[]);
			double[] MyLength;
			MyLength = default(double[]);
			int[] MyType, EI33, EI22;
			MyType = EI33 = EI22 = default(int[]);
			string Notes, GUID;
			Notes = GUID = default(string);
		    var res = obj.GetNonPrismatic(Name, ref NumberItems, ref StartSec, ref EndSec, ref MyLength, ref MyType, ref EI33, ref EI22, ref Color, ref Notes, ref GUID);
		    return (NumberItems, StartSec, EndSec, MyLength, MyType, EI33, EI22, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double TW, int Color, string Notes, string GUID)
		    GetPipe(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, TW;
			T3 = TW = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetPipe(Name, ref FileName, ref MatProp, ref T3, ref TW, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, TW, Color, Notes, GUID);
		}
		public static (int NumberNames, string[] MyName, eFramePropType[] MyPropType)
		    GetPropFileNameList(this cPropFrame obj, string FileName, eFramePropType PropType = (eFramePropType)0) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
			eFramePropType[] MyPropType;
			MyPropType = default(eFramePropType[]);
		    var res = obj.GetPropFileNameList(FileName, ref NumberNames, ref MyName, ref MyPropType, PropType);
		    return (NumberNames, MyName, MyPropType);
		}
		public static (string MatPropLong, string MatPropConfine, double CoverTop, double CoverBot, double TopLeftArea, double TopRightArea, double BotLeftArea, double BotRightArea)
		    GetRebarBeam(this cPropFrame obj, string Name) {
			string MatPropLong, MatPropConfine;
			MatPropLong = MatPropConfine = default(string);
			double CoverTop, CoverBot, TopLeftArea, TopRightArea, BotLeftArea, BotRightArea;
			CoverTop = CoverBot = TopLeftArea = TopRightArea = BotLeftArea = BotRightArea = default(double);
		    var res = obj.GetRebarBeam(Name, ref MatPropLong, ref MatPropConfine, ref CoverTop, ref CoverBot, ref TopLeftArea, ref TopRightArea, ref BotLeftArea, ref BotRightArea);
		    return (MatPropLong, MatPropConfine, CoverTop, CoverBot, TopLeftArea, TopRightArea, BotLeftArea, BotRightArea);
		}
		public static (string MatPropLong, string MatPropConfine, int Pattern, int ConfineType, double Cover, int NumberCBars, int NumberR3Bars, int NumberR2Bars, string RebarSize, string TieSize, double TieSpacingLongit, int Number2DirTieBars, int Number3DirTieBars, bool ToBeDesigned)
		    GetRebarColumn(this cPropFrame obj, string Name) {
			string MatPropLong, MatPropConfine, RebarSize, TieSize;
			MatPropLong = MatPropConfine = RebarSize = TieSize = default(string);
			int Pattern, ConfineType, NumberCBars, NumberR3Bars, NumberR2Bars, Number2DirTieBars, Number3DirTieBars;
			Pattern = ConfineType = NumberCBars = NumberR3Bars = NumberR2Bars = Number2DirTieBars = Number3DirTieBars = default(int);
			double Cover, TieSpacingLongit;
			Cover = TieSpacingLongit = default(double);
			bool ToBeDesigned;
			ToBeDesigned = default(bool);
		    var res = obj.GetRebarColumn(Name, ref MatPropLong, ref MatPropConfine, ref Pattern, ref ConfineType, ref Cover, ref NumberCBars, ref NumberR3Bars, ref NumberR2Bars, ref RebarSize, ref TieSize, ref TieSpacingLongit, ref Number2DirTieBars, ref Number3DirTieBars, ref ToBeDesigned);
		    return (MatPropLong, MatPropConfine, Pattern, ConfineType, Cover, NumberCBars, NumberR3Bars, NumberR2Bars, RebarSize, TieSize, TieSpacingLongit, Number2DirTieBars, Number3DirTieBars, ToBeDesigned);
		}
		public static (string FileName, string MatProp, double T3, double T2, int Color, string Notes, string GUID)
		    GetRectangle(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2;
			T3 = T2 = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetRectangle(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Color, Notes, GUID);
		}
		public static (double Area, double As2, double As3, double Torsion, double I22, double I33, double S22, double S33, double Z22, double Z33, double R22, double R33)
		    GetSectProps(this cPropFrame obj, string Name) {
			double Area, As2, As3, Torsion, I22, I33, S22, S33, Z22, Z33, R22, R33;
			Area = As2 = As3 = Torsion = I22 = I33 = S22 = S33 = Z22 = Z33 = R22 = R33 = default(double);
		    var res = obj.GetSectProps(Name, ref Area, ref As2, ref As3, ref Torsion, ref I22, ref I33, ref S22, ref S33, ref Z22, ref Z33, ref R22, ref R33);
		    return (Area, As2, As3, Torsion, I22, I33, S22, S33, Z22, Z33, R22, R33);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, int Color, string Notes, string GUID)
		    GetTee(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw;
			T3 = T2 = Tf = Tw = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetTee(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, int Color, string Notes, string GUID)
		    GetTube(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw;
			T3 = T2 = Tf = Tw = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetTube(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, Color, Notes, GUID);
		}
		public static eFramePropType
		    GetTypeOAPI(this cPropFrame obj, string Name) {
			eFramePropType PropType;
			PropType = default(eFramePropType);
		    var res = obj.GetTypeOAPI(Name, ref PropType);
		    return PropType;
		}
		public static int
		    GetTypeRebar(this cPropFrame obj, string Name) {
			int MyType;
			MyType = default(int);
		    var res = obj.GetTypeRebar(Name, ref MyType);
		    return MyType;
		}
		public static (string MatProp, int NumberItems, string[] ShapeName, int[] MyType, int DesignType, int Color, string Notes, string GUID)
		    GetSDSection(this cPropFrame obj, string Name) {
			string MatProp, Notes, GUID;
			MatProp = Notes = GUID = default(string);
			int NumberItems, DesignType, Color;
			NumberItems = DesignType = Color = default(int);
			string[] ShapeName;
			ShapeName = default(string[]);
			int[] MyType;
			MyType = default(int[]);
		    var res = obj.GetSDSection(Name, ref MatProp, ref NumberItems, ref ShapeName, ref MyType, ref DesignType, ref Color, ref Notes, ref GUID);
		    return (MatProp, NumberItems, ShapeName, MyType, DesignType, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Thickness, double Radius, double LipDepth, int Color, string Notes, string GUID)
		    GetColdC(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Thickness, Radius, LipDepth;
			T3 = T2 = Thickness = Radius = LipDepth = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetColdC(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Thickness, ref Radius, ref LipDepth, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Thickness, Radius, LipDepth, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Thickness, double Radius, double LipDepth, int Color, string Notes, string GUID)
		    GetColdHat(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Thickness, Radius, LipDepth;
			T3 = T2 = Thickness = Radius = LipDepth = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetColdHat(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Thickness, ref Radius, ref LipDepth, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Thickness, Radius, LipDepth, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Thickness, double Radius, double LipDepth, double LipAngle, int Color, string Notes, string GUID)
		    GetColdZ(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Thickness, Radius, LipDepth, LipAngle;
			T3 = T2 = Thickness = Radius = LipDepth = LipAngle = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetColdZ(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Thickness, ref Radius, ref LipDepth, ref LipAngle, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Thickness, Radius, LipDepth, LipAngle, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double[] b, double[] d, int Color, string Notes, string GUID)
		    GetPrecastI(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double[] b, d;
			b = d = default(double[]);
			int Color;
			Color = default(int);
		    var res = obj.GetPrecastI(Name, ref FileName, ref MatProp, ref b, ref d, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, b, d, Color, Notes, GUID);
		}
		public static string
		    GetMaterial(this cPropFrame obj, string Name) {
			string MatProp;
			MatProp = default(string);
		    var res = obj.GetMaterial(Name, ref MatProp);
		    return MatProp;
		}
		public static (string FileName, string MatProp, double T3, double T2, double T2b, int Color, string Notes, string GUID)
		    GetTrapezoidal(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, T2b;
			T3 = T2 = T2b = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetTrapezoidal(Name, ref FileName, ref MatProp, ref T3, ref T2, ref T2b, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, T2b, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, double Radius, int Color, string Notes, string GUID)
		    GetTube_1(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw, Radius;
			T3 = T2 = Tf = Tw = Radius = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetTube_1(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref Radius, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, Radius, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, double FilletRadius, int Color, string Notes, string GUID)
		    GetAngle_1(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw, FilletRadius;
			T3 = T2 = Tf = Tw = FilletRadius = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetAngle_1(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref FilletRadius, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, FilletRadius, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, double FilletRadius, bool MirrorAbout2, int Color, string Notes, string GUID)
		    GetChannel_2(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw, FilletRadius;
			T3 = T2 = Tf = Tw = FilletRadius = default(double);
			bool MirrorAbout2;
			MirrorAbout2 = default(bool);
			int Color;
			Color = default(int);
		    var res = obj.GetChannel_2(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref FilletRadius, ref MirrorAbout2, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, FilletRadius, MirrorAbout2, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, double Dis, double FilletRadius, bool MirrorAbout3, int Color, string Notes, string GUID)
		    GetDblAngle_2(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw, Dis, FilletRadius;
			T3 = T2 = Tf = Tw = Dis = FilletRadius = default(double);
			bool MirrorAbout3;
			MirrorAbout3 = default(bool);
			int Color;
			Color = default(int);
		    var res = obj.GetDblAngle_2(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref Dis, ref FilletRadius, ref MirrorAbout3, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, Dis, FilletRadius, MirrorAbout3, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, double Dis, double FilletRadius, int Color, string Notes, string GUID)
		    GetDblChannel_1(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw, Dis, FilletRadius;
			T3 = T2 = Tf = Tw = Dis = FilletRadius = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetDblChannel_1(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref Dis, ref FilletRadius, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, Dis, FilletRadius, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, double T2b, double Tfb, double FilletRadius, int Color, string Notes, string GUID)
		    GetISection_1(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw, T2b, Tfb, FilletRadius;
			T3 = T2 = Tf = Tw = T2b = Tfb = FilletRadius = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetISection_1(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref T2b, ref Tfb, ref FilletRadius, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, T2b, Tfb, FilletRadius, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, double FilletRadius, bool MirrorAbout3, int Color, string Notes, string GUID)
		    GetTee_1(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw, FilletRadius;
			T3 = T2 = Tf = Tw = FilletRadius = default(double);
			bool MirrorAbout3;
			MirrorAbout3 = default(bool);
			int Color;
			Color = default(int);
		    var res = obj.GetTee_1(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref FilletRadius, ref MirrorAbout3, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, FilletRadius, MirrorAbout3, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Area, double As2, double As3, double Torsion, double I22, double I33, double I23, double S22, double S33, double Z22, double Z33, double R22, double R33, double EccV2, double EccV3, int Color, string Notes, string GUID)
		    GetGeneral_1(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Area, As2, As3, Torsion, I22, I33, I23, S22, S33, Z22, Z33, R22, R33, EccV2, EccV3;
			T3 = T2 = Area = As2 = As3 = Torsion = I22 = I33 = I23 = S22 = S33 = Z22 = Z33 = R22 = R33 = EccV2 = EccV3 = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetGeneral_1(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Area, ref As2, ref As3, ref Torsion, ref I22, ref I33, ref I23, ref S22, ref S33, ref Z22, ref Z33, ref R22, ref R33, ref EccV2, ref EccV3, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Area, As2, As3, Torsion, I22, I33, I23, S22, S33, Z22, Z33, R22, R33, EccV2, EccV3, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double TwC, double TwT, bool MirrorAbout2, bool MirrorAbout3, int Color, string Notes, string GUID)
		    GetConcreteL(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, TwC, TwT;
			T3 = T2 = Tf = TwC = TwT = default(double);
			bool MirrorAbout2, MirrorAbout3;
			MirrorAbout2 = MirrorAbout3 = default(bool);
			int Color;
			Color = default(int);
		    var res = obj.GetConcreteL(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref TwC, ref TwT, ref MirrorAbout2, ref MirrorAbout3, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, TwC, TwT, MirrorAbout2, MirrorAbout3, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double TwF, double TwT, bool MirrorAbout3, int Color, string Notes, string GUID)
		    GetConcreteTee(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, TwF, TwT;
			T3 = T2 = Tf = TwF = TwT = default(double);
			bool MirrorAbout3;
			MirrorAbout3 = default(bool);
			int Color;
			Color = default(int);
		    var res = obj.GetConcreteTee(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref TwF, ref TwT, ref MirrorAbout3, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, TwF, TwT, MirrorAbout3, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, int Color, string Notes, string GUID)
		    GetPlate(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2;
			T3 = T2 = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetPlate(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, int Color, string Notes, string GUID)
		    GetRod(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3;
			T3 = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetRod(Name, ref FileName, ref MatProp, ref T3, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, double r, bool MirrorAbout2, bool MirrorAbout3, int Color, string Notes, string GUID)
		    GetSteelAngle(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw, r;
			T3 = T2 = Tf = Tw = r = default(double);
			bool MirrorAbout2, MirrorAbout3;
			MirrorAbout2 = MirrorAbout3 = default(bool);
			int Color;
			Color = default(int);
		    var res = obj.GetSteelAngle(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref r, ref MirrorAbout2, ref MirrorAbout3, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, r, MirrorAbout2, MirrorAbout3, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, double r, bool MirrorAbout3, int Color, string Notes, string GUID)
		    GetSteelTee(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw, r;
			T3 = T2 = Tf = Tw = r = default(double);
			bool MirrorAbout3;
			MirrorAbout3 = default(bool);
			int Color;
			Color = default(int);
		    var res = obj.GetSteelTee(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref r, ref MirrorAbout3, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, r, MirrorAbout3, Color, Notes, GUID);
		}
		public static (int NumberNames, string[] MyName, eFramePropType[] PropType, double[] t3, double[] t2, double[] tf, double[] tw, double[] t2b, double[] tfb)
		    GetAllFrameProperties(this cPropFrame obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
			eFramePropType[] PropType;
			PropType = default(eFramePropType[]);
			double[] t3, t2, tf, tw, t2b, tfb;
			t3 = t2 = tf = tw = t2b = tfb = default(double[]);
		    var res = obj.GetAllFrameProperties(ref NumberNames, ref MyName, ref PropType, ref t3, ref t2, ref tf, ref tw, ref t2b, ref tfb);
		    return (NumberNames, MyName, PropType, t3, t2, tf, tw, t2b, tfb);
		}
		public static (int NumberNames, string[] MyName, eFramePropType[] PropType, double[] t3, double[] t2, double[] tf, double[] tw, double[] t2b, double[] tfb, double[] Area)
		    GetAllFrameProperties_2(this cPropFrame obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
			eFramePropType[] PropType;
			PropType = default(eFramePropType[]);
			double[] t3, t2, tf, tw, t2b, tfb, Area;
			t3 = t2 = tf = tw = t2b = tfb = Area = default(double[]);
		    var res = obj.GetAllFrameProperties_2(ref NumberNames, ref MyName, ref PropType, ref t3, ref t2, ref tf, ref tw, ref t2b, ref tfb, ref Area);
		    return (NumberNames, MyName, PropType, t3, t2, tf, tw, t2b, tfb, Area);
		}
		public static (string MatPropLong, string MatPropConfine, int Pattern, int ConfineType, double Cover, int NumberCBars, int NumberR3Bars, int NumberR2Bars, string RebarSize, string TieSize, double TieSpacingLongit, int Number2DirTieBars, int Number3DirTieBars, bool ToBeDesigned, string LongitCornerRebarSize, double LongitRebarArea, double LongitCornerRebarArea)
		    GetRebarColumn_1(this cPropFrame obj, string Name) {
			string MatPropLong, MatPropConfine, RebarSize, TieSize, LongitCornerRebarSize;
			MatPropLong = MatPropConfine = RebarSize = TieSize = LongitCornerRebarSize = default(string);
			int Pattern, ConfineType, NumberCBars, NumberR3Bars, NumberR2Bars, Number2DirTieBars, Number3DirTieBars;
			Pattern = ConfineType = NumberCBars = NumberR3Bars = NumberR2Bars = Number2DirTieBars = Number3DirTieBars = default(int);
			double Cover, TieSpacingLongit, LongitRebarArea, LongitCornerRebarArea;
			Cover = TieSpacingLongit = LongitRebarArea = LongitCornerRebarArea = default(double);
			bool ToBeDesigned;
			ToBeDesigned = default(bool);
		    var res = obj.GetRebarColumn_1(Name, ref MatPropLong, ref MatPropConfine, ref Pattern, ref ConfineType, ref Cover, ref NumberCBars, ref NumberR3Bars, ref NumberR2Bars, ref RebarSize, ref TieSize, ref TieSpacingLongit, ref Number2DirTieBars, ref Number3DirTieBars, ref ToBeDesigned, ref LongitCornerRebarSize, ref LongitRebarArea, ref LongitCornerRebarArea);
		    return (MatPropLong, MatPropConfine, Pattern, ConfineType, Cover, NumberCBars, NumberR3Bars, NumberR2Bars, RebarSize, TieSize, TieSpacingLongit, Number2DirTieBars, Number3DirTieBars, ToBeDesigned, LongitCornerRebarSize, LongitRebarArea, LongitCornerRebarArea);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, int Color, string Notes, string GUID)
		    GetConcreteBox(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw;
			T3 = T2 = Tf = Tw = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetConcreteBox(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, int Color, string Notes, string GUID)
		    GetConcreteCross(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw;
			T3 = T2 = Tf = Tw = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetConcreteCross(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double Diameter, double Tw, int Color, string Notes, string GUID)
		    GetConcretePipe(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double Diameter, Tw;
			Diameter = Tw = default(double);
			int Color;
			Color = default(int);
		    var res = obj.GetConcretePipe(Name, ref FileName, ref MatProp, ref Diameter, ref Tw, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, Diameter, Tw, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, double Dis, bool MirrorAbout3, int Color, string Notes, string GUID)
		    GetDblAngle_1(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw, Dis;
			T3 = T2 = Tf = Tw = Dis = default(double);
			bool MirrorAbout3;
			MirrorAbout3 = default(bool);
			int Color;
			Color = default(int);
		    var res = obj.GetDblAngle_1(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref Dis, ref MirrorAbout3, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, Dis, MirrorAbout3, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Tf, double Tw, bool MirrorAbout2, int Color, string Notes, string GUID)
		    GetChannel_1(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Tf, Tw;
			T3 = T2 = Tf = Tw = default(double);
			bool MirrorAbout2;
			MirrorAbout2 = default(bool);
			int Color;
			Color = default(int);
		    var res = obj.GetChannel_1(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Tf, ref Tw, ref MirrorAbout2, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Tf, Tw, MirrorAbout2, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Thickness, double Radius, double LipDepth, bool MirrorAbout2, int Color, string Notes, string GUID)
		    GetColdC_1(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Thickness, Radius, LipDepth;
			T3 = T2 = Thickness = Radius = LipDepth = default(double);
			bool MirrorAbout2;
			MirrorAbout2 = default(bool);
			int Color;
			Color = default(int);
		    var res = obj.GetColdC_1(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Thickness, ref Radius, ref LipDepth, ref MirrorAbout2, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Thickness, Radius, LipDepth, MirrorAbout2, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Thickness, double Radius, double LipDepth, bool MirrorAbout2, int Color, string Notes, string GUID)
		    GetColdHat_1(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Thickness, Radius, LipDepth;
			T3 = T2 = Thickness = Radius = LipDepth = default(double);
			bool MirrorAbout2;
			MirrorAbout2 = default(bool);
			int Color;
			Color = default(int);
		    var res = obj.GetColdHat_1(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Thickness, ref Radius, ref LipDepth, ref MirrorAbout2, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Thickness, Radius, LipDepth, MirrorAbout2, Color, Notes, GUID);
		}
		public static (string FileName, string MatProp, double T3, double T2, double Thickness, double Radius, double LipDepth, double LipAngle, bool MirrorAbout2, int Color, string Notes, string GUID)
		    GetColdZ_1(this cPropFrame obj, string Name) {
			string FileName, MatProp, Notes, GUID;
			FileName = MatProp = Notes = GUID = default(string);
			double T3, T2, Thickness, Radius, LipDepth, LipAngle;
			T3 = T2 = Thickness = Radius = LipDepth = LipAngle = default(double);
			bool MirrorAbout2;
			MirrorAbout2 = default(bool);
			int Color;
			Color = default(int);
		    var res = obj.GetColdZ_1(Name, ref FileName, ref MatProp, ref T3, ref T2, ref Thickness, ref Radius, ref LipDepth, ref LipAngle, ref MirrorAbout2, ref Color, ref Notes, ref GUID);
		    return (FileName, MatProp, T3, T2, Thickness, Radius, LipDepth, LipAngle, MirrorAbout2, Color, Notes, GUID);
		}

    }
}