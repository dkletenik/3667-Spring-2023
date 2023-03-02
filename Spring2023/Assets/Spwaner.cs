using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaner : MonoBehaviour
{
    const int NUM_COINS = 10;
    [SerializeField] GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
        
    }

    void Spawn()
    {
        int xMin = -14;
        int xMax = 16;
        int yMin = 0;
        int yMax = 4;

        for (int i = 0; i < NUM_COINS; i++)
        {
            Vector2 position = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
            Instantiate(coin, position, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
