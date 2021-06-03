using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text ScoreText;
    

    public void OpenPopup(int score) {
        ScoreText.text = "" + score;
        gameObject.SetActive(true);
    }

    public void HomeBtnClicked() {
        SceneManager.LoadScene("Menu");
    }

    public void ReplayBtnClicked() {
        SceneManager.LoadScene("Play");
    }
}
