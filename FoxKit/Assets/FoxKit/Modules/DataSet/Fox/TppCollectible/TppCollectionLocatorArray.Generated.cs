//------------------------------------------------------------------------------ 
// <auto-generated> 
// This code was automatically generated.
// 
// Changes to this file may cause incorrect behavior and will be lost if 
// the code is regenerated. 
// </auto-generated> 
//------------------------------------------------------------------------------
namespace FoxKit.Modules.DataSet.Fox.TppCollectible
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
    public partial class TppCollectionLocatorArray : Data
    {
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Vector3, 120, 1, Core.ContainerType.DynamicArray, PropertyExport.Never, PropertyExport.Never, null, null)]
        private List<UnityEngine.Vector3> positions = new List<UnityEngine.Vector3>();
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.UInt32, 136, 1, Core.ContainerType.DynamicArray, PropertyExport.Never, PropertyExport.Never, null, null)]
        private List<System.UInt32> rotations = new List<System.UInt32>();
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.UInt32, 152, 1, Core.ContainerType.DynamicArray, PropertyExport.Never, PropertyExport.Never, null, null)]
        private List<System.UInt32> infos = new List<System.UInt32>();
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.UInt16, 168, 1, Core.ContainerType.DynamicArray, PropertyExport.Never, PropertyExport.Never, null, null)]
        private List<System.UInt16> segmentIndices = new List<System.UInt16>();
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.UInt16, 184, 1, Core.ContainerType.DynamicArray, PropertyExport.Never, PropertyExport.Never, null, null)]
        private List<System.UInt16> locatorIndices = new List<System.UInt16>();
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.UInt16, 200, 1, Core.ContainerType.DynamicArray, PropertyExport.Never, PropertyExport.Never, null, null)]
        private List<System.UInt16> locatorCounts = new List<System.UInt16>();
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.UInt8, 216, 1, Core.ContainerType.DynamicArray, PropertyExport.Never, PropertyExport.Never, null, null)]
        private List<System.Byte> groupIds = new List<System.Byte>();
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.UInt16, 232, 1, Core.ContainerType.DynamicArray, PropertyExport.Never, PropertyExport.Never, null, null)]
        private List<System.UInt16> segmentInfoIndices = new List<System.UInt16>();
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.UInt16, 248, 1, Core.ContainerType.DynamicArray, PropertyExport.Never, PropertyExport.Never, null, null)]
        private List<System.UInt16> segmentInfoCounts = new List<System.UInt16>();
    }
}
