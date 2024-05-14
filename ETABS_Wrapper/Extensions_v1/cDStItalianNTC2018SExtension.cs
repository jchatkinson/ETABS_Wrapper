using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cDStItalianNTC2018SExtension
    {
		public static (string textValue, double numericValue, bool ProgDet)
		    GetOverwrite(this cDStItalianNTC2018S obj, string Name, int Item) {
			string textValue;
			textValue = default(string);
			double numericValue;
			numericValue = default(double);
			bool ProgDet;
			ProgDet = default(bool);
		    var res = obj.GetOverwrite(Name, Item, ref textValue, ref numericValue, ref ProgDet);
		    return (textValue, numericValue, ProgDet);
		}
		public static (string textValue, double numericValue)
		    GetPreference(this cDStItalianNTC2018S obj, int Item) {
			string textValue;
			textValue = default(string);
			double numericValue;
			numericValue = default(double);
		    var res = obj.GetPreference(Item, ref textValue, ref numericValue);
		    return (textValue, numericValue);
		}

    }
}