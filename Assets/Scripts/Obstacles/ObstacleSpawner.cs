using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float minSponX, maxSponX;
    
    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1f, 2f);
    }

    void SpawnObstacle()
    {
        float xPosition = Random.Range(minSponX, maxSponX);
        Instantiate(obstaclePrefab, new Vector3(xPosition, 5f, 0), Quaternion.identity);
    }
}
