using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GrandadController : MonoBehaviour
{
    [SerializeField] private int maxLifes = 3;
    [SerializeField] private CameraController cameraController;
    [SerializeField] private InputController inputController;
    [SerializeField] private GameObject grandadAnimation;
    [SerializeField] private GameObject[] grandadAttacks;
    [SerializeField] private GameObject grandadLaugh;
    [SerializeField] private GameObject scooter;
    [SerializeField] private GameObject colliders;

    [HideInInspector] public int currentLifes;

    private void Start()
    {
        currentLifes = maxLifes;
    }

    public void Enable()
    {
        StartCoroutine(EnableCoroutine());
    }

    IEnumerator EnableCoroutine()
    {
        inputController.canAct = false;
        colliders.SetActive(true);
        cameraController.BlockCameraFinalBoss();
        yield return new WaitForSeconds(2.2f);
        grandadAnimation.SetActive(true);
        yield return new WaitForSeconds(1.75f);
        inputController.canAct = true;
        yield return new WaitForSeconds(0.75f);

        while (currentLifes > 0)
        {
            GameObject grandadAttack = grandadAttacks[Random.Range(0, grandadAttacks.Length)];
            grandadAttack.SetActive(true);
            grandadAttack.GetComponent<GrandadAttackController>().canLaugh = true;
            yield return new WaitForSeconds(4f);
        }

        grandadLaugh.SetActive(true);
        yield return new WaitForSeconds(2f);
        scooter.SetActive(true);

    }
}
