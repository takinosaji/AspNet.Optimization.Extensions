using System;
using System.Collections.Generic;
using System.Web.Optimization;

namespace AspNet.Optimization.Extensions
{
    public sealed class NonOrderingScriptBundle : ScriptBundle
    {
        public NonOrderingScriptBundle(String virtualPath) : base(virtualPath)
        {
            Orderer = new NonOrderingBundleOrderer();
        }
        public NonOrderingScriptBundle(String virtualPath, String cdnPath) : base(virtualPath, cdnPath)
        {
            Orderer = new NonOrderingBundleOrderer();
        }
    }
}
