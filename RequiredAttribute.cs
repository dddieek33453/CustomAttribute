using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.AttributeUsage(System.AttributeTargets.Field,AllowMultiple = true, Inherited = true)]
public class RequiredAttribute : PropertyAttribute
{
    public readonly bool showErrorBox = true;
    public readonly string errorMessage = "[Required Component]";
    public readonly Color allowColor = Color.black;
    public readonly Color errorColor = Color.red;
    public RequiredAttribute() {
    }
    public RequiredAttribute(bool showErrorBox) {
        this.showErrorBox = showErrorBox;
    }
    public RequiredAttribute(string errorMessage) {
        this.errorMessage = errorMessage;
    }
    public RequiredAttribute(float allowColorR, float allowColorG, float allowColorB, float errorColorR, float errorColorG, float errorColorB) {
        this.allowColor = new Color(allowColorR, allowColorG, allowColorB);
        this.errorColor = new Color(errorColorR, errorColorG, errorColorB);
    }
    public RequiredAttribute(bool showErrorBox, float allowColorR, float allowColorG, float allowColorB, float errorColorR, float errorColorG, float errorColorB) {
        this.showErrorBox = showErrorBox;
        this.allowColor = new Color(allowColorR, allowColorG, allowColorB);
        this.errorColor = new Color(errorColorR, errorColorG, errorColorB);
    }
    public RequiredAttribute(string errorMessage, float allowColorR, float allowColorG, float allowColorB, float errorColorR, float errorColorG, float errorColorB) {
        this.errorMessage = errorMessage;
        this.allowColor = new Color(allowColorR, allowColorG, allowColorB);
        this.errorColor = new Color(errorColorR, errorColorG, errorColorB);
    }
}
