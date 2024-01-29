using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class YayaBehaviour : SpellInteractionRespawnBehaviour
{
    [SerializeField] private PermanentMovementController permanentMovementController;
    [SerializeField] private GameObject babyCart;
    [SerializeField] private Transform babyCartPosition;

    override public void Interact()
    {
        base.Interact();
        permanentMovementController.canMove = false;

        Instantiate(babyCart, babyCartPosition.position, transform.rotation);
        Destroy(babyCartPosition.gameObject);
    }
}
