using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PermanentMovementController : MonoBehaviour
{
    [SerializeField] private MovementController movementController;
    [SerializeField] private Vector2 movementDirection = Vector2.left;

    [HideInInspector] public bool canMove = true;

    private void FixedUpdate()
    {
        if (canMove) movementController.Move(movementDirection);
    }
}
