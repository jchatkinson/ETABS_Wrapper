using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cTowerExtension
    {
		public static string
		    GetActiveTower(this cTower obj) {
			string TowerName;
			TowerName = default(string);
		    var res = obj.GetActiveTower(ref TowerName);
		    return TowerName;
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cTower obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}

    }
}