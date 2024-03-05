using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    private bool isGamePaused = false;
    

    void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else if (instance != this) {
            Destroy(gameObject);
        }
    }
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.P) && SceneManager.GetActiveScene().name != "StartHUD" || SceneManager.GetActiveScene().name != "WinHUD") {
            if (!isGamePaused) {
                ShowPauseMenu();
                isGamePaused = true;
                Time.timeScale = 0;
            } else {
                HidePauseMenu(); 
                isGamePaused = false;
                Time.timeScale = 1;
            }
        }
    }
    
    public void ShowPauseMenu() {
        SceneManager.LoadScene("PauseHUD", LoadSceneMode.Additive);
    }

    public void HidePauseMenu() {
        SceneManager.UnloadSceneAsync("PauseHUD");
    }

    public void GoToStartMenu() {
        SceneManager.LoadScene("StartHUD");
    }
    
    public void ShowWinMenu() {
        SceneManager.LoadScene("WinHUD"); 
        Time.timeScale = 0;
    }
    
    public void RestartGame() {
        Time.timeScale = 1; 
        SceneManager.LoadScene("SampleScene");
    }

    public void StartGame() {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}