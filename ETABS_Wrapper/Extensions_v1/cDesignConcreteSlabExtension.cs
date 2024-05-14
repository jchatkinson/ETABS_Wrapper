using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cDesignConcreteSlabExtension
    {
		public static (string[] StoryName, string[] DesignStripName, double[] Station, double[] ConcWidth, string[] FTopCombo, double[] FTopMoment, double[] FTopArea, double[] FTopAMin, string[] FBotCombo, double[] FBotMoment, double[] FBotArea, double[] FBotAMin, double[] AxialForce, string[] VCombo, double[] VForce, double[] VArea, string[] Status, double[] GlobalX, double[] GlobalY, string[] Layer)
		    GetFlexureAndShear(this cDesignConcreteSlab obj) {
			string[] StoryName, DesignStripName, FTopCombo, FBotCombo, VCombo, Status, Layer;
			StoryName = DesignStripName = FTopCombo = FBotCombo = VCombo = Status = Layer = default(string[]);
			double[] Station, ConcWidth, FTopMoment, FTopArea, FTopAMin, FBotMoment, FBotArea, FBotAMin, AxialForce, VForce, VArea, GlobalX, GlobalY;
			Station = ConcWidth = FTopMoment = FTopArea = FTopAMin = FBotMoment = FBotArea = FBotAMin = AxialForce = VForce = VArea = GlobalX = GlobalY = default(double[]);
		    var res = obj.GetFlexureAndShear(ref StoryName, ref DesignStripName, ref Station, ref ConcWidth, ref FTopCombo, ref FTopMoment, ref FTopArea, ref FTopAMin, ref FBotCombo, ref FBotMoment, ref FBotArea, ref FBotAMin, ref AxialForce, ref VCombo, ref VForce, ref VArea, ref Status, ref GlobalX, ref GlobalY, ref Layer);
		    return (StoryName, DesignStripName, Station, ConcWidth, FTopCombo, FTopMoment, FTopArea, FTopAMin, FBotCombo, FBotMoment, FBotArea, FBotAMin, AxialForce, VCombo, VForce, VArea, Status, GlobalX, GlobalY, Layer);
		}
		public static (string[] StoryName, string[] DesignStripName, string[] SpanID, string[] Location, string[] FTopCombo, double[] FTopMoment, double[] FTopArea, string[] FBotCombo, double[] FBotMoment, double[] FBotArea, string[] VCombo, double[] VForce, double[] VArea, string[] Status, string[] Layer)
		    GetSummaryResultsFlexureAndShear(this cDesignConcreteSlab obj) {
			string[] StoryName, DesignStripName, SpanID, Location, FTopCombo, FBotCombo, VCombo, Status, Layer;
			StoryName = DesignStripName = SpanID = Location = FTopCombo = FBotCombo = VCombo = Status = Layer = default(string[]);
			double[] FTopMoment, FTopArea, FBotMoment, FBotArea, VForce, VArea;
			FTopMoment = FTopArea = FBotMoment = FBotArea = VForce = VArea = default(double[]);
		    var res = obj.GetSummaryResultsFlexureAndShear(ref StoryName, ref DesignStripName, ref SpanID, ref Location, ref FTopCombo, ref FTopMoment, ref FTopArea, ref FBotCombo, ref FBotMoment, ref FBotArea, ref VCombo, ref VForce, ref VArea, ref Status, ref Layer);
		    return (StoryName, DesignStripName, SpanID, Location, FTopCombo, FTopMoment, FTopArea, FBotCombo, FBotMoment, FBotArea, VCombo, VForce, VArea, Status, Layer);
		}
		public static (string[] StoryName, string[] DesignStripName, string[] SpanID, double[] SpanLength, double[] StartDist, double[] EndDist, double[] GlobalX1, double[] GlobalY1, double[] GlobalX2, double[] GlobalY2)
		    GetSummaryResultsSpanDefinition(this cDesignConcreteSlab obj) {
			string[] StoryName, DesignStripName, SpanID;
			StoryName = DesignStripName = SpanID = default(string[]);
			double[] SpanLength, StartDist, EndDist, GlobalX1, GlobalY1, GlobalX2, GlobalY2;
			SpanLength = StartDist = EndDist = GlobalX1 = GlobalY1 = GlobalX2 = GlobalY2 = default(double[]);
		    var res = obj.GetSummaryResultsSpanDefinition(ref StoryName, ref DesignStripName, ref SpanID, ref SpanLength, ref StartDist, ref EndDist, ref GlobalX1, ref GlobalY1, ref GlobalX2, ref GlobalY2);
		    return (StoryName, DesignStripName, SpanID, SpanLength, StartDist, EndDist, GlobalX1, GlobalY1, GlobalX2, GlobalY2);
		}

    }
}