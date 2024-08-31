using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resume : MonoBehaviour
{
    public GameObject mainMenu;
    public void ButtonPressed()
    {
        mainMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ExitPressed() {
        Application.Quit();
    }
}
