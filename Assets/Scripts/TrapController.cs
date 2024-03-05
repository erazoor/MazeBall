using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            BallController ballController = other.gameObject.GetComponent<BallController>();
            if (ballController != null)
            {
                ballController.Respawn();
                if (DeathCounter.instance != null)
                    DeathCounter.instance.IncrementDeathCount();
            }
        }
    }
}
