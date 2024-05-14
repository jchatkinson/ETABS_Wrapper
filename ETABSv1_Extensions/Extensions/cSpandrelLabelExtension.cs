using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cSpandrelLabelExtension
    {
		public static bool
		    GetSpandrel(this cSpandrelLabel obj, string Name) {
			bool IsMultiStory;
			IsMultiStory = default(bool);
		    var res = obj.GetSpandrel(Name, ref IsMultiStory);
		    return IsMultiStory;
		}
		public static (int NumberNames, string[] MyName, bool[] IsMultiStory)
		    GetNameList(this cSpandrelLabel obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
			bool[] IsMultiStory;
			IsMultiStory = default(bool[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName, ref IsMultiStory);
		    return (NumberNames, MyName, IsMultiStory);
		}
		public static (int NumberStories, string[] StoryName, int[] NumAreaObj, int[] NumLineObj, double[] Length, double[] DepthLeft, double[] ThickLeft, double[] DepthRight, double[] ThickRight, string[] MatProp, double[] CGLeftX, double[] CGLeftY, double[] CGLeftZ, double[] CGRightX, double[] CGRightY, double[] CGRightZ)
		    GetSectionProperties(this cSpandrelLabel obj, string Name) {
			int NumberStories;
			NumberStories = default(int);
			string[] StoryName, MatProp;
			StoryName = MatProp = default(string[]);
			int[] NumAreaObj, NumLineObj;
			NumAreaObj = NumLineObj = default(int[]);
			double[] Length, DepthLeft, ThickLeft, DepthRight, ThickRight, CGLeftX, CGLeftY, CGLeftZ, CGRightX, CGRightY, CGRightZ;
			Length = DepthLeft = ThickLeft = DepthRight = ThickRight = CGLeftX = CGLeftY = CGLeftZ = CGRightX = CGRightY = CGRightZ = default(double[]);
		    var res = obj.GetSectionProperties(Name, ref NumberStories, ref StoryName, ref NumAreaObj, ref NumLineObj, ref Length, ref DepthLeft, ref ThickLeft, ref DepthRight, ref ThickRight, ref MatProp, ref CGLeftX, ref CGLeftY, ref CGLeftZ, ref CGRightX, ref CGRightY, ref CGRightZ);
		    return (NumberStories, StoryName, NumAreaObj, NumLineObj, Length, DepthLeft, ThickLeft, DepthRight, ThickRight, MatProp, CGLeftX, CGLeftY, CGLeftZ, CGRightX, CGRightY, CGRightZ);
		}

    }
}