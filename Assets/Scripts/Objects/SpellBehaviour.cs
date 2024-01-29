using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBehaviour : MonoBehaviour
{
    [SerializeField] private MovementController movementController;
    [SerializeField] private GameObject explosion;
    [SerializeField] private Animator animator;

    private Vector2 movementDirection;

    public void OnCreate(Vector2 destination)
    {
        movementDirection = (destination - (Vector2) transform.position).normalized;
    }

    void FixedUpdate()
    {
        movementController.Move(movementDirection);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If collide with an Spell Interactuable object, activate the explosion animation and interact with the gameObject
        SpellInteractionBehaviour[] spellInteractionBehaviours = collision.GetComponents<SpellInteractionBehaviour>();
        if (spellInteractionBehaviours.Length == 0) return;
        
        foreach (SpellInteractionBehaviour behaviour in spellInteractionBehaviours)
        {
            if (!behaviour.canLaugh) continue;
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
            behaviour.Interact();
        }
    }

    public void Disappear()
    {
        animator.SetTrigger("disappear");
    }
}
