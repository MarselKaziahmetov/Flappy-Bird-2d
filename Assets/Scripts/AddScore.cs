using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public AudioSource _ScoreSound;
    public static int _localScore = 0;

    private void OnTriggerExit2D(Collider2D collision)
    {
        ScoreManager._scoreCounter += 1;
        _localScore += 1;

        ScoreManager.HighScore();

        _ScoreSound.Play();
    }
}
