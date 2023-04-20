using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scorekeeper : MonoBehaviour
{
    [SerializeField] int score;
    const int DEFAULT_POINTS = 1;
    [SerializeField] Text scoreTxt;
    [SerializeField] Text sceneTxt;
    int level;
    const int SCORE_THRESHOLD_PER_LEVEL = 10;
    int scoreThreshold;

    // Start is called before the first frame update
    void Start()
    {
        score = PersistentData.Instance.GetScore();
        DisplayScore();
        level = SceneManager.GetActiveScene().buildIndex - 1; //becuase build indexing starts at 0 and we start right awy with scene1
        scoreThreshold = level * SCORE_THRESHOLD_PER_LEVEL;
        DisplayScene();
    }

    // Update is called once per frame
    void Update()
    {
        score = PersistentData.Instance.GetScore();
        if (score >= scoreThreshold)
            AdvanceScene();
    }

    public void AddPoints()
    {
        AddPoints(DEFAULT_POINTS);
    }

    public void AddPoints(int points)
    {
        score += points;
        PersistentData.Instance.SetScore(score);
        Debug.Log("score: " + score);
        DisplayScore();

        if (score >= scoreThreshold)
            AdvanceScene();
    }

    public void DisplayScore()
    {
        scoreTxt.text = "Score: " + score;
    }

    public void DisplayScene()
    {
        sceneTxt.text = "Welcome, " + PersistentData.Instance.GetName() + " : Level " + level;
    }

    public void AdvanceScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
