//------------------------------------------------------------------------------ 
// <auto-generated> 
// This code was automatically generated.
// 
// Changes to this file may cause incorrect behavior and will be lost if 
// the code is regenerated. 
// </auto-generated> 
//------------------------------------------------------------------------------
namespace FoxKit.Modules.DataSet.Fox.Anim
{
    using System;
    using System.Collections.Generic;
    using FoxKit.Modules.DataSet.Fox.FoxCore;
    using FoxKit.Modules.Lua;
    using FoxLib;
    using KopiLua;
    using OdinSerializer;
    using UnityEngine;
    using DataSetFile2 = DataSetFile2;
    using FoxCore;
    
    [SerializableAttribute, ExposeClassToLuaAttribute]
    public partial class FacialSettingData : Data
    {
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityPtr, 120, 1, Core.ContainerType.DynamicArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, typeof(FacialMaskElement), null)]
        private List<FacialMaskElement> aspectMaskList = new List<FacialMaskElement>();
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityPtr, 136, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, typeof(FacialMaskElement), null)]
        private FacialMaskElement mouthMask;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityPtr, 144, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, typeof(FacialMaskElement), null)]
        private FacialMaskElement lipMask;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.String, 152, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.String rootName;
    }
}
