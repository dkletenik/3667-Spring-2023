using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        [SerializeField] int lives = 3;
        [SerializeField] Text livesText;

        public void Start()
        {
            DisplayLives();
        }

        private void OnCollisionEnter2D (Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                lives--;
                Debug.Log("collided with player");
                DisplayLives();

                if (lives == 0)
                    SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
            }

        }

        private void DisplayLives()
        {
            livesText.text = "Lives: " + lives;
        }
    }
}
