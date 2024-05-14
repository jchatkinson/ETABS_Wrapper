using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cDConcSlabACI318_14Extension
    {
		public static (string textValue, double numericValue)
		    GetPreference(this cDConcSlabACI318_14 obj, int Item) {
			string textValue;
			textValue = default(string);
			double numericValue;
			numericValue = default(double);
		    var res = obj.GetPreference(Item, ref textValue, ref numericValue);
		    return (textValue, numericValue);
		}

    }
}