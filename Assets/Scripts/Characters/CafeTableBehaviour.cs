using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CafeTableBehaviour : SpellInteractionBehaviour
{
    public override void Interact()
    {
        if (!canLaugh) return;

        canLaugh = false;
        float animationTime = animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
        animator.Play("Base Layer.Laugh", 0, animationTime);
    }
}
