using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public GameObject winText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball")) 
        {
            winText.SetActive(true);
            Time.timeScale = 0;
			GameController.instance.ShowWinMenu();
			SceneManager.LoadScene("WinHUD");
        }
    }
}