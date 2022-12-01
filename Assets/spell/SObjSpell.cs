using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Spell", menuName = "Spell", order = 1)]
[SerializeField]
[Serializable]
public class SObjSpell : ScriptableObject
{
    [SerializeField]
    public string spellName;

    [SerializeField]
    public mouvement[] move;
}