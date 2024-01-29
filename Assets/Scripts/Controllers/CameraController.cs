using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform mainCharacter;
    [SerializeField] private Vector2 boundaries;
    [SerializeField] private float finalBossXPosition = 19;
    [SerializeField] private float finalBossMovementSpeed = 1f;

    [HideInInspector] private bool canMove = true;
    private Vector3 originalPosition;

    private void LateUpdate()
    {
        if (!canMove) return;

        float xPosition = mainCharacter.position.x;
        if (xPosition < boundaries.x) xPosition = boundaries.x;
        if (xPosition > boundaries.y) xPosition = boundaries.y;

        transform.position = new(xPosition, transform.position.y, transform.position.z);
    }

    public void BlockCameraFinalBoss()
    {
        canMove = false;
        originalPosition = transform.position;
        StartCoroutine(MoveCameraAndBlockFinalBoss());
    }

    IEnumerator MoveCameraAndBlockFinalBoss()
    {
        Vector3 targetPosition = new(finalBossXPosition, 0, 0 - 10);

        float i = 0f;
        while (i < 1)
        {
            transform.position = Vector3.Lerp(originalPosition, targetPosition, i);
            i += Time.deltaTime * finalBossMovementSpeed;
            yield return null;
        }

        transform.position = targetPosition;
        yield return null;
    }
}
