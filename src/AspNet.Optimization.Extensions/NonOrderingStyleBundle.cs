using System;
using System.Collections.Generic;
using System.Web.Optimization;

namespace AspNet.Optimization.Extensions
{
    public sealed class NonOrderingStyleBundle : StyleBundle
    {
        public NonOrderingStyleBundle(String virtualPath) : base(virtualPath)
        {
            Orderer = new NonOrderingBundleOrderer();
        }

        public NonOrderingStyleBundle(String virtualPath, String cdnPath) : base(virtualPath, cdnPath)
        {
            Orderer = new NonOrderingBundleOrderer();
        }
    }
}
