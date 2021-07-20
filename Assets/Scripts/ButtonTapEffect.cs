using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTapEffect : MonoBehaviour
{
    [SerializeField] public AudioSource Tap;

    public void TapAudio()
    {
        Tap.Play();
    }
}
