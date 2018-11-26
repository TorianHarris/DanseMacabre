using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Effect", menuName = "Effect")]
public class AttackSingle : Effect {
    public int damage;

    public override void Activate()
    {
        Debug.Log(string.Format("Enemy lost {0} health!", damage));
    }
}
