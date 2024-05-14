using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cDCoACI318_11Extension
    {
		public static (double Value, bool ProgDet)
		    GetOverwrite(this cDCoACI318_11 obj, string Name, int Item) {
			double Value;
			Value = default(double);
			bool ProgDet;
			ProgDet = default(bool);
		    var res = obj.GetOverwrite(Name, Item, ref Value, ref ProgDet);
		    return (Value, ProgDet);
		}
		public static double
		    GetPreference(this cDCoACI318_11 obj, int Item) {
			double Value;
			Value = default(double);
		    var res = obj.GetPreference(Item, ref Value);
		    return Value;
		}

    }
}