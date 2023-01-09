using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomPropertyDrawer(typeof(LockPropertyAttribute),true),CanEditMultipleObjects]
public class LockPropertyDrawer : PropertyDrawer {
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
        LockPropertyAttribute attri = (LockPropertyAttribute)attribute;
        GUI.enabled = false;
        EditorStyles.label.normal.textColor = attri.color;
        EditorGUI.PropertyField(position, property,label);
        GUI.enabled = true;
        EditorStyles.label.normal.textColor = Color.black;
    }
}
