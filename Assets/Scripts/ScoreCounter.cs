using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public static int _score;

    private void Start()
    {
        _score = 0;
    }

    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = _score.ToString(); 
    }

}
