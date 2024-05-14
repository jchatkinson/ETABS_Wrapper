using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cDConcSlabACI318_19Extension
    {
		public static (string textValue, double numericValue)
		    GetPreference(this cDConcSlabACI318_19 obj, int Item) {
			string textValue;
			textValue = default(string);
			double numericValue;
			numericValue = default(double);
		    var res = obj.GetPreference(Item, ref textValue, ref numericValue);
		    return (textValue, numericValue);
		}

    }
}