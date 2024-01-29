using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageLaughBehaviour : MonoBehaviour
{
    [SerializeField] SpellInteractionBehaviour spellInteractionBehaviour;

    public void EnableLaugh()
    {
        spellInteractionBehaviour.canLaugh = true;
    }

    public void DisableLaugh()
    {
        spellInteractionBehaviour.canLaugh = false;
    }
}
