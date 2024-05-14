using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cDesignStripExtension
    {
		public static (string[] Point, double[] GlobalX, double[] GlobalY, double[] GlobalZ, double[] WBLeft, double[] WBRight, double[] WALeft, double[] WARight, bool[] AutoWiden)
		    GetDesignStrip(this cDesignStrip obj, string Name) {
			string[] Point;
			Point = default(string[]);
			double[] GlobalX, GlobalY, GlobalZ, WBLeft, WBRight, WALeft, WARight;
			GlobalX = GlobalY = GlobalZ = WBLeft = WBRight = WALeft = WARight = default(double[]);
			bool[] AutoWiden;
			AutoWiden = default(bool[]);
		    var res = obj.GetDesignStrip(Name, ref Point, ref GlobalX, ref GlobalY, ref GlobalZ, ref WBLeft, ref WBRight, ref WALeft, ref WARight, ref AutoWiden);
		    return (Point, GlobalX, GlobalY, GlobalZ, WBLeft, WBRight, WALeft, WARight, AutoWiden);
		}
		public static string
		    GetGUID(this cDesignStrip obj, string Name) {
			string GUID;
			GUID = default(string);
		    var res = obj.GetGUID(Name, ref GUID);
		    return GUID;
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cDesignStrip obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (int DesignType, string[] Point, double[] GlobalX, double[] GlobalY, double[] GlobalZ, double[] WBLeft, double[] WBRight, double[] WALeft, double[] WARight, bool[] AutoWiden)
		    GetDesignStrip_1(this cDesignStrip obj, string Name) {
			int DesignType;
			DesignType = default(int);
			string[] Point;
			Point = default(string[]);
			double[] GlobalX, GlobalY, GlobalZ, WBLeft, WBRight, WALeft, WARight;
			GlobalX = GlobalY = GlobalZ = WBLeft = WBRight = WALeft = WARight = default(double[]);
			bool[] AutoWiden;
			AutoWiden = default(bool[]);
		    var res = obj.GetDesignStrip_1(Name, ref DesignType, ref Point, ref GlobalX, ref GlobalY, ref GlobalZ, ref WBLeft, ref WBRight, ref WALeft, ref WARight, ref AutoWiden);
		    return (DesignType, Point, GlobalX, GlobalY, GlobalZ, WBLeft, WBRight, WALeft, WARight, AutoWiden);
		}

    }
}