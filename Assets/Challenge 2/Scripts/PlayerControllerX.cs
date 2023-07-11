using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    float lastSpawn;
    float spawnCooldown = 1.0f;
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        lastSpawn += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& lastSpawn>=spawnCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastSpawn = 0;
        }
    }
}
