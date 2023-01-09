using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
public class LabelColorAttribute : PropertyAttribute {
    public readonly string label;
    public readonly Color color;
    public LabelColorAttribute(string label, float r, float g, float b) {
        this.label = label;
        this.color = new Color(r, g, b);
    }
    public LabelColorAttribute(float r, float g, float b) {
        label = "";
        this.color = new Color(r,g,b);
    }
}
