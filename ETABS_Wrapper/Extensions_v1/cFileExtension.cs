using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cFileExtension
    {
		public static string
		    GetFilePath(this cFile obj) {
			string FilePath;
			FilePath = default(string);
		    var res = obj.GetFilePath(ref FilePath);
		    return FilePath;
		}

    }
}