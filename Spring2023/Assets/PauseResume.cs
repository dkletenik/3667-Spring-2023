using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseResume : MonoBehaviour
{

    GameObject[] pauseMode;
    GameObject[] playMode;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;


        pauseMode = GameObject.FindGameObjectsWithTag("ShowInPauseMode");
        playMode = GameObject.FindGameObjectsWithTag("ShowInPlayMode");

        foreach (GameObject g in pauseMode)
            g.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMenu ()
    {
        SceneManager.LoadScene("menuScene");
    }

    public void Pause()
    {
        Time.timeScale = 0.0f;

        foreach(GameObject g in pauseMode)
            g.SetActive(true);

        foreach(GameObject g in playMode)
            g.SetActive(false);
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;

        foreach (GameObject g in pauseMode)
            g.SetActive(false);

        foreach (GameObject g in playMode)
            g.SetActive(true);
    }
}
