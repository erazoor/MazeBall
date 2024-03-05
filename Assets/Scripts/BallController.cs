using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    private Vector3 spawnPoint;
    private PlatformController platformController;

    IEnumerator Start()
    {
        spawnPoint = GameObject.Find("SpawnPoint").transform.position;
        platformController = GameObject.Find("Arena").GetComponent<PlatformController>();
        
        yield return null;
        transform.position = spawnPoint + Vector3.up * 3;
    }

    void Update()
    {
        if (transform.position.y < -15)
            Respawn();
    }
    
    public void SetSpawnPoint(Vector3 newSpawnPoint)
    {
        spawnPoint = newSpawnPoint + Vector3.up * 3;
    }

    public void Respawn()
    {
        transform.position = spawnPoint + Vector3.up * 3;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        if (platformController != null)
            platformController.Reset();
    }
}