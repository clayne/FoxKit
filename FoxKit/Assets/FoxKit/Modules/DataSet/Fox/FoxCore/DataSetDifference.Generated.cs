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
    public partial class DataSetDifference : Entity
    {
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityPtr, 48, 1, Core.ContainerType.StringMap, PropertyExport.Never, PropertyExport.Never, null, null)]
        private Dictionary<string, FoxKit.Modules.DataSet.Fox.FoxCore.Entity> dataList = new Dictionary<string, FoxKit.Modules.DataSet.Fox.FoxCore.Entity>();
    }
}
