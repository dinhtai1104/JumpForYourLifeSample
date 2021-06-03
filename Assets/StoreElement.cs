using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreElement : MonoBehaviour
{
    public int id = 0;
    public Image avatar;
    private Character character;

    void Start()
    {
        
    }

    public void SetData(Character character)
    {
        this.character = character;
        // avatar.sprite = avatarSprite;
        // avatar.SetNativeSize();
        avatar.sprite = character.avatar;
        avatar.SetNativeSize();

        if (!character.trigger) {
            avatar.color = Color.gray;
        } else {
            avatar.color = Color.white;
        }
    }

    public void AvatarOnClicked() {
        //
        // Change character image 
        StoreManagement.Instance.SetCharacter(character.charater);
        if (character.trigger) {
            PlayerPrefs.SetInt("Data", id);
        }
    }
}
