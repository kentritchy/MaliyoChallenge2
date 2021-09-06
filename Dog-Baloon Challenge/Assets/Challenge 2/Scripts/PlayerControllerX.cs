using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float timeAllowable = 0.6f;
    private float nextSpawn;

    
    
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKey(KeyCode.Space) && Time.time > nextSpawn)
        {
            nextSpawn = Time.time + timeAllowable;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
