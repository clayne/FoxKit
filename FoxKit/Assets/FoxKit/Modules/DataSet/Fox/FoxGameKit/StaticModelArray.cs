using UnityEditor;
using UnityEngine;

namespace FoxKit.Modules.DataSet.Fox.FoxGameKit
{
    public enum StaticModelArray_DrawRejectionLevel : int
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

    public enum StaticModelArray_DrawMode : int
    {
        Normal = 0,
        ShadowOnly = 1,
        DisableShadow = 2
    }

    public enum StaticModelArray_RejectFarRangeShadowCast : int
    {
        NoReject = 0,
        Reject = 1,
        Default = 2
    }

    public partial class StaticModelArray
    {
        public override Texture2D Icon => EditorGUIUtility.ObjectContent(null, typeof(LODGroup)).image as Texture2D;
    }
}
