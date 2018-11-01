﻿namespace FoxKit.Modules.DataSet.FoxCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using FoxKit.Modules.DataSet.Exporter;
    using FoxKit.Utils;

    using FoxLib;

    using OdinSerializer;

    using UnityEditor;

    using UnityEngine;

    /// <inheritdoc />
    /// <summary>
    /// Container for a set of Fox Engine entities.
    /// </summary>
    [Serializable]
    public class DataSet : Data
    {
        /// <summary>
        /// The data list.
        /// </summary>
        [OdinSerialize, PropertyInfo(Core.PropertyInfoType.EntityHandle, 120, container: Core.ContainerType.StringMap, readable: PropertyExport.Never, writable: PropertyExport.Never)]
        private Dictionary<string, Data> dataList = new Dictionary<string, Data>();

        public string OwningDataSetName;
        
        /// <inheritdoc />
        public override Texture2D Icon => EditorGUIUtility.ObjectContent(null, typeof(BoxCollider)).image as Texture2D;

        /// <inheritdoc />
        public override short ClassId => 232;

        public delegate SceneProxy CreateSceneProxyForEntityDelegate(string entityName);

        public delegate void DestroySceneProxyForEntityDelegate(string entityName);

        /// <summary>
        /// Loads all owned Entities.
        /// </summary>
        public void LoadAllEntities(CreateSceneProxyForEntityDelegate createSceneProxy, GetSceneProxyDelegate getSceneProxy)
        {
            foreach (var data in this.dataList.Values)
            {
                data.OnLoaded(() => createSceneProxy(data.Name));
            }

            foreach (var data in this.dataList.Values)
            {
                data.PostOnLoaded(getSceneProxy);
            }
        }

        /// <summary>
        /// Unloads all owned Entities.
        /// </summary>
        public void UnloadAllEntities(DestroySceneProxyForEntityDelegate destroySceneProxy)
        {
            foreach (var data in this.dataList.Values)
            {
                data?.OnUnloaded(() => destroySceneProxy(data.Name));
            }
        }

        /// <inheritdoc />
        public override void OnAssetsImported(FoxKit.Core.AssetPostprocessor.TryGetAssetDelegate tryGetAsset)
        {
            base.OnAssetsImported(tryGetAsset);

            foreach (var kvp in this.dataList)
            {
                kvp.Value.OnAssetsImported(tryGetAsset);
            }
        }

        /// <summary>
        /// Adds an Entity to the DataSet.
        /// </summary>
        /// <param name="key">
        /// The string key (name) of the Entity.
        /// </param>
        /// <param name="address">
        /// The memory address of the Entity. Only needed when loading from a DataSet file.
        /// </param>
        /// <param name="entity">
        /// The entity to add.
        /// </param>
        public void AddData(string key, Data entity)
        {
            if (entity != null)
            {
                // TODO Add scene proxy?
                this.dataList.Add(key, entity);
            }
        }
        
        /// <summary>
        /// Removes an Entity with the given key.
        /// </summary>
        /// <param name="key">The key to remove.</param>
        public void RemoveData(string key)
        {
            this.dataList.Remove(key);
        }
        
        /// <summary>
        /// Get an entry by name.
        /// </summary>
        /// <param name="key">
        /// The string key (name) of the Entity.
        /// </param>
        /// <returns>
        /// The <see cref="Entity"/> with the given key.
        /// </returns>
        public Data GetData(string key)
        {
            if (this.dataList.ContainsKey(key))
            {
                return this.dataList[key];
            }

            Debug.LogError($"No Entity named {key} was present in the DataSet.");
            return null;
        }

        /// <summary>
        /// Get all of the Data Entities owned by this DataSet.
        /// </summary>
        /// <returns>
        /// All registered <see cref="Data"/> entries with their keys.
        /// </returns>
        public IDictionary<string, Data> GetDataList()
        {
            return this.dataList;
        }

        /// <summary>
        /// Get all of the Entities, including DataElements, owned by this DataSet.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Entity> GetAllEntities()
        {
            var result = new List<Entity>();

            foreach (var data in this.dataList.Values)
            {
                result.Add(data);
                result.AddRange(from dataElement in data.GetDataElements()
                                where dataElement != null
                                select dataElement);
            }

            return result;
        }
    }
}