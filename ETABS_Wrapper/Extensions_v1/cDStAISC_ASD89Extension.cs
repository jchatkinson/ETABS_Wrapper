using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cDStAISC_ASD89Extension
    {
		public static (double Value, bool ProgDet)
		    GetOverwrite(this cDStAISC_ASD89 obj, string Name, int Item) {
			double Value;
			Value = default(double);
			bool ProgDet;
			ProgDet = default(bool);
		    var res = obj.GetOverwrite(Name, Item, ref Value, ref ProgDet);
		    return (Value, ProgDet);
		}
		public static double
		    GetPreference(this cDStAISC_ASD89 obj, int Item) {
			double Value;
			Value = default(double);
		    var res = obj.GetPreference(Item, ref Value);
		    return Value;
		}

    }
}