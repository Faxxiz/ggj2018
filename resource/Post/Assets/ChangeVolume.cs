using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour {
    public Slider volumeSlider;
    public AudioSource volumeAudio;

    public void VolumeController() {
        if (volumeSlider.value == 0)
            volumeAudio.volume = 0;
        else
            volumeAudio.volume = volumeSlider.value + (float)(0.2);
    }
}
