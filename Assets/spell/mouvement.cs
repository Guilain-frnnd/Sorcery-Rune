using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class mouvement
{
    public enum moves
    {
        Haut,
        Bas,
        Gauche,
        Droit
    }
    public moves move;
}
