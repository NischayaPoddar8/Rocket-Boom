using Unity.Mathematics;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject obstaclePrefab;

    void Start()
    {
        InvokeRepeating("SpawnObstacle",1f,2f);
    }

    void SpawnObstacle()
    {
       float yPos =  UnityEngine.Random.Range(-4.44f,3.032f);
       float xPos = 7.4f;
       Vector2 spawnPos = new Vector2(xPos,yPos);
       Instantiate(obstaclePrefab,spawnPos,Quaternion.identity);
    }
}
