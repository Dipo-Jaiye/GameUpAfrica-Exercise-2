using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float currentTime = 0; // Starting time
    private float delayTime = 1.2f; // Minimum time before new dog can be sent

    // Update is called once per frame
    void FixedUpdate()
    {

        // After delay, on spacebar press, send dog
        if (Time.fixedTime > (currentTime + delayTime) && Input.GetKeyDown(KeyCode.Space))
        {
            // Send new dog
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            // Update the current time
            currentTime = Time.fixedTime;
        }
    }
}
