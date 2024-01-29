using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellRangeController : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out SpellBehaviour spellBehaviour)) spellBehaviour.Disappear();
    }
}
