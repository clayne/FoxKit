//------------------------------------------------------------------------------ 
// <auto-generated> 
// This code was automatically generated.
// 
// Changes to this file may cause incorrect behavior and will be lost if 
// the code is regenerated. 
// </auto-generated> 
//------------------------------------------------------------------------------
namespace FoxKit.Modules.DataSet.Fox.FoxGameKit
{
    using UnityEngine;
    using UnityEngine.Assertions;

    using GameObject = FoxKit.Modules.DataSet.Fox.GameCore.GameObject;

    public enum StaticModel_DrawRejectionLevel : int
    {
        Level0 = 0,
        Level1 = 1,
        Level2 = 2,
        Level3 = 3,
        Level4 = 4,
        Level5 = 5,
        Level6 = 6,
        NoReject = 7,
        Default = 8
    }

    public enum StaticModel_DrawMode : int
    {
        Normal = 0,
        ShadowOnly = 1,
        DisableShadow = 2
    }

    public enum StaticModel_RejectFarRangeShadowCast : int
    {
        NoReject = 0,
        Reject = 1,
        Default = 2
    }

    public partial class StaticModel
    {
        public UnityEngine.Object ModelFile
        {
            get
            {
                return this.modelFile;
            }
            set
            {
                // TODO if loaded, change model
                this.modelFile = value;
            }
        }

        public StaticModel()
            : base()
        {
            this.lodFarSize = 1;
            this.lodNearSize = 1;
            this.lodPolygonSize = 1;
            this.color = Color.white;
            this.drawRejectionLevel = StaticModel_DrawRejectionLevel.Default;
            this.drawMode = StaticModel_DrawMode.Normal;
            this.rejectFarRangeShadowCast = StaticModel_RejectFarRangeShadowCast.Default;
        }
        
        public override void PostOnLoaded(GetSceneProxyDelegate getSceneProxy)
        {
            base.PostOnLoaded(getSceneProxy);

            if (this.ModelFile == null)
            {
                return;
            }

            var model = Object.Instantiate(this.ModelFile) as UnityEngine.GameObject;
            var sceneProxy = getSceneProxy(this.Name);
            model.transform.SetParent(sceneProxy.transform);
        }
    }
}
