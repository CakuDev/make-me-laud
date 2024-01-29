using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastSpellBehaviour : MonoBehaviour
{

    [SerializeField] private float castCooldown;
    [SerializeField] private GameObject spell;
    [SerializeField] private Transform spellOrigin;

    private bool canCast = true;

    public void Cast(Vector2 spellDestination)
    {
        // Manage cast cooldown
        if (!canCast) return;
        canCast = false;
        Invoke(nameof(ActiveCast), castCooldown);
        
        // Create spell
        SpellBehaviour spellBehaviour = Instantiate(spell, spellOrigin.position, transform.rotation).GetComponent<SpellBehaviour>();
        spellBehaviour.OnCreate(spellDestination);
    }

    private void ActiveCast()
    {
        canCast = true;
    }
}
