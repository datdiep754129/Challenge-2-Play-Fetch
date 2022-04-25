using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public double delayTime = 1000d;

    private Stopwatch stopWatch;

    private void Start()
    {
        stopWatch = new Stopwatch();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (stopWatch.IsRunning)
            {
                if (stopWatch.Elapsed.TotalMilliseconds > delayTime)
                {
                    stopWatch.Reset();
                    SpawnDog();
                }
            }
            else
            {
                SpawnDog();
            }
        }
    }

    private void SpawnDog()
    {
        stopWatch.Start();
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
