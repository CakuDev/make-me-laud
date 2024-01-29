using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellInteractionRespawnBehaviour : SpellInteractionBehaviour
{
    [HideInInspector] public RespawnController respawnController;

    public override void Interact()
    {
        base.Interact();
        respawnController.canRespawn = false;
    }

    public void RespawnWhenDestroy()
    {
        respawnController.Respawn();
    }
}
