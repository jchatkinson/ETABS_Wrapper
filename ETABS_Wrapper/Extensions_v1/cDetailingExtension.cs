using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cDetailingExtension
    {
		public static (int NumberItems, string[] BeamLineIDs)
		    GetDetailedBeamLines(this cDetailing obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] BeamLineIDs;
			BeamLineIDs = default(string[]);
		    var res = obj.GetDetailedBeamLines(ref NumberItems, ref BeamLineIDs);
		    return (NumberItems, BeamLineIDs);
		}
		public static (string[] ObjectUniqueNames, int NumberSpans, double[] SpanLength, int[] NumLongBars, double[] LongBarDiameter, string[] LongBarNotation, double[] LongBarStartDist, int[] LongBarStartBend, int[] LongBarEndBend, double[] LongBarLength, int[] LongBarNumLayers, int[] NumTieBars, int[] NumTieVertLegs, double[] TieBarDiameter, string[] TieBarNotation, double[] TieBarStartDist, double[] TieBarSpacing, int[] TieBarType)
		    GetDetailedBeamLineData(this cDetailing obj, string BeamLineID) {
			string[] ObjectUniqueNames, LongBarNotation, TieBarNotation;
			ObjectUniqueNames = LongBarNotation = TieBarNotation = default(string[]);
			int NumberSpans;
			NumberSpans = default(int);
			double[] SpanLength, LongBarDiameter, LongBarStartDist, LongBarLength, TieBarDiameter, TieBarStartDist, TieBarSpacing;
			SpanLength = LongBarDiameter = LongBarStartDist = LongBarLength = TieBarDiameter = TieBarStartDist = TieBarSpacing = default(double[]);
			int[] NumLongBars, LongBarStartBend, LongBarEndBend, LongBarNumLayers, NumTieBars, NumTieVertLegs, TieBarType;
			NumLongBars = LongBarStartBend = LongBarEndBend = LongBarNumLayers = NumTieBars = NumTieVertLegs = TieBarType = default(int[]);
		    var res = obj.GetDetailedBeamLineData(BeamLineID, ref ObjectUniqueNames, ref NumberSpans, ref SpanLength, ref NumLongBars, ref LongBarDiameter, ref LongBarNotation, ref LongBarStartDist, ref LongBarStartBend, ref LongBarEndBend, ref LongBarLength, ref LongBarNumLayers, ref NumTieBars, ref NumTieVertLegs, ref TieBarDiameter, ref TieBarNotation, ref TieBarStartDist, ref TieBarSpacing, ref TieBarType);
		    return (ObjectUniqueNames, NumberSpans, SpanLength, NumLongBars, LongBarDiameter, LongBarNotation, LongBarStartDist, LongBarStartBend, LongBarEndBend, LongBarLength, LongBarNumLayers, NumTieBars, NumTieVertLegs, TieBarDiameter, TieBarNotation, TieBarStartDist, TieBarSpacing, TieBarType);
		}
		public static (string[] ObjectUniqueNames, int NumberSpans, double[] SpanLength, int[] NumLongBars, string[] LongBarGUID, double[] LongBarDiameter, string[] LongBarNotation, double[] LongBarStartDist, int[] LongBarStartBend, int[] LongBarEndBend, double[] LongBarLength, int[] LongBarNumLayers, int[] NumTieBars, int[] NumTieVertLegs, string[] TieBarGUID, double[] TieBarDiameter, string[] TieBarNotation, double[] TieBarStartDist, double[] TieBarSpacing, int[] TieBarType)
		    GetDetailedBeamLineData_1(this cDetailing obj, string BeamLineID) {
			string[] ObjectUniqueNames, LongBarGUID, LongBarNotation, TieBarGUID, TieBarNotation;
			ObjectUniqueNames = LongBarGUID = LongBarNotation = TieBarGUID = TieBarNotation = default(string[]);
			int NumberSpans;
			NumberSpans = default(int);
			double[] SpanLength, LongBarDiameter, LongBarStartDist, LongBarLength, TieBarDiameter, TieBarStartDist, TieBarSpacing;
			SpanLength = LongBarDiameter = LongBarStartDist = LongBarLength = TieBarDiameter = TieBarStartDist = TieBarSpacing = default(double[]);
			int[] NumLongBars, LongBarStartBend, LongBarEndBend, LongBarNumLayers, NumTieBars, NumTieVertLegs, TieBarType;
			NumLongBars = LongBarStartBend = LongBarEndBend = LongBarNumLayers = NumTieBars = NumTieVertLegs = TieBarType = default(int[]);
		    var res = obj.GetDetailedBeamLineData_1(BeamLineID, ref ObjectUniqueNames, ref NumberSpans, ref SpanLength, ref NumLongBars, ref LongBarGUID, ref LongBarDiameter, ref LongBarNotation, ref LongBarStartDist, ref LongBarStartBend, ref LongBarEndBend, ref LongBarLength, ref LongBarNumLayers, ref NumTieBars, ref NumTieVertLegs, ref TieBarGUID, ref TieBarDiameter, ref TieBarNotation, ref TieBarStartDist, ref TieBarSpacing, ref TieBarType);
		    return (ObjectUniqueNames, NumberSpans, SpanLength, NumLongBars, LongBarGUID, LongBarDiameter, LongBarNotation, LongBarStartDist, LongBarStartBend, LongBarEndBend, LongBarLength, LongBarNumLayers, NumTieBars, NumTieVertLegs, TieBarGUID, TieBarDiameter, TieBarNotation, TieBarStartDist, TieBarSpacing, TieBarType);
		}
		public static (int NumberItems, string[] ColumnStackIDs)
		    GetDetailedColumnStacks(this cDetailing obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] ColumnStackIDs;
			ColumnStackIDs = default(string[]);
		    var res = obj.GetDetailedColumnStacks(ref NumberItems, ref ColumnStackIDs);
		    return (NumberItems, ColumnStackIDs);
		}
		public static (string[] ObjectUniqueNames, int NumLongBarSets, int[] NumLongBars, double[] LongBarDiameter, string[] LongBarNotation, double[] LongBarStartDist, int[] LongBarStartBend, int[] LongBarEndBend, double[] LongBarLength, int[] LongBarNumLayers, int NumTieZones, string[] TieBarZones, int[] NumTieBars, int[] NumTieVertLegs, double[] TieBarDiameter, string[] TieBarNotation, double[] TieBarStartDist, double[] TieBarSpacing, int[] TieBarType)
		    GetDetailedColumnStackData(this cDetailing obj, string ColumnStackID) {
			string[] ObjectUniqueNames, LongBarNotation, TieBarZones, TieBarNotation;
			ObjectUniqueNames = LongBarNotation = TieBarZones = TieBarNotation = default(string[]);
			int NumLongBarSets, NumTieZones;
			NumLongBarSets = NumTieZones = default(int);
			int[] NumLongBars, LongBarStartBend, LongBarEndBend, LongBarNumLayers, NumTieBars, NumTieVertLegs, TieBarType;
			NumLongBars = LongBarStartBend = LongBarEndBend = LongBarNumLayers = NumTieBars = NumTieVertLegs = TieBarType = default(int[]);
			double[] LongBarDiameter, LongBarStartDist, LongBarLength, TieBarDiameter, TieBarStartDist, TieBarSpacing;
			LongBarDiameter = LongBarStartDist = LongBarLength = TieBarDiameter = TieBarStartDist = TieBarSpacing = default(double[]);
		    var res = obj.GetDetailedColumnStackData(ColumnStackID, ref ObjectUniqueNames, ref NumLongBarSets, ref NumLongBars, ref LongBarDiameter, ref LongBarNotation, ref LongBarStartDist, ref LongBarStartBend, ref LongBarEndBend, ref LongBarLength, ref LongBarNumLayers, ref NumTieZones, ref TieBarZones, ref NumTieBars, ref NumTieVertLegs, ref TieBarDiameter, ref TieBarNotation, ref TieBarStartDist, ref TieBarSpacing, ref TieBarType);
		    return (ObjectUniqueNames, NumLongBarSets, NumLongBars, LongBarDiameter, LongBarNotation, LongBarStartDist, LongBarStartBend, LongBarEndBend, LongBarLength, LongBarNumLayers, NumTieZones, TieBarZones, NumTieBars, NumTieVertLegs, TieBarDiameter, TieBarNotation, TieBarStartDist, TieBarSpacing, TieBarType);
		}
		public static (string[] ObjectUniqueNames, int NumLongBarSets, int[] NumLongBars, string[] LongBarGUID, double[] LongBarDiameter, string[] LongBarNotation, double[] LongBarStartDist, int[] LongBarStartBend, int[] LongBarEndBend, double[] LongBarLength, int[] LongBarNumLayers, int NumTieZones, string[] TieBarZones, int[] NumTieBars, int[] NumTieHorLegs, int[] NumTieVertLegs, string[] TieBarGUID, double[] TieBarDiameter, string[] TieBarNotation, double[] TieBarStartDist, double[] TieBarSpacing, int[] TieBarType)
		    GetDetailedColumnStackData_1(this cDetailing obj, string ColumnStackID) {
			string[] ObjectUniqueNames, LongBarGUID, LongBarNotation, TieBarZones, TieBarGUID, TieBarNotation;
			ObjectUniqueNames = LongBarGUID = LongBarNotation = TieBarZones = TieBarGUID = TieBarNotation = default(string[]);
			int NumLongBarSets, NumTieZones;
			NumLongBarSets = NumTieZones = default(int);
			int[] NumLongBars, LongBarStartBend, LongBarEndBend, LongBarNumLayers, NumTieBars, NumTieHorLegs, NumTieVertLegs, TieBarType;
			NumLongBars = LongBarStartBend = LongBarEndBend = LongBarNumLayers = NumTieBars = NumTieHorLegs = NumTieVertLegs = TieBarType = default(int[]);
			double[] LongBarDiameter, LongBarStartDist, LongBarLength, TieBarDiameter, TieBarStartDist, TieBarSpacing;
			LongBarDiameter = LongBarStartDist = LongBarLength = TieBarDiameter = TieBarStartDist = TieBarSpacing = default(double[]);
		    var res = obj.GetDetailedColumnStackData_1(ColumnStackID, ref ObjectUniqueNames, ref NumLongBarSets, ref NumLongBars, ref LongBarGUID, ref LongBarDiameter, ref LongBarNotation, ref LongBarStartDist, ref LongBarStartBend, ref LongBarEndBend, ref LongBarLength, ref LongBarNumLayers, ref NumTieZones, ref TieBarZones, ref NumTieBars, ref NumTieHorLegs, ref NumTieVertLegs, ref TieBarGUID, ref TieBarDiameter, ref TieBarNotation, ref TieBarStartDist, ref TieBarSpacing, ref TieBarType);
		    return (ObjectUniqueNames, NumLongBarSets, NumLongBars, LongBarGUID, LongBarDiameter, LongBarNotation, LongBarStartDist, LongBarStartBend, LongBarEndBend, LongBarLength, LongBarNumLayers, NumTieZones, TieBarZones, NumTieBars, NumTieHorLegs, NumTieVertLegs, TieBarGUID, TieBarDiameter, TieBarNotation, TieBarStartDist, TieBarSpacing, TieBarType);
		}
		public static (int NumberItems, string[] Names, double[] SlabElevations, string[] GUIDs)
		    GetDetailedSlabs(this cDetailing obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] Names, GUIDs;
			Names = GUIDs = default(string[]);
			double[] SlabElevations;
			SlabElevations = default(double[]);
		    var res = obj.GetDetailedSlabs(ref NumberItems, ref Names, ref SlabElevations, ref GUIDs);
		    return (NumberItems, Names, SlabElevations, GUIDs);
		}
		public static (int NumData, string[] Names, int[] NumBars, double[] BarDiameter, string[] BarNotation, string[] BarMaterial, double[] StartX, double[] StartY, double[] StartZ, double[] EndX, double[] EndY, double[] EndZ, double[] WidthLeft, double[] WidthRight, double[] OffsetFromTop, double[] OffsetFromBot, int[] StartBarBend, int[] EndBarBend, string[] GUIDs)
		    GetDetailedSlabBotBarData(this cDetailing obj, string SlabName) {
			int NumData;
			NumData = default(int);
			string[] Names, BarNotation, BarMaterial, GUIDs;
			Names = BarNotation = BarMaterial = GUIDs = default(string[]);
			int[] NumBars, StartBarBend, EndBarBend;
			NumBars = StartBarBend = EndBarBend = default(int[]);
			double[] BarDiameter, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot;
			BarDiameter = StartX = StartY = StartZ = EndX = EndY = EndZ = WidthLeft = WidthRight = OffsetFromTop = OffsetFromBot = default(double[]);
		    var res = obj.GetDetailedSlabBotBarData(SlabName, ref NumData, ref Names, ref NumBars, ref BarDiameter, ref BarNotation, ref BarMaterial, ref StartX, ref StartY, ref StartZ, ref EndX, ref EndY, ref EndZ, ref WidthLeft, ref WidthRight, ref OffsetFromTop, ref OffsetFromBot, ref StartBarBend, ref EndBarBend, ref GUIDs);
		    return (NumData, Names, NumBars, BarDiameter, BarNotation, BarMaterial, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot, StartBarBend, EndBarBend, GUIDs);
		}
		public static (int NumData, string[] Names, int[] NumBars, double[] BarDiameter, string[] BarNotation, string[] BarMaterial, double[] StartX, double[] StartY, double[] StartZ, double[] EndX, double[] EndY, double[] EndZ, double[] WidthLeft, double[] WidthRight, double[] OffsetFromTop, double[] OffsetFromBot, int[] StartBarBend, int[] EndBarBend, string[] GUIDs, string[] StripNames, int[] SpanNos)
		    GetDetailedSlabBotBarData_1(this cDetailing obj, string SlabName) {
			int NumData;
			NumData = default(int);
			string[] Names, BarNotation, BarMaterial, GUIDs, StripNames;
			Names = BarNotation = BarMaterial = GUIDs = StripNames = default(string[]);
			int[] NumBars, StartBarBend, EndBarBend, SpanNos;
			NumBars = StartBarBend = EndBarBend = SpanNos = default(int[]);
			double[] BarDiameter, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot;
			BarDiameter = StartX = StartY = StartZ = EndX = EndY = EndZ = WidthLeft = WidthRight = OffsetFromTop = OffsetFromBot = default(double[]);
		    var res = obj.GetDetailedSlabBotBarData_1(SlabName, ref NumData, ref Names, ref NumBars, ref BarDiameter, ref BarNotation, ref BarMaterial, ref StartX, ref StartY, ref StartZ, ref EndX, ref EndY, ref EndZ, ref WidthLeft, ref WidthRight, ref OffsetFromTop, ref OffsetFromBot, ref StartBarBend, ref EndBarBend, ref GUIDs, ref StripNames, ref SpanNos);
		    return (NumData, Names, NumBars, BarDiameter, BarNotation, BarMaterial, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot, StartBarBend, EndBarBend, GUIDs, StripNames, SpanNos);
		}
		public static (int NumData, string[] Names, int[] NumBars, double[] BarDiameter, string[] BarNotation, string[] BarMaterial, double[] StartX, double[] StartY, double[] StartZ, double[] EndX, double[] EndY, double[] EndZ, double[] WidthLeft, double[] WidthRight, double[] OffsetFromTop, double[] OffsetFromBot, int[] StartBarBend, int[] EndBarBend, string[] GUIDs)
		    GetDetailedSlabTopBarData(this cDetailing obj, string SlabName) {
			int NumData;
			NumData = default(int);
			string[] Names, BarNotation, BarMaterial, GUIDs;
			Names = BarNotation = BarMaterial = GUIDs = default(string[]);
			int[] NumBars, StartBarBend, EndBarBend;
			NumBars = StartBarBend = EndBarBend = default(int[]);
			double[] BarDiameter, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot;
			BarDiameter = StartX = StartY = StartZ = EndX = EndY = EndZ = WidthLeft = WidthRight = OffsetFromTop = OffsetFromBot = default(double[]);
		    var res = obj.GetDetailedSlabTopBarData(SlabName, ref NumData, ref Names, ref NumBars, ref BarDiameter, ref BarNotation, ref BarMaterial, ref StartX, ref StartY, ref StartZ, ref EndX, ref EndY, ref EndZ, ref WidthLeft, ref WidthRight, ref OffsetFromTop, ref OffsetFromBot, ref StartBarBend, ref EndBarBend, ref GUIDs);
		    return (NumData, Names, NumBars, BarDiameter, BarNotation, BarMaterial, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot, StartBarBend, EndBarBend, GUIDs);
		}
		public static (int NumData, string[] Names, int[] NumBars, double[] BarDiameter, string[] BarNotation, string[] BarMaterial, double[] StartX, double[] StartY, double[] StartZ, double[] EndX, double[] EndY, double[] EndZ, double[] WidthLeft, double[] WidthRight, double[] OffsetFromTop, double[] OffsetFromBot, int[] StartBarBend, int[] EndBarBend, string[] GUIDs, string[] StripNames, int[] SpanNos)
		    GetDetailedSlabTopBarData_1(this cDetailing obj, string SlabName) {
			int NumData;
			NumData = default(int);
			string[] Names, BarNotation, BarMaterial, GUIDs, StripNames;
			Names = BarNotation = BarMaterial = GUIDs = StripNames = default(string[]);
			int[] NumBars, StartBarBend, EndBarBend, SpanNos;
			NumBars = StartBarBend = EndBarBend = SpanNos = default(int[]);
			double[] BarDiameter, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot;
			BarDiameter = StartX = StartY = StartZ = EndX = EndY = EndZ = WidthLeft = WidthRight = OffsetFromTop = OffsetFromBot = default(double[]);
		    var res = obj.GetDetailedSlabTopBarData_1(SlabName, ref NumData, ref Names, ref NumBars, ref BarDiameter, ref BarNotation, ref BarMaterial, ref StartX, ref StartY, ref StartZ, ref EndX, ref EndY, ref EndZ, ref WidthLeft, ref WidthRight, ref OffsetFromTop, ref OffsetFromBot, ref StartBarBend, ref EndBarBend, ref GUIDs, ref StripNames, ref SpanNos);
		    return (NumData, Names, NumBars, BarDiameter, BarNotation, BarMaterial, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot, StartBarBend, EndBarBend, GUIDs, StripNames, SpanNos);
		}
		public static (int NumberSimilarBeams, int[] NumberUniqueObjects, string[] ObjectUniqueNames)
		    GetSimilarBeamLines(this cDetailing obj, string BeamLineID) {
			int NumberSimilarBeams;
			NumberSimilarBeams = default(int);
			int[] NumberUniqueObjects;
			NumberUniqueObjects = default(int[]);
			string[] ObjectUniqueNames;
			ObjectUniqueNames = default(string[]);
		    var res = obj.GetSimilarBeamLines(BeamLineID, ref NumberSimilarBeams, ref NumberUniqueObjects, ref ObjectUniqueNames);
		    return (NumberSimilarBeams, NumberUniqueObjects, ObjectUniqueNames);
		}
		public static (int NumberSimilarColumns, int[] NumberUniqueObjects, string[] ObjectUniqueNames)
		    GetSimilarColumnStacks(this cDetailing obj, string ColumnStackID) {
			int NumberSimilarColumns;
			NumberSimilarColumns = default(int);
			int[] NumberUniqueObjects;
			NumberUniqueObjects = default(int[]);
			string[] ObjectUniqueNames;
			ObjectUniqueNames = default(string[]);
		    var res = obj.GetSimilarColumnStacks(ColumnStackID, ref NumberSimilarColumns, ref NumberUniqueObjects, ref ObjectUniqueNames);
		    return (NumberSimilarColumns, NumberUniqueObjects, ObjectUniqueNames);
		}
		public static (int NumberSimilarSlabs, string[] Names)
		    GetSimilarSlabs(this cDetailing obj, string SlabName) {
			int NumberSimilarSlabs;
			NumberSimilarSlabs = default(int);
			string[] Names;
			Names = default(string[]);
		    var res = obj.GetSimilarSlabs(SlabName, ref NumberSimilarSlabs, ref Names);
		    return (NumberSimilarSlabs, Names);
		}
		public static (int NumberRebarSets, string[] BarSizeName, double[] BarArea, int[] NumberBars, string[] Location, double[] ClearCover, double[] StartCoord1, double[] BarLength, double[] BendingAngleStart, double[] BendingAngleEnd, string[] RebarSetGUID)
		    GetBeamLongRebarData(this cDetailing obj, string Name) {
			int NumberRebarSets;
			NumberRebarSets = default(int);
			string[] BarSizeName, Location, RebarSetGUID;
			BarSizeName = Location = RebarSetGUID = default(string[]);
			double[] BarArea, ClearCover, StartCoord1, BarLength, BendingAngleStart, BendingAngleEnd;
			BarArea = ClearCover = StartCoord1 = BarLength = BendingAngleStart = BendingAngleEnd = default(double[]);
			int[] NumberBars;
			NumberBars = default(int[]);
		    var res = obj.GetBeamLongRebarData(Name, ref NumberRebarSets, ref BarSizeName, ref BarArea, ref NumberBars, ref Location, ref ClearCover, ref StartCoord1, ref BarLength, ref BendingAngleStart, ref BendingAngleEnd, ref RebarSetGUID);
		    return (NumberRebarSets, BarSizeName, BarArea, NumberBars, Location, ClearCover, StartCoord1, BarLength, BendingAngleStart, BendingAngleEnd, RebarSetGUID);
		}
		public static (int NumberRebarSets, string[] BarSizeName, double[] BarArea, double[] NumberLegs, string[] Location, double[] ClearCover, double[] StartCoord1, double[] Spacing, double[] Lengths, string[] RebarSetGUID)
		    GetBeamTieRebarData(this cDetailing obj, string Name) {
			int NumberRebarSets;
			NumberRebarSets = default(int);
			string[] BarSizeName, Location, RebarSetGUID;
			BarSizeName = Location = RebarSetGUID = default(string[]);
			double[] BarArea, NumberLegs, ClearCover, StartCoord1, Spacing, Lengths;
			BarArea = NumberLegs = ClearCover = StartCoord1 = Spacing = Lengths = default(double[]);
		    var res = obj.GetBeamTieRebarData(Name, ref NumberRebarSets, ref BarSizeName, ref BarArea, ref NumberLegs, ref Location, ref ClearCover, ref StartCoord1, ref Spacing, ref Lengths, ref RebarSetGUID);
		    return (NumberRebarSets, BarSizeName, BarArea, NumberLegs, Location, ClearCover, StartCoord1, Spacing, Lengths, RebarSetGUID);
		}
		public static (int NumberRebarSets, string[] BarSizeName, double[] BarArea, int[] NumberCBars, int[] NumberR3Bars, int[] NumberR2Bars, string[] Location, double[] ClearCover, string[] RebarSetGUID)
		    GetColumnLongRebarData(this cDetailing obj, string Name) {
			int NumberRebarSets;
			NumberRebarSets = default(int);
			string[] BarSizeName, Location, RebarSetGUID;
			BarSizeName = Location = RebarSetGUID = default(string[]);
			double[] BarArea, ClearCover;
			BarArea = ClearCover = default(double[]);
			int[] NumberCBars, NumberR3Bars, NumberR2Bars;
			NumberCBars = NumberR3Bars = NumberR2Bars = default(int[]);
		    var res = obj.GetColumnLongRebarData(Name, ref NumberRebarSets, ref BarSizeName, ref BarArea, ref NumberCBars, ref NumberR3Bars, ref NumberR2Bars, ref Location, ref ClearCover, ref RebarSetGUID);
		    return (NumberRebarSets, BarSizeName, BarArea, NumberCBars, NumberR3Bars, NumberR2Bars, Location, ClearCover, RebarSetGUID);
		}
		public static (int NumberRebarSets, string[] BarSizeName, double[] BarArea, int[] Pattern, int[] ConfineType, int[] NumberLegs2Dir, int[] NumberLegs3Dir, string[] Location, double[] ClearCover, double[] StartCoord1, double[] Spacing, double[] Heights, string[] RebarSetGUID)
		    GetColumnTieRebarData(this cDetailing obj, string Name) {
			int NumberRebarSets;
			NumberRebarSets = default(int);
			string[] BarSizeName, Location, RebarSetGUID;
			BarSizeName = Location = RebarSetGUID = default(string[]);
			double[] BarArea, ClearCover, StartCoord1, Spacing, Heights;
			BarArea = ClearCover = StartCoord1 = Spacing = Heights = default(double[]);
			int[] Pattern, ConfineType, NumberLegs2Dir, NumberLegs3Dir;
			Pattern = ConfineType = NumberLegs2Dir = NumberLegs3Dir = default(int[]);
		    var res = obj.GetColumnTieRebarData(Name, ref NumberRebarSets, ref BarSizeName, ref BarArea, ref Pattern, ref ConfineType, ref NumberLegs2Dir, ref NumberLegs3Dir, ref Location, ref ClearCover, ref StartCoord1, ref Spacing, ref Heights, ref RebarSetGUID);
		    return (NumberRebarSets, BarSizeName, BarArea, Pattern, ConfineType, NumberLegs2Dir, NumberLegs3Dir, Location, ClearCover, StartCoord1, Spacing, Heights, RebarSetGUID);
		}
		public static (string[] LongitudinalABars, string[] LongitudinalBBars, string[] LongitudinalCBars, string[] LongitudinalDBars, string[] LongitudinalEBars, string[] LongitudinalFBars, string[] LongitudinalGBars, string[] LongitudinalHBars, string[] ZoneATies, string[] ZoneBTies, string[] ZoneCTies)
		    GetDetailedBeamLineGuidData(this cDetailing obj, string BeamLineID, string SimilarFirstBeamUniqueID) {
			string[] LongitudinalABars, LongitudinalBBars, LongitudinalCBars, LongitudinalDBars, LongitudinalEBars, LongitudinalFBars, LongitudinalGBars, LongitudinalHBars, ZoneATies, ZoneBTies, ZoneCTies;
			LongitudinalABars = LongitudinalBBars = LongitudinalCBars = LongitudinalDBars = LongitudinalEBars = LongitudinalFBars = LongitudinalGBars = LongitudinalHBars = ZoneATies = ZoneBTies = ZoneCTies = default(string[]);
		    var res = obj.GetDetailedBeamLineGuidData(BeamLineID, SimilarFirstBeamUniqueID, ref LongitudinalABars, ref LongitudinalBBars, ref LongitudinalCBars, ref LongitudinalDBars, ref LongitudinalEBars, ref LongitudinalFBars, ref LongitudinalGBars, ref LongitudinalHBars, ref ZoneATies, ref ZoneBTies, ref ZoneCTies);
		    return (LongitudinalABars, LongitudinalBBars, LongitudinalCBars, LongitudinalDBars, LongitudinalEBars, LongitudinalFBars, LongitudinalGBars, LongitudinalHBars, ZoneATies, ZoneBTies, ZoneCTies);
		}
		public static (string[] LongitudinalBars, string[] TiesA, string[] TiesB, string[] TiesC)
		    GetDetailedColumnStackGuidData(this cDetailing obj, string ColumnStackID, string SimilarFirstColumnUniqueID) {
			string[] LongitudinalBars, TiesA, TiesB, TiesC;
			LongitudinalBars = TiesA = TiesB = TiesC = default(string[]);
		    var res = obj.GetDetailedColumnStackGuidData(ColumnStackID, SimilarFirstColumnUniqueID, ref LongitudinalBars, ref TiesA, ref TiesB, ref TiesC);
		    return (LongitudinalBars, TiesA, TiesB, TiesC);
		}
		public static (string[] ObjectUniqueNames, int NumLongBarSets, int[] NumLongBars, int[] NumLongR2Bars, int[] NumLongR3Bars, string[] LongBarGUID, double[] LongBarDiameter, string[] LongBarNotation, double[] LongBarStartDist, int[] LongBarStartBend, int[] LongBarEndBend, double[] LongBarLength, int[] LongBarNumLayers, int NumTieZones, string[] TieBarZone, int[] NumTieBars, int[] NumTieR2Legs, int[] NumTieR3Legs, string[] TieBarGUID, double[] TieBarDiameter, string[] TieBarNotation, double[] TieBarStartDist, double[] TieBarSpacing, int[] TieBarType)
		    GetDetailedColumnStackData_2(this cDetailing obj, string ColumnStackID) {
			string[] ObjectUniqueNames, LongBarGUID, LongBarNotation, TieBarZone, TieBarGUID, TieBarNotation;
			ObjectUniqueNames = LongBarGUID = LongBarNotation = TieBarZone = TieBarGUID = TieBarNotation = default(string[]);
			int NumLongBarSets, NumTieZones;
			NumLongBarSets = NumTieZones = default(int);
			int[] NumLongBars, NumLongR2Bars, NumLongR3Bars, LongBarStartBend, LongBarEndBend, LongBarNumLayers, NumTieBars, NumTieR2Legs, NumTieR3Legs, TieBarType;
			NumLongBars = NumLongR2Bars = NumLongR3Bars = LongBarStartBend = LongBarEndBend = LongBarNumLayers = NumTieBars = NumTieR2Legs = NumTieR3Legs = TieBarType = default(int[]);
			double[] LongBarDiameter, LongBarStartDist, LongBarLength, TieBarDiameter, TieBarStartDist, TieBarSpacing;
			LongBarDiameter = LongBarStartDist = LongBarLength = TieBarDiameter = TieBarStartDist = TieBarSpacing = default(double[]);
		    var res = obj.GetDetailedColumnStackData_2(ColumnStackID, ref ObjectUniqueNames, ref NumLongBarSets, ref NumLongBars, ref NumLongR2Bars, ref NumLongR3Bars, ref LongBarGUID, ref LongBarDiameter, ref LongBarNotation, ref LongBarStartDist, ref LongBarStartBend, ref LongBarEndBend, ref LongBarLength, ref LongBarNumLayers, ref NumTieZones, ref TieBarZone, ref NumTieBars, ref NumTieR2Legs, ref NumTieR3Legs, ref TieBarGUID, ref TieBarDiameter, ref TieBarNotation, ref TieBarStartDist, ref TieBarSpacing, ref TieBarType);
		    return (ObjectUniqueNames, NumLongBarSets, NumLongBars, NumLongR2Bars, NumLongR3Bars, LongBarGUID, LongBarDiameter, LongBarNotation, LongBarStartDist, LongBarStartBend, LongBarEndBend, LongBarLength, LongBarNumLayers, NumTieZones, TieBarZone, NumTieBars, NumTieR2Legs, NumTieR3Legs, TieBarGUID, TieBarDiameter, TieBarNotation, TieBarStartDist, TieBarSpacing, TieBarType);
		}
		public static int
		    GetNumberDetailedSlabs(this cDetailing obj) {
			int NumberDetailingOutput;
			NumberDetailingOutput = default(int);
		    var res = obj.GetNumberDetailedSlabs(ref NumberDetailingOutput);
		    return NumberDetailingOutput;
		}
		public static (string Guid_ETABS, string Floor, string StoryNameETABS, double LevelZ, int NumberStrips)
		    GetDetailedSlab_OneDetailingOutputInfo(this cDetailing obj, int DetailingOutputIndex) {
			string Guid_ETABS, Floor, StoryNameETABS;
			Guid_ETABS = Floor = StoryNameETABS = default(string);
			double LevelZ;
			LevelZ = default(double);
			int NumberStrips;
			NumberStrips = default(int);
		    var res = obj.GetDetailedSlab_OneDetailingOutputInfo(DetailingOutputIndex, ref Guid_ETABS, ref Floor, ref StoryNameETABS, ref LevelZ, ref NumberStrips);
		    return (Guid_ETABS, Floor, StoryNameETABS, LevelZ, NumberStrips);
		}
		public static (string Name, string LayerName, string StripType, int NumberRegions)
		    GetOneDetailedSlab_OneDetailingOutput_StripInfo(this cDetailing obj, int DetailingOutputIndex, int StripIndex) {
			string Name, LayerName, StripType;
			Name = LayerName = StripType = default(string);
			int NumberRegions;
			NumberRegions = default(int);
		    var res = obj.GetOneDetailedSlab_OneDetailingOutput_StripInfo(DetailingOutputIndex, StripIndex, ref Name, ref LayerName, ref StripType, ref NumberRegions);
		    return (Name, LayerName, StripType, NumberRegions);
		}
		public static string
		    GetOneDetailedSlab_OneDetailingOutput_StripGUID(this cDetailing obj, int DetailingOutputIndex, int StripIndex) {
			string GUID_ETABS;
			GUID_ETABS = default(string);
		    var res = obj.GetOneDetailedSlab_OneDetailingOutput_StripGUID(DetailingOutputIndex, StripIndex, ref GUID_ETABS);
		    return GUID_ETABS;
		}
		public static (double X1, double Y1, double X2, double Y2, int NumberTopBars, int NumberBottomBars)
		    GetOneDetailedSlab_OneDetailingOutput_OneStrip_OneDetailingRegionInfo(this cDetailing obj, int DetailingOutputIndex, int StripIndex, int DetailingRegionIndex) {
			double X1, Y1, X2, Y2;
			X1 = Y1 = X2 = Y2 = default(double);
			int NumberTopBars, NumberBottomBars;
			NumberTopBars = NumberBottomBars = default(int);
		    var res = obj.GetOneDetailedSlab_OneDetailingOutput_OneStrip_OneDetailingRegionInfo(DetailingOutputIndex, StripIndex, DetailingRegionIndex, ref X1, ref Y1, ref X2, ref Y2, ref NumberTopBars, ref NumberBottomBars);
		    return (X1, Y1, X2, Y2, NumberTopBars, NumberBottomBars);
		}
		public static (double X1, double Y1, double X2, double Y2, double WidthRight, double WidthLeft, double Z, double ReqAst, double ProvAst)
		    GetOneDetailedSlab_OneDetailingOutput_OneStrip_OneDetailingRegion_OneTopRebarInfo(this cDetailing obj, int DetailingOutputIndex, int StripIndex, int DetailingRegionIndex, int TopRebarIndex) {
			double X1, Y1, X2, Y2, WidthRight, WidthLeft, Z, ReqAst, ProvAst;
			X1 = Y1 = X2 = Y2 = WidthRight = WidthLeft = Z = ReqAst = ProvAst = default(double);
		    var res = obj.GetOneDetailedSlab_OneDetailingOutput_OneStrip_OneDetailingRegion_OneTopRebarInfo(DetailingOutputIndex, StripIndex, DetailingRegionIndex, TopRebarIndex, ref X1, ref Y1, ref X2, ref Y2, ref WidthRight, ref WidthLeft, ref Z, ref ReqAst, ref ProvAst);
		    return (X1, Y1, X2, Y2, WidthRight, WidthLeft, Z, ReqAst, ProvAst);
		}
		public static (double X1, double Y1, double X2, double Y2, double WidthRight, double WidthLeft, double Z, double ReqAst, double ProvAst)
		    GetOneDetailedSlab_OneDetailingOutput_OneStrip_OneDetailingRegion_OneBottomRebarInfo(this cDetailing obj, int DetailingOutputIndex, int StripIndex, int DetailingRegionIndex, int BottomRebarIndex) {
			double X1, Y1, X2, Y2, WidthRight, WidthLeft, Z, ReqAst, ProvAst;
			X1 = Y1 = X2 = Y2 = WidthRight = WidthLeft = Z = ReqAst = ProvAst = default(double);
		    var res = obj.GetOneDetailedSlab_OneDetailingOutput_OneStrip_OneDetailingRegion_OneBottomRebarInfo(DetailingOutputIndex, StripIndex, DetailingRegionIndex, BottomRebarIndex, ref X1, ref Y1, ref X2, ref Y2, ref WidthRight, ref WidthLeft, ref Z, ref ReqAst, ref ProvAst);
		    return (X1, Y1, X2, Y2, WidthRight, WidthLeft, Z, ReqAst, ProvAst);
		}
		public static (string GUID, string PlaceCode, double Dia, string Size, int Number, double StartDist, double EndDist, int StartBend, int EndBend, string Material)
		    GetOneDetailedSlab_OneDetailingOutput_OneStrip_OneDetailingRegion_OneTopRebar_Bar1Info(this cDetailing obj, int DetailingOutputIndex, int StripIndex, int DetailingRegionIndex, int TopRebarIndex) {
			string GUID, PlaceCode, Size, Material;
			GUID = PlaceCode = Size = Material = default(string);
			double Dia, StartDist, EndDist;
			Dia = StartDist = EndDist = default(double);
			int Number, StartBend, EndBend;
			Number = StartBend = EndBend = default(int);
		    var res = obj.GetOneDetailedSlab_OneDetailingOutput_OneStrip_OneDetailingRegion_OneTopRebar_Bar1Info(DetailingOutputIndex, StripIndex, DetailingRegionIndex, TopRebarIndex, ref GUID, ref PlaceCode, ref Dia, ref Size, ref Number, ref StartDist, ref EndDist, ref StartBend, ref EndBend, ref Material);
		    return (GUID, PlaceCode, Dia, Size, Number, StartDist, EndDist, StartBend, EndBend, Material);
		}
		public static (string GUID, string PlaceCode, double Dia, string Size, int Number, double StartDist, double EndDist, int StartBend, int EndBend, string Material)
		    GetOneDetailedSlab_OneDetailingOutput_OneStrip_OneDetailingRegion_OneTopRebar_Bar2Info(this cDetailing obj, int DetailingOutputIndex, int StripIndex, int DetailingRegionIndex, int TopRebarIndex) {
			string GUID, PlaceCode, Size, Material;
			GUID = PlaceCode = Size = Material = default(string);
			double Dia, StartDist, EndDist;
			Dia = StartDist = EndDist = default(double);
			int Number, StartBend, EndBend;
			Number = StartBend = EndBend = default(int);
		    var res = obj.GetOneDetailedSlab_OneDetailingOutput_OneStrip_OneDetailingRegion_OneTopRebar_Bar2Info(DetailingOutputIndex, StripIndex, DetailingRegionIndex, TopRebarIndex, ref GUID, ref PlaceCode, ref Dia, ref Size, ref Number, ref StartDist, ref EndDist, ref StartBend, ref EndBend, ref Material);
		    return (GUID, PlaceCode, Dia, Size, Number, StartDist, EndDist, StartBend, EndBend, Material);
		}
		public static (string GUID, string PlaceCode, double Dia, string Size, int Number, double StartDist, double EndDist, int StartBend, int EndBend, string Material)
		    GetOneDetailedSlab_OneDetailingOutput_OneStrip_OneDetailingRegion_OneBottomRebar_Bar1Info(this cDetailing obj, int DetailingOutputIndex, int StripIndex, int DetailingRegionIndex, int BottomRebarIndex) {
			string GUID, PlaceCode, Size, Material;
			GUID = PlaceCode = Size = Material = default(string);
			double Dia, StartDist, EndDist;
			Dia = StartDist = EndDist = default(double);
			int Number, StartBend, EndBend;
			Number = StartBend = EndBend = default(int);
		    var res = obj.GetOneDetailedSlab_OneDetailingOutput_OneStrip_OneDetailingRegion_OneBottomRebar_Bar1Info(DetailingOutputIndex, StripIndex, DetailingRegionIndex, BottomRebarIndex, ref GUID, ref PlaceCode, ref Dia, ref Size, ref Number, ref StartDist, ref EndDist, ref StartBend, ref EndBend, ref Material);
		    return (GUID, PlaceCode, Dia, Size, Number, StartDist, EndDist, StartBend, EndBend, Material);
		}
		public static (string GUID, string PlaceCode, double Dia, string Size, int Number, double StartDist, double EndDist, int StartBend, int EndBend, string Material)
		    GetOneDetailedSlab_OneDetailingOutput_OneStrip_OneDetailingRegion_OneBottomRebar_Bar2Info(this cDetailing obj, int DetailingOutputIndex, int StripIndex, int DetailingRegionIndex, int BottomRebarIndex) {
			string GUID, PlaceCode, Size, Material;
			GUID = PlaceCode = Size = Material = default(string);
			double Dia, StartDist, EndDist;
			Dia = StartDist = EndDist = default(double);
			int Number, StartBend, EndBend;
			Number = StartBend = EndBend = default(int);
		    var res = obj.GetOneDetailedSlab_OneDetailingOutput_OneStrip_OneDetailingRegion_OneBottomRebar_Bar2Info(DetailingOutputIndex, StripIndex, DetailingRegionIndex, BottomRebarIndex, ref GUID, ref PlaceCode, ref Dia, ref Size, ref Number, ref StartDist, ref EndDist, ref StartBend, ref EndBend, ref Material);
		    return (GUID, PlaceCode, Dia, Size, Number, StartDist, EndDist, StartBend, EndBend, Material);
		}
		public static int
		    GetNumberDetailedWallStacks(this cDetailing obj) {
			int NumberWallStacks;
			NumberWallStacks = default(int);
		    var res = obj.GetNumberDetailedWallStacks(ref NumberWallStacks);
		    return NumberWallStacks;
		}
		public static (string GUID, int TowerID, int NumberPiers, int NUmberSpandrels)
		    GetDetailed_OneWallStack(this cDetailing obj, int WallStackIndex) {
			string GUID;
			GUID = default(string);
			int TowerID, NumberPiers, NUmberSpandrels;
			TowerID = NumberPiers = NUmberSpandrels = default(int);
		    var res = obj.GetDetailed_OneWallStack(WallStackIndex, ref GUID, ref TowerID, ref NumberPiers, ref NUmberSpandrels);
		    return (GUID, TowerID, NumberPiers, NUmberSpandrels);
		}
		public static (int StoryID, string ETABSStoryName, int NumberDesignLegs)
		    GetDetailedWall_OneWallStack_OnePierOutputInfo(this cDetailing obj, int WallStackIndex, int PierIndex) {
			int StoryID, NumberDesignLegs;
			StoryID = NumberDesignLegs = default(int);
			string ETABSStoryName;
			ETABSStoryName = default(string);
		    var res = obj.GetDetailedWall_OneWallStack_OnePierOutputInfo(WallStackIndex, PierIndex, ref StoryID, ref ETABSStoryName, ref NumberDesignLegs);
		    return (StoryID, ETABSStoryName, NumberDesignLegs);
		}
		public static (string GUID, string PierLabel, double x1, double y1, double z1, double x2, double y2, double z2, double ZLevel, int NumberVerticalBars, int NumberHorizontalBars, int TotalAreaObjects, string[] AreaObjectNames)
		    GetDetailedWall_OneWallStack_OnePier_OneDesignLegOutputInfo(this cDetailing obj, int WallStackIndex, int PierIndex, int DesignLegIndex) {
			string GUID, PierLabel;
			GUID = PierLabel = default(string);
			double x1, y1, z1, x2, y2, z2, ZLevel;
			x1 = y1 = z1 = x2 = y2 = z2 = ZLevel = default(double);
			int NumberVerticalBars, NumberHorizontalBars, TotalAreaObjects;
			NumberVerticalBars = NumberHorizontalBars = TotalAreaObjects = default(int);
			string[] AreaObjectNames;
			AreaObjectNames = default(string[]);
		    var res = obj.GetDetailedWall_OneWallStack_OnePier_OneDesignLegOutputInfo(WallStackIndex, PierIndex, DesignLegIndex, ref GUID, ref PierLabel, ref x1, ref y1, ref z1, ref x2, ref y2, ref z2, ref ZLevel, ref NumberVerticalBars, ref NumberHorizontalBars, ref TotalAreaObjects, ref AreaObjectNames);
		    return (GUID, PierLabel, x1, y1, z1, x2, y2, z2, ZLevel, NumberVerticalBars, NumberHorizontalBars, TotalAreaObjects, AreaObjectNames);
		}
		public static (string GUID, double BarSizeFirst_Dia, double BarSizeFirst_Area, double BarSizeFirst_Fy, string BarSizeFirst_Notation, double BarSizeLast_Dia, double BarSizeLast_Area, double BarSizeLast_Fy, string BarSizeLast_Notation, double BarSizeOthers_Dia, double BarSizeOthers_Area, double BarSizeOthers_Fy, string BarSizeOthers_Notation, int Number, double StartX, double StartY, double EndX, double EndY, int StartBarBend, int EndBarBend, double OffsetZ, double BarLength, int LocationCode)
		    GetDetailedWall_OneWallStack_OnePier_OneDesignLeg_OneVerticalBarInfo(this cDetailing obj, int WallStackIndex, int PierIndex, int DesignLegIndex, int VerticalBarIndex) {
			string GUID, BarSizeFirst_Notation, BarSizeLast_Notation, BarSizeOthers_Notation;
			GUID = BarSizeFirst_Notation = BarSizeLast_Notation = BarSizeOthers_Notation = default(string);
			double BarSizeFirst_Dia, BarSizeFirst_Area, BarSizeFirst_Fy, BarSizeLast_Dia, BarSizeLast_Area, BarSizeLast_Fy, BarSizeOthers_Dia, BarSizeOthers_Area, BarSizeOthers_Fy, StartX, StartY, EndX, EndY, OffsetZ, BarLength;
			BarSizeFirst_Dia = BarSizeFirst_Area = BarSizeFirst_Fy = BarSizeLast_Dia = BarSizeLast_Area = BarSizeLast_Fy = BarSizeOthers_Dia = BarSizeOthers_Area = BarSizeOthers_Fy = StartX = StartY = EndX = EndY = OffsetZ = BarLength = default(double);
			int Number, StartBarBend, EndBarBend, LocationCode;
			Number = StartBarBend = EndBarBend = LocationCode = default(int);
		    var res = obj.GetDetailedWall_OneWallStack_OnePier_OneDesignLeg_OneVerticalBarInfo(WallStackIndex, PierIndex, DesignLegIndex, VerticalBarIndex, ref GUID, ref BarSizeFirst_Dia, ref BarSizeFirst_Area, ref BarSizeFirst_Fy, ref BarSizeFirst_Notation, ref BarSizeLast_Dia, ref BarSizeLast_Area, ref BarSizeLast_Fy, ref BarSizeLast_Notation, ref BarSizeOthers_Dia, ref BarSizeOthers_Area, ref BarSizeOthers_Fy, ref BarSizeOthers_Notation, ref Number, ref StartX, ref StartY, ref EndX, ref EndY, ref StartBarBend, ref EndBarBend, ref OffsetZ, ref BarLength, ref LocationCode);
		    return (GUID, BarSizeFirst_Dia, BarSizeFirst_Area, BarSizeFirst_Fy, BarSizeFirst_Notation, BarSizeLast_Dia, BarSizeLast_Area, BarSizeLast_Fy, BarSizeLast_Notation, BarSizeOthers_Dia, BarSizeOthers_Area, BarSizeOthers_Fy, BarSizeOthers_Notation, Number, StartX, StartY, EndX, EndY, StartBarBend, EndBarBend, OffsetZ, BarLength, LocationCode);
		}
		public static (string GUID, double BarSize_Dia, double BarSize_Area, double BarSize_Fy, string BarSize_Notation, double Spacing, double StartZ, double EndZ, int TieShape, int NumberOfTiePlines)
		    GetDetailedWall_OneWallStack_OnePier_OneDesignLeg_OneTieBarInfo(this cDetailing obj, int WallStackIndex, int PierIndex, int DesignLegIndex, int TieBarIndex) {
			string GUID, BarSize_Notation;
			GUID = BarSize_Notation = default(string);
			double BarSize_Dia, BarSize_Area, BarSize_Fy, Spacing, StartZ, EndZ;
			BarSize_Dia = BarSize_Area = BarSize_Fy = Spacing = StartZ = EndZ = default(double);
			int TieShape, NumberOfTiePlines;
			TieShape = NumberOfTiePlines = default(int);
		    var res = obj.GetDetailedWall_OneWallStack_OnePier_OneDesignLeg_OneTieBarInfo(WallStackIndex, PierIndex, DesignLegIndex, TieBarIndex, ref GUID, ref BarSize_Dia, ref BarSize_Area, ref BarSize_Fy, ref BarSize_Notation, ref Spacing, ref StartZ, ref EndZ, ref TieShape, ref NumberOfTiePlines);
		    return (GUID, BarSize_Dia, BarSize_Area, BarSize_Fy, BarSize_Notation, Spacing, StartZ, EndZ, TieShape, NumberOfTiePlines);
		}
		public static (double Dia, int NumberPoints, double ZoneLength, int LocationCode)
		    GetDetailedWall_OneWallStack_OnePier_OneDesignLeg_OneTieBar_OneTiePlineInfo(this cDetailing obj, int WallStackIndex, int PierIndex, int DesignLegIndex, int TieBarIndex, int TiePLineIndex) {
			double Dia, ZoneLength;
			Dia = ZoneLength = default(double);
			int NumberPoints, LocationCode;
			NumberPoints = LocationCode = default(int);
		    var res = obj.GetDetailedWall_OneWallStack_OnePier_OneDesignLeg_OneTieBar_OneTiePlineInfo(WallStackIndex, PierIndex, DesignLegIndex, TieBarIndex, TiePLineIndex, ref Dia, ref NumberPoints, ref ZoneLength, ref LocationCode);
		    return (Dia, NumberPoints, ZoneLength, LocationCode);
		}
		public static (double X, double Y, double Z)
		    GetDetailedWall_OnePier_OneDesignLeg_OneTieBar_OneTiePline_OnePoint(this cDetailing obj, int WallStackIndex, int PierIndex, int DesignLegIndex, int TieBarIndex, int TiePLineIndex, int TPLinePointIndex) {
			double X, Y, Z;
			X = Y = Z = default(double);
		    var res = obj.GetDetailedWall_OnePier_OneDesignLeg_OneTieBar_OneTiePline_OnePoint(WallStackIndex, PierIndex, DesignLegIndex, TieBarIndex, TiePLineIndex, TPLinePointIndex, ref X, ref Y, ref Z);
		    return (X, Y, Z);
		}
		public static (string GUID, string Name, double Height, double Width, double Thickness, double CoverLongBar, double CoverStirrups, double x1, double y1, double z1, double x2, double y2, double z2, int NumberLongBars, int NumberStirrups, int TotalAreaObjects, string[] AreaObjectNames)
		    GetDetailedWall_OneWallStack_OneSpandrelOutputInfo(this cDetailing obj, int WallStackIndex, int SpandrelIndex) {
			string GUID, Name;
			GUID = Name = default(string);
			double Height, Width, Thickness, CoverLongBar, CoverStirrups, x1, y1, z1, x2, y2, z2;
			Height = Width = Thickness = CoverLongBar = CoverStirrups = x1 = y1 = z1 = x2 = y2 = z2 = default(double);
			int NumberLongBars, NumberStirrups, TotalAreaObjects;
			NumberLongBars = NumberStirrups = TotalAreaObjects = default(int);
			string[] AreaObjectNames;
			AreaObjectNames = default(string[]);
		    var res = obj.GetDetailedWall_OneWallStack_OneSpandrelOutputInfo(WallStackIndex, SpandrelIndex, ref GUID, ref Name, ref Height, ref Width, ref Thickness, ref CoverLongBar, ref CoverStirrups, ref x1, ref y1, ref z1, ref x2, ref y2, ref z2, ref NumberLongBars, ref NumberStirrups, ref TotalAreaObjects, ref AreaObjectNames);
		    return (GUID, Name, Height, Width, Thickness, CoverLongBar, CoverStirrups, x1, y1, z1, x2, y2, z2, NumberLongBars, NumberStirrups, TotalAreaObjects, AreaObjectNames);
		}
		public static (double BarSize_Dia, double BarSize_Area, double BarSize_Fy, string BarSize_Notation, int NumberPoints, double[] X, double[] Y, double[] Z, int StartType, int EndType)
		    GetDetailedWall_OneWallStack_OneSpandrel_OneLongBarInfo(this cDetailing obj, int WallStackIndex, int SpandrelIndex, int LongBarIndex) {
			double BarSize_Dia, BarSize_Area, BarSize_Fy;
			BarSize_Dia = BarSize_Area = BarSize_Fy = default(double);
			string BarSize_Notation;
			BarSize_Notation = default(string);
			int NumberPoints, StartType, EndType;
			NumberPoints = StartType = EndType = default(int);
			double[] X, Y, Z;
			X = Y = Z = default(double[]);
		    var res = obj.GetDetailedWall_OneWallStack_OneSpandrel_OneLongBarInfo(WallStackIndex, SpandrelIndex, LongBarIndex, ref BarSize_Dia, ref BarSize_Area, ref BarSize_Fy, ref BarSize_Notation, ref NumberPoints, ref X, ref Y, ref Z, ref StartType, ref EndType);
		    return (BarSize_Dia, BarSize_Area, BarSize_Fy, BarSize_Notation, NumberPoints, X, Y, Z, StartType, EndType);
		}
		public static (double BarSize_Dia, double BarSize_Area, double BarSize_Fy, string BarSize_Notation, double X1, double X2, double Spacing, int NumberLegs)
		    GetDetailedWall_OneWallStack_OneSpandrel_OneStirrupsInfo(this cDetailing obj, int WallStackIndex, int SpandrelIndex, int StirrupsIndex) {
			double BarSize_Dia, BarSize_Area, BarSize_Fy, X1, X2, Spacing;
			BarSize_Dia = BarSize_Area = BarSize_Fy = X1 = X2 = Spacing = default(double);
			string BarSize_Notation;
			BarSize_Notation = default(string);
			int NumberLegs;
			NumberLegs = default(int);
		    var res = obj.GetDetailedWall_OneWallStack_OneSpandrel_OneStirrupsInfo(WallStackIndex, SpandrelIndex, StirrupsIndex, ref BarSize_Dia, ref BarSize_Area, ref BarSize_Fy, ref BarSize_Notation, ref X1, ref X2, ref Spacing, ref NumberLegs);
		    return (BarSize_Dia, BarSize_Area, BarSize_Fy, BarSize_Notation, X1, X2, Spacing, NumberLegs);
		}
		public static (int NumberItems, string[] TowerNames, string[] StoryNames, string[] BeamLineIDs)
		    GetDetailedBeamLines_1(this cDetailing obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] TowerNames, StoryNames, BeamLineIDs;
			TowerNames = StoryNames = BeamLineIDs = default(string[]);
		    var res = obj.GetDetailedBeamLines_1(ref NumberItems, ref TowerNames, ref StoryNames, ref BeamLineIDs);
		    return (NumberItems, TowerNames, StoryNames, BeamLineIDs);
		}
		public static (int NumberOfObjects, string[] ObjectUniqueNames, int NumberSpans, double[] SpanLength, int[] NumLongBars, string[] LongBarGUID, double[] LongBarDiameter, string[] LongBarNotation, double[] LongBarStartDist, int[] LongBarStartBend, int[] LongBarEndBend, double[] LongBarLength, int[] LongBarNumLayers, int[] NumTieBars, int[] NumTieVertLegs, string[] TieBarGUID, double[] TieBarDiameter, string[] TieBarNotation, double[] TieBarStartDist, double[] TieBarSpacing, int[] TieBarType)
		    GetDetailedBeamLineData_2(this cDetailing obj, string TowerName, string StoryName, string BeamLineID) {
			int NumberOfObjects, NumberSpans;
			NumberOfObjects = NumberSpans = default(int);
			string[] ObjectUniqueNames, LongBarGUID, LongBarNotation, TieBarGUID, TieBarNotation;
			ObjectUniqueNames = LongBarGUID = LongBarNotation = TieBarGUID = TieBarNotation = default(string[]);
			double[] SpanLength, LongBarDiameter, LongBarStartDist, LongBarLength, TieBarDiameter, TieBarStartDist, TieBarSpacing;
			SpanLength = LongBarDiameter = LongBarStartDist = LongBarLength = TieBarDiameter = TieBarStartDist = TieBarSpacing = default(double[]);
			int[] NumLongBars, LongBarStartBend, LongBarEndBend, LongBarNumLayers, NumTieBars, NumTieVertLegs, TieBarType;
			NumLongBars = LongBarStartBend = LongBarEndBend = LongBarNumLayers = NumTieBars = NumTieVertLegs = TieBarType = default(int[]);
		    var res = obj.GetDetailedBeamLineData_2(TowerName, StoryName, BeamLineID, ref NumberOfObjects, ref ObjectUniqueNames, ref NumberSpans, ref SpanLength, ref NumLongBars, ref LongBarGUID, ref LongBarDiameter, ref LongBarNotation, ref LongBarStartDist, ref LongBarStartBend, ref LongBarEndBend, ref LongBarLength, ref LongBarNumLayers, ref NumTieBars, ref NumTieVertLegs, ref TieBarGUID, ref TieBarDiameter, ref TieBarNotation, ref TieBarStartDist, ref TieBarSpacing, ref TieBarType);
		    return (NumberOfObjects, ObjectUniqueNames, NumberSpans, SpanLength, NumLongBars, LongBarGUID, LongBarDiameter, LongBarNotation, LongBarStartDist, LongBarStartBend, LongBarEndBend, LongBarLength, LongBarNumLayers, NumTieBars, NumTieVertLegs, TieBarGUID, TieBarDiameter, TieBarNotation, TieBarStartDist, TieBarSpacing, TieBarType);
		}
		public static (int NumberSimilarBeams, int[] NumberUniqueObjects, string[] ObjectUniqueNames)
		    GetSimilarBeamLines_1(this cDetailing obj, string TowerName, string StoryName, string BeamLineID) {
			int NumberSimilarBeams;
			NumberSimilarBeams = default(int);
			int[] NumberUniqueObjects;
			NumberUniqueObjects = default(int[]);
			string[] ObjectUniqueNames;
			ObjectUniqueNames = default(string[]);
		    var res = obj.GetSimilarBeamLines_1(TowerName, StoryName, BeamLineID, ref NumberSimilarBeams, ref NumberUniqueObjects, ref ObjectUniqueNames);
		    return (NumberSimilarBeams, NumberUniqueObjects, ObjectUniqueNames);
		}

    }
}