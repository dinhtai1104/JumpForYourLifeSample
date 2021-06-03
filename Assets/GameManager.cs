using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public Text score;
    public GameOver gameOverUI; 


    private int _score = 0;
    public int SCORE {
        set {
            _score = value;
            score.text = "" + _score;
        }
        get {
            return _score;
        }
    }

    public PauseUI pause;
    public bool isEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }


    public void OpenPause() {
        Time.timeScale = 0;
        pause.OpenPopup();

    }
    public void SetGameOver() {
        isEnd = true;
        gameOverUI.OpenPopup(_score);
    }
    
}
