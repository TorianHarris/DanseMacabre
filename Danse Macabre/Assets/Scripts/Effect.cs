using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect : ScriptableObject 
{
    public new string name;
    public abstract void Activate();
}
