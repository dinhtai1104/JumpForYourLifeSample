using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManagement : MonoBehaviour
{
    public static StoreManagement Instance;
    public Image character;
    public DATABASE data;

    public StoreElement prefabs;
    public RectTransform content;

    public void SetCharacter(Sprite character) {
        this.character.sprite = character;
        this.character.SetNativeSize();
    }

    void Awake()
    {
        if (Instance == null) {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        foreach (Character character in data.characters) {
            character.trigger = true;
        }
        Init();
    }

    private void Init() {
        int size = data.characters.Length;
        for (int i = 0; i < size; i++) {
            StoreElement se = Instantiate(prefabs, content);
            se.id = i;
            se.SetData(data.characters[i]);
        }

    }
    public void Open() {
        gameObject.SetActive(true);
    }    
    public void CloseStore() {
        gameObject.SetActive(false);
    }
}
