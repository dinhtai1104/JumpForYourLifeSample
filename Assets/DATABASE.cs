using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DATA", menuName = "CREATE/DATA", order = 1)]
public class DATABASE : ScriptableObject
{
    public Character[] characters;
}

[System.Serializable]
public class Character {
    public Sprite avatar;
    public Sprite charater;
    public bool trigger = false;
    public int cost;
}

/*
    1 character = 1 CharateImage + 1 Avatar + 1 trigger(Da mua hay chua (bool)) + Cost 
*/