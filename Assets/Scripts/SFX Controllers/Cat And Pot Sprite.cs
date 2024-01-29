using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAndPotSprite : MonoBehaviour
{
    [SerializeField] private AudioSource screamingCat;
    [SerializeField] private AudioSource brokenPot;
    [SerializeField] private AudioSource laugh;
    [SerializeField] private AudioSource dizzySound;

    public void PlayScreamingCat()
    {
        screamingCat.Play();
    }

    public void PlayBrokenPot()
    {
        brokenPot.Play();
    }

    public void PlayLaugh()
    {
        laugh.Play();
    }

    public void PlayDizzySound()
    {
        dizzySound.Play();
    }
}
