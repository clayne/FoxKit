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
    public partial class StringArrayPropertyDifference : PropertyDifference
    {
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.String, 72, 1, Core.ContainerType.DynamicArray, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private List<System.String> originalValues = new List<System.String>();
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.String, 88, 1, Core.ContainerType.DynamicArray, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private List<System.String> values = new List<System.String>();
    }
}
