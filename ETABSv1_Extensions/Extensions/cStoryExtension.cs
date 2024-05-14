using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cStoryExtension
    {
		public static double
		    GetElevation(this cStory obj, string Name) {
			double Elevation;
			Elevation = default(double);
		    var res = obj.GetElevation(Name, ref Elevation);
		    return Elevation;
		}
		public static string
		    GetGUID(this cStory obj, string Name) {
			string GUID;
			GUID = default(string);
		    var res = obj.GetGUID(Name, ref GUID);
		    return GUID;
		}
		public static double
		    GetHeight(this cStory obj, string Name) {
			double Height;
			Height = default(double);
		    var res = obj.GetHeight(Name, ref Height);
		    return Height;
		}
		public static bool
		    GetMasterStory(this cStory obj, string Name) {
			bool IsMasterStory;
			IsMasterStory = default(bool);
		    var res = obj.GetMasterStory(Name, ref IsMasterStory);
		    return IsMasterStory;
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cStory obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (bool IsMasterStory, string SimilarToStory)
		    GetSimilarTo(this cStory obj, string Name) {
			bool IsMasterStory;
			IsMasterStory = default(bool);
			string SimilarToStory;
			SimilarToStory = default(string);
		    var res = obj.GetSimilarTo(Name, ref IsMasterStory, ref SimilarToStory);
		    return (IsMasterStory, SimilarToStory);
		}
		public static (bool SpliceAbove, double SpliceHeight)
		    GetSplice(this cStory obj, string Name) {
			bool SpliceAbove;
			SpliceAbove = default(bool);
			double SpliceHeight;
			SpliceHeight = default(double);
		    var res = obj.GetSplice(Name, ref SpliceAbove, ref SpliceHeight);
		    return (SpliceAbove, SpliceHeight);
		}
		public static (int NumberStories, string[] StoryNames, double[] StoryElevations, double[] StoryHeights, bool[] IsMasterStory, string[] SimilarToStory, bool[] SpliceAbove, double[] SpliceHeight)
		    GetStories(this cStory obj) {
			int NumberStories;
			NumberStories = default(int);
			string[] StoryNames, SimilarToStory;
			StoryNames = SimilarToStory = default(string[]);
			double[] StoryElevations, StoryHeights, SpliceHeight;
			StoryElevations = StoryHeights = SpliceHeight = default(double[]);
			bool[] IsMasterStory, SpliceAbove;
			IsMasterStory = SpliceAbove = default(bool[]);
		    var res = obj.GetStories(ref NumberStories, ref StoryNames, ref StoryElevations, ref StoryHeights, ref IsMasterStory, ref SimilarToStory, ref SpliceAbove, ref SpliceHeight);
		    return (NumberStories, StoryNames, StoryElevations, StoryHeights, IsMasterStory, SimilarToStory, SpliceAbove, SpliceHeight);
		}
		public static (double BaseElevation, int NumberStories, string[] StoryNames, double[] StoryElevations, double[] StoryHeights, bool[] IsMasterStory, string[] SimilarToStory, bool[] SpliceAbove, double[] SpliceHeight, int[] color)
		    GetStories_2(this cStory obj) {
			double BaseElevation;
			BaseElevation = default(double);
			int NumberStories;
			NumberStories = default(int);
			string[] StoryNames, SimilarToStory;
			StoryNames = SimilarToStory = default(string[]);
			double[] StoryElevations, StoryHeights, SpliceHeight;
			StoryElevations = StoryHeights = SpliceHeight = default(double[]);
			bool[] IsMasterStory, SpliceAbove;
			IsMasterStory = SpliceAbove = default(bool[]);
			int[] color;
			color = default(int[]);
		    var res = obj.GetStories_2(ref BaseElevation, ref NumberStories, ref StoryNames, ref StoryElevations, ref StoryHeights, ref IsMasterStory, ref SimilarToStory, ref SpliceAbove, ref SpliceHeight, ref color);
		    return (BaseElevation, NumberStories, StoryNames, StoryElevations, StoryHeights, IsMasterStory, SimilarToStory, SpliceAbove, SpliceHeight, color);
		}

    }
}