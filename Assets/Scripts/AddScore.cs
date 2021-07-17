using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        ScoreManager._scoreCounter += 1;

        ScoreManager.HighScore();
    }
}
