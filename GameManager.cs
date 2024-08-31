using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject restartLevel;
    public GameObject mainMenu;
    bool gameRun = false;
    public void GameOver() {

        if (gameRun == false) {
            gameRun = true;
            restartLevel.SetActive(true);   
        }    
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            mainMenu.SetActive(true);
        }
    }

}
