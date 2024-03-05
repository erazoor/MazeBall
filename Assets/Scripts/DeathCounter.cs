using UnityEngine;
using UnityEngine.UI; 
using TMPro; 

public class DeathCounter : MonoBehaviour
{
    public static DeathCounter instance; 
    public TMP_Text deathText; 
    private int deathCount = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    public void IncrementDeathCount()
    {
        deathCount++;
        deathText.text = "Deaths: " + deathCount;
    }
}