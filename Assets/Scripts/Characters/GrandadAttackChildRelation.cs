using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandadAttackChildRelation : MonoBehaviour
{
    public void Disable()
    {
        transform.parent.GetComponent<GrandadAttackController>().Disable();
    }

    public void GenerateBall()
    {
        transform.parent.GetComponent<GrandadAttackController>().GenerateBall();
    }
}
