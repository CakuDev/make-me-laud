using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationWithMouseBehaviour : MonoBehaviour
{
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 rotationDirection = ((Vector2) transform.position - mousePosition).normalized;
        transform.right = -rotationDirection;
    }
}
