using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;

[CustomPropertyDrawer(typeof(LabelColorAttribute))]
public class LabelColorDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
        LabelColorAttribute attri = (LabelColorAttribute)attribute;
        Color oldColor = EditorStyles.label.normal.textColor;
        if (attri.label != "")
            label.text = attri.label;

        EditorStyles.label.normal.textColor = attri.color;
        EditorGUI.PropertyField(position,property,label);
        EditorStyles.label.normal.textColor = oldColor;
    }
}
