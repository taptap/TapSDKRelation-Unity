using TapSDK.Core;
using TapSDK.Core.Internal.Init;
using UnityEngine;

namespace TapSDK.Relation.Internal.Init {
    public class RelationInitTask : IInitTask {
        public int Order => 104;

        public void Init(TapTapSdkOptions coreOption, TapTapSdkBaseOptions[] otherOptions)
        {
            Debug.LogWarningFormat("[TapSDK-init]Relation task init: " + "clientId=" + coreOption.clientId + ", region=" + coreOption.region + ", screenOrientation=" + coreOption.screenOrientation);
            TapTapRelationManager.Instance.Init(coreOption.clientId, coreOption.region, coreOption.screenOrientation);
        }

        public void Init(TapTapSdkOptions coreOption)
        {
            TapTapRelationManager.Instance.Init(coreOption.clientId, coreOption.region, coreOption.screenOrientation);
        }
    }
}