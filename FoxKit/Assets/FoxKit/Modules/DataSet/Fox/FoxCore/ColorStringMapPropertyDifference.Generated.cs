//------------------------------------------------------------------------------ 
// <auto-generated> 
// This code was automatically generated.
// 
// Changes to this file may cause incorrect behavior and will be lost if 
// the code is regenerated. 
// </auto-generated> 
//------------------------------------------------------------------------------
namespace FoxKit.Modules.DataSet.Fox.FoxCore
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
    public partial class ColorStringMapPropertyDifference : PropertyDifference
    {
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Color, 72, 1, Core.ContainerType.StringMap, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private Dictionary<string, UnityEngine.Color> originalValues = new Dictionary<string, UnityEngine.Color>();
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Color, 120, 1, Core.ContainerType.StringMap, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private Dictionary<string, UnityEngine.Color> values = new Dictionary<string, UnityEngine.Color>();
    }
}
