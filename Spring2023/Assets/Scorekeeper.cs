using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scorekeeper : MonoBehaviour
{
    [SerializeField] int score = 0;
    const int DEFAULT_POINTS = 1;
    [SerializeField] Text scoreTxt;
    [SerializeField] Text sceneTxt;
    int level;
    const int SCORE_THRESHOLD = 10;

    // Start is called before the first frame update
    void Start()
    {
        DisplayScore();
        level = SceneManager.GetActiveScene().buildIndex + 1; //becuase build indexing starts at 0 and we start right awy with scene1
        DisplayScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoints()
    {
        AddPoints(DEFAULT_POINTS);
    }

    public void AddPoints(int points)
    {
        score += points;
        Debug.Log("score: " + score);
        DisplayScore();

        if (score >= SCORE_THRESHOLD)
            AdvanceScene();
    }

    public void DisplayScore()
    {
        scoreTxt.text = "Score: " + score;
    }

    public void DisplayScene()
    {
        sceneTxt.text = "Level " + level;
    }

    public void AdvanceScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
