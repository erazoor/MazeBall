using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visibilityController : MonoBehaviour
{
    public Transform arena;
    public float threshold = 0.5f;
    
    private GameObject currentTransparentWall;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MakeFacingWallTransparent();
    }
    
    void MakeFacingWallTransparent()
    {
        Vector3 toCamera = (transform.position - arena.position).normalized;

        float maxDot = -Mathf.Infinity;
        Transform facingWall = null;

        foreach (Transform child in arena)
        {
            if (child.CompareTag("Wall"))
            {
                Vector3 toWall = (child.position - arena.position).normalized;
                float dot = Vector3.Dot(toCamera, toWall);

                if (dot > maxDot && dot > threshold)
                {
                    maxDot = dot;
                    facingWall = child;
                }
            }
        }

        if (facingWall != null && facingWall.gameObject != currentTransparentWall)
        {
            // Reset previous transparent wall
            if (currentTransparentWall != null)
            {
                currentTransparentWall.GetComponent<MeshRenderer>().enabled = true;
            }

            // Make the new facing wall transparent
            facingWall.GetComponent<MeshRenderer>().enabled = false;
            currentTransparentWall = facingWall.gameObject;
        }
    }
}
