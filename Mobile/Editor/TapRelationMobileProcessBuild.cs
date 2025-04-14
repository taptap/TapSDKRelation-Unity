using System;
using UnityEditor.Build.Reporting;
using TapSDK.Core.Editor;

namespace TapTap.Relation.Mobile.Editor {
    public class TapRelationMobileProcessBuild : SDKLinkProcessBuild {
        public override int callbackOrder => 0;

        public override string LinkPath => "TapSDK/Relation/link.xml";

        public override LinkedAssembly[] LinkedAssemblies => new LinkedAssembly[] {
                    new LinkedAssembly { Fullname = "TapTap.Relation.Runtime" },
                    new LinkedAssembly { Fullname = "TapTap.Relation.Mobile.Runtime" }
                };

        public override Func<BuildReport, bool> IsTargetPlatform => (report) => {
            return BuildTargetUtils.IsSupportMobile(report.summary.platform);
        };
    }
}
