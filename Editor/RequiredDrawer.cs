using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomPropertyDrawer(typeof(RequiredAttribute),true),CanEditMultipleObjects]
public class RequiredDrawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
        RequiredAttribute attri = (RequiredAttribute)attribute;
        float height = 0;
        if(attri.showErrorBox)
        if (property.propertyType == SerializedPropertyType.ObjectReference) {
            if (property.objectReferenceValue == null) {
                height = 20;
            }
        }
        return base.GetPropertyHeight(property, label) + height;
    }
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
        position.height = 18;
        Color oldColor = EditorStyles.label.normal.textColor;
        RequiredAttribute attri = (RequiredAttribute)attribute;
        if (property.propertyType != SerializedPropertyType.ObjectReference) {
            EditorStyles.label.normal.textColor = attri.errorColor;
            EditorGUI.LabelField(position, label, new GUIContent("Component 타입의 필드로 설정해주세요"));
        }
        else {
            if (property.objectReferenceValue != null) {
                EditorStyles.label.normal.textColor = attri.allowColor;
                EditorGUI.PropertyField(position, property, label);
            }
            else {
                EditorStyles.label.normal.textColor = attri.errorColor;
                if (attri.showErrorBox) {
                    GUI.color = attri.errorColor;
                    EditorGUI.HelpBox(position, attri.errorMessage, MessageType.Warning);
                    position.y += 20;
                    GUI.color = Color.white;
                }
                EditorGUI.PropertyField(position,property, label);
            }
        }

        EditorStyles.label.normal.textColor = oldColor;
    }
}
