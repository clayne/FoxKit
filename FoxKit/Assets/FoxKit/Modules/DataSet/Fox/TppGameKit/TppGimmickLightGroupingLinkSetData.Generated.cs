//------------------------------------------------------------------------------ 
// <auto-generated> 
// This code was automatically generated.
// 
// Changes to this file may cause incorrect behavior and will be lost if 
// the code is regenerated. 
// </auto-generated> 
//------------------------------------------------------------------------------
namespace FoxKit.Modules.DataSet.Fox.TppGameKit
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
    public partial class TppGimmickLightGroupingLinkSetData : Data
    {
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityLink, 120, 1, Core.ContainerType.DynamicArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private List<FoxKit.Modules.DataSet.FoxCore.EntityLink> ownerGimmickList = new List<FoxKit.Modules.DataSet.FoxCore.EntityLink>();
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.String, 136, 1, Core.ContainerType.DynamicArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private List<System.String> gimmickNameList = new List<System.String>();
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityLink, 152, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private FoxKit.Modules.DataSet.FoxCore.EntityLink light;
    }
}
