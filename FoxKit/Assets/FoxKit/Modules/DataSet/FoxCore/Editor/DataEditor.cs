﻿using UnityEditor;

namespace FoxKit.Modules.DataSet.FoxCore.Editor
{
    [CustomEditor(typeof(Data), true)]
    public class DataEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            var prop = this.serializedObject.GetIterator();
            if (prop.NextVisible(true))
            {
                do
                {
                    // We don't care about Unity's default "script" field.
                    if (prop.name == "m_Script")
                    {
                        continue;
                    }
                    EditorGUILayout.PropertyField(this.serializedObject.FindProperty(prop.name), true);
                }
                while (prop.NextVisible(false));
            }

            this.serializedObject.ApplyModifiedProperties();
        }
    }
}