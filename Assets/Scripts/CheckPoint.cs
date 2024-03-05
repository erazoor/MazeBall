using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            BallController ballController = other.GetComponent<BallController>();
            if (ballController != null)
                ballController.SetSpawnPoint(transform.position);
        }
    }
}