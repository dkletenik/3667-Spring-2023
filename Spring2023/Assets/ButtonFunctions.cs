using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToInstruction()
    {
        SceneManager.LoadScene("instructionsScene");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("scene1");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("menuScene");
    }
}
