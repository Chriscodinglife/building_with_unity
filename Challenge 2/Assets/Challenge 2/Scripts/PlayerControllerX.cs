using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 0.0f;
    private float spawnWaitTime = 2.0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer > spawnWaitTime)
        {
            timer = timer - spawnWaitTime;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
