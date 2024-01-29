using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRespawnController : MonoBehaviour
{
    [SerializeField] private RespawnController respawnController;
    [SerializeField] private GrandadController grandadController;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Main Character"))
        {
            respawnController.canRespawn = false;
            grandadController.Enable();
            Destroy(gameObject);
        }
    }
}
