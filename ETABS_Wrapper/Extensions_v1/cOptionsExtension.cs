using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cOptionsExtension
    {
		public static string
		    GetDefaultFunctionFolder(this cOptions obj) {
			string Path;
			Path = default(string);
		    var res = obj.GetDefaultFunctionFolder(ref Path);
		    return Path;
		}

    }
}