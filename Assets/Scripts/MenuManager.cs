using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private AudioSource BackAudio;
    [SerializeField] private AudioSource DeathAudio;
    [SerializeField] private GameObject GameOverCanvas;

    void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;

        BackAudio.Pause();
        DeathAudio.Play();
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
