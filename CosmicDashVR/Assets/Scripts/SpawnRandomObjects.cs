using UnityEngine;

public class SpawnRandomObjects : MonoBehaviour
{
    public GameObject enemy;
    public Transform spawnArea;
    public int speed = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObjects", 0, speed);
    } 

    public void SpawnObjects()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnArea.localScale.x / 2, spawnArea.localScale.x / 2),
                       Random.Range(-spawnArea.localScale.y / 2, spawnArea.localScale.y / 2),
                                  Random.Range(-spawnArea.localScale.z / 2, spawnArea.localScale.z / 2));

        Instantiate(enemy, spawnArea.position + spawnPosition, Quaternion.identity);
    }

    //Draw a spawn area in the scene view
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(spawnArea.transform.position, spawnArea.localScale);
    }


   
}
