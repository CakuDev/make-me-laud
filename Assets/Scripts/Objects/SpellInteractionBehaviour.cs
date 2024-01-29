using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellInteractionBehaviour : MonoBehaviour
{
    public Animator animator;

    [HideInInspector] public bool canLaugh = true;

    virtual public void Interact()
    {
        if (!canLaugh) return;

        animator.SetTrigger("laugh");
        canLaugh = false;
    }
}
