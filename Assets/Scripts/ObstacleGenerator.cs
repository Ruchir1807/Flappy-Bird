using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject pipePrefab;   // Prefab of the obstacle (pipe) to be generated
    public int generationRate = 100; // Rate at which obstacles are generated, higher the value slower the obstacles are generated
    private int timer;               // Timer to keep track of generation rate, when it exceeds generationRate, it indicates that it's time to generate a new obstacle.

    // Update is called once per frame
    void FixedUpdate()
    {
        timer++;
        if (timer >= generationRate) 
        {
            timer = 0;
            GameObject newObstacle = Instantiate(pipePrefab, new Vector2(pipePrefab.transform.position.x, pipePrefab.transform.position.y + Random.Range(-2f, 2f)), pipePrefab.transform.rotation);
            Destroy(newObstacle, 5f); //After instantiating the new obstacle, the script destroys it after a certain time (5f seconds in this case). This prevents the scene from being cluttered with inactive obstacles and helps manage memory usage.

        }
    }
}
