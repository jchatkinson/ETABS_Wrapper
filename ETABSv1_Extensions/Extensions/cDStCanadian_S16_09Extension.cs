using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cDStCanadian_S16_09Extension
    {
		public static (double Value, bool ProgDet)
		    GetOverwrite(this cDStCanadian_S16_09 obj, string Name, int Item) {
			double Value;
			Value = default(double);
			bool ProgDet;
			ProgDet = default(bool);
		    var res = obj.GetOverwrite(Name, Item, ref Value, ref ProgDet);
		    return (Value, ProgDet);
		}
		public static double
		    GetPreference(this cDStCanadian_S16_09 obj, int Item) {
			double Value;
			Value = default(double);
		    var res = obj.GetPreference(Item, ref Value);
		    return Value;
		}

    }
}