using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.AttributeUsage(System.AttributeTargets.Field,AllowMultiple = true ,Inherited = true)]
public class LockPropertyAttribute : PropertyAttribute
{
    public Color color {
        get;
        set;
    }
    public LockPropertyAttribute() {
        this.color = new Color(0, 0, 0);
    }
    public LockPropertyAttribute(Color fColor) {
        this.color = new Color(0, 0, 0);
    }
    public LockPropertyAttribute(float r, float g, float b) {
        this.color = new Color(r, g, b);
    }

}
