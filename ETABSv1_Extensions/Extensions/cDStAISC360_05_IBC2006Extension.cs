using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cDStAISC360_05_IBC2006Extension
    {
		public static (double Value, bool ProgDet)
		    GetOverwrite(this cDStAISC360_05_IBC2006 obj, string Name, int Item) {
			double Value;
			Value = default(double);
			bool ProgDet;
			ProgDet = default(bool);
		    var res = obj.GetOverwrite(Name, Item, ref Value, ref ProgDet);
		    return (Value, ProgDet);
		}
		public static double
		    GetPreference(this cDStAISC360_05_IBC2006 obj, int Item) {
			double Value;
			Value = default(double);
		    var res = obj.GetPreference(Item, ref Value);
		    return Value;
		}

    }
}