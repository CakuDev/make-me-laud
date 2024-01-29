using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroCanvasBehaviour : MonoBehaviour
{
    [SerializeField] private Animator image1;
    [SerializeField] private Animator image2;
    [SerializeField] private Animator text1;
    [SerializeField] private Animator text2;
    [SerializeField] private Animator text3;
    [SerializeField] private ChangeSceneBehaviour changeSceneBehaviour;
    
    void Start()
    {
        StartCoroutine(IntroAnimation());
    }

    IEnumerator IntroAnimation()
    {
        yield return new WaitForSeconds(1.5f);
        
        text1.gameObject.SetActive(true);
        yield return new WaitForSeconds(4f);

        text1.Play("Despawn");
        yield return new WaitForSeconds(1.5f);

        image1.gameObject.SetActive(false);

        image2.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);

        text2.gameObject.SetActive(true);
        yield return new WaitForSeconds(4f);

        text2.Play("Despawn");
        yield return new WaitForSeconds(1.5f);

        text3.gameObject.SetActive(true);
        yield return new WaitForSeconds(8f);

        text3.Play("Despawn");
        yield return new WaitForSeconds(1.5f);

        changeSceneBehaviour.ChangeScene();
    }
}
