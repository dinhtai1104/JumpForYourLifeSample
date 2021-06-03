using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{

    public StoreManagement store;

    void Start()
    {
    }
    
    public void PlayBtnClicked() {
        SceneManager.LoadScene("Play");
    }

    public void SettingsBtnClicked() {
        Debug.Log("Settings Clicked");
    }

    public void NoAdsBtnClicked() {
        Debug.Log("NoAds Clicked");
    }

    public void StoreBtnClicked() {
        Debug.Log("Store Clicked");
        store.Open();
    }
}
