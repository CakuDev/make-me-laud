using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] private MovementController movementController;

    [HideInInspector] public Vector2 movementDirection;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer != LayerMask.NameToLayer("Main Character")) return;
        collision.GetComponent<InputController>().Paralized();
        Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        movementController.Move(movementDirection);
    }
}
