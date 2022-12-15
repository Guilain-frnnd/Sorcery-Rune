using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using static SObjSpell;
using static Row;

public class spellAlgo
{
    public static SObjSpell FindSpell(Row[] wall, List<SObjSpell> spellList)
    {
        foreach (var spell in spellList)
        {
            if (spell.spell == wall)
            {
                return spell;
            }
        }
        return null;
    }
}
