using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Animator parentAnimator;
    [SerializeField] private Transform sprite;
    [SerializeField] private UnityEvent<Vector2> onMovement;
    [SerializeField] private UnityEvent<Vector2> onClick;

    [HideInInspector] public bool canAct = true;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Read input and invoke movement event if any movement exists
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0 && canAct)
        {
            onMovement.Invoke(new(horizontalInput, 0));
            animator.SetBool("walk", true);
            float scale = horizontalInput > 0 ? 1 : -1;
            sprite.localScale = new(scale, 1, 1);
        } else
        {
            animator.SetBool("walk", false);
        }
    }

    private void Update()
    {
        // Read click and invoke
        if (Input.GetMouseButtonDown(0) && canAct) onClick.Invoke(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }

    public void Paralized()
    {
        canAct = false;
        parentAnimator.SetTrigger("damage");
    }

    public void Deparalized()
    {
        canAct = true;
    }
}
