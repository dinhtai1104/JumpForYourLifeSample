using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    
    public void OpenPopup() {
        Time.timeScale = 0;
        gameObject.SetActive(true);
    }

    public void ResumeBtnClicked() {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
    public void HomeBtnClicked() {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
