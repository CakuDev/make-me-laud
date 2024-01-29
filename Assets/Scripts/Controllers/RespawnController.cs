using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour
{
    [SerializeField] public GameObject objectToRespawn;
    [SerializeField] public float respawnDelay;

    [HideInInspector] public bool canRespawn = true;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(respawnDelay);
        Respawn();
    }

    public void Respawn()
    {
        if (!canRespawn) return;

        GameObject spawnObject = Instantiate(objectToRespawn, transform.position, transform.rotation);
        if (spawnObject.TryGetComponent(out SpellInteractionRespawnBehaviour interactionRespawnBehaviour))
            interactionRespawnBehaviour.respawnController = this;
    }
}
