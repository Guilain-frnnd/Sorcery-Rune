using UnityEngine;
using System;
using System.Linq;
using System.Collections.Generic;


[Serializable]
public class Row
{
    public bool[] Lines = new bool[5];
}

[CreateAssetMenu(fileName = "Spell", menuName = "Spell", order = 1)]
[SerializeField]
[Serializable]
public class SObjSpell : ScriptableObject
{
    [SerializeField]
    public string spellName;

    [SerializeField]
    public Row[] spell = new Row[5];

}