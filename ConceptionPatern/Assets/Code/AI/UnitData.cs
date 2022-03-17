using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(order = 0, menuName = ("Units"), fileName = "New Unit Data")]
public class UnitData : ScriptableObject
{
    public UnitType unitType;
    public enum UnitType{Air, Ground, Underground}

    public float moveSpeed;
    public float callbackSpeed;
    public float attackSpeed;
    public int maxHealthPoint;

}
