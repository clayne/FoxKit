//------------------------------------------------------------------------------ 
// <auto-generated> 
// This code was automatically generated.
// 
// Changes to this file may cause incorrect behavior and will be lost if 
// the code is regenerated. 
// </auto-generated> 
//------------------------------------------------------------------------------
namespace FoxKit.Modules.DataSet.Fox.UiScene
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
    public partial class UiModelNodeElement : DataElement
    {
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.String, 56, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.String modelNodeName;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Bool, 64, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Boolean visible;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Float, 68, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Single priority;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Vector3, 80, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private UnityEngine.Vector3 scale;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Quat, 96, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private UnityEngine.Quaternion rotQuat;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Vector3, 112, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private UnityEngine.Vector3 translate;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Color, 128, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private UnityEngine.Color color;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Int32, 144, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Int32 blendType;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Bool, 148, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Boolean returnInit;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Bool, 149, 1, Core.ContainerType.StaticArray, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private System.Boolean initVisible;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Float, 152, 1, Core.ContainerType.StaticArray, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private System.Single initPriority;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Vector3, 160, 1, Core.ContainerType.StaticArray, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private UnityEngine.Vector3 initScale;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Quat, 176, 1, Core.ContainerType.StaticArray, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private UnityEngine.Quaternion initRotQuat;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Vector3, 192, 1, Core.ContainerType.StaticArray, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private UnityEngine.Vector3 initTranslate;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Color, 208, 1, Core.ContainerType.StaticArray, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private UnityEngine.Color initColor;
        
        [OdinSerializeAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Int32, 224, 1, Core.ContainerType.StaticArray, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private System.Int32 initBlendType;
    }
}
