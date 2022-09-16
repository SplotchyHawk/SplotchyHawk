
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject Obstacle;
    private float SpawnTime = 3f;
    public float timeInterval = 1f;
   
    void SpawnBlocks()
    {
        
        int random = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (random != i)
            {
                Instantiate(Obstacle, spawnPoints[i].position, Quaternion.identity);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= SpawnTime)
        {
            SpawnBlocks();
            SpawnTime = Time.time + timeInterval;
        }
    }
}
