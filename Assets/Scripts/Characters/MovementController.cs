using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float speed;

    public void Move(Vector2 movementVector)
    {
        transform.Translate(speed * Time.deltaTime * movementVector);
    }
}
