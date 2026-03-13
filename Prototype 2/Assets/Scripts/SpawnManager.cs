using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xSpawnRange = 16.0f;
    private float zSpawnPos = 20.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnNewAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void SpawnNewAnimal()
    {
        // Generate a random X position and choose a random animal 
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, zSpawnPos);

        // Instantiate the random animal at the X Position
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
