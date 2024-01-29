using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectInCollisionBehaviour : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out SpellInteractionRespawnBehaviour interactionBehaviour)) 
            interactionBehaviour.RespawnWhenDestroy();

        Destroy(collision.gameObject);
    }
}
