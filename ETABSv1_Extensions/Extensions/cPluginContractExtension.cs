using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cPluginContractExtension
    {
		public static (cSapModel SapModel, cPluginCallback ISapPlugin)
		    Main(this cPluginContract obj) {
			cSapModel SapModel;
			SapModel = default(cSapModel);
			cPluginCallback ISapPlugin;
			ISapPlugin = default(cPluginCallback);
		    var res = obj.Main(ref SapModel, ref ISapPlugin);
		    return (SapModel, ISapPlugin);
		}
		public static string
		    Info(this cPluginContract obj) {
			string Text;
			Text = default(string);
		    var res = obj.Info(ref Text);
		    return Text;
		}

    }
}