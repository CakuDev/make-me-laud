using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderBehaviour : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;

    private void Start()
    {
        volumeSlider.value = AudioListener.volume;
    }

    public void ChangeVolume(float volume)
    {
        Debug.Log("New volume: " +  volume);
        AudioListener.volume = volume;
    }
}
