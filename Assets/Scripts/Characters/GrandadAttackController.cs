using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandadAttackController : SpellInteractionBehaviour
{
    [SerializeField] private GrandadController grandadController;
    [SerializeField] private Animator parentAnimator;
    [SerializeField] private Transform initialBallPosition;
    [SerializeField] private GameObject ball;

    public override void Interact()
    {
        grandadController.currentLifes--;
        parentAnimator.SetTrigger("damage");
        canLaugh = false;
    }

    public void GenerateBall()
    {
        BallBehaviour ballBehaviour = Instantiate(ball, initialBallPosition.position, ball.transform.rotation).GetComponent<BallBehaviour>();
        float angle = Random.Range(Mathf.Deg2Rad * 230f, Mathf.Deg2Rad * 310f);
        ballBehaviour.movementDirection = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)).normalized;
    }

    public void Disable()
    {
        StartCoroutine(DisableCoroutine());
    }

    IEnumerator DisableCoroutine()
    {
        while (gameObject.activeSelf)
        {
            if (parentAnimator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "idle") gameObject.SetActive(false);
            yield return null;
        }
    }
}
