using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public class RequiredTypeAttribute : PropertyAttribute
{
    public Type RequiredType { get; private set; }

    public RequiredTypeAttribute(Type requiredType)
    {
        RequiredType = requiredType;
    }
}
