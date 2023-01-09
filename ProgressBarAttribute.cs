using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.AttributeUsage(System.AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public class ProgressBarAttribute : PropertyAttribute
{
    public readonly float value1;
    public readonly float value2;
    public ProgressBarAttribute(float value1, float value2) {
        this.value1 = value1;
        this.value2 = value2;
    }

}
