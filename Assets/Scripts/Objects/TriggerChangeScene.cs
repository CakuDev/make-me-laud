using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChangeScene : MonoBehaviour
{
    [SerializeField] private ChangeSceneBehaviour changeSceneBehaviour;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Main Character")) changeSceneBehaviour.ChangeScene();
    }
}
