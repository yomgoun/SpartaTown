using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CharacterType
{
    lizard,
    pumpkin
}

[System.Serializable]

public class Charater
{
    public CharacterType CharacterType;
    public Sprite CharacterSprite;
    public RuntimeAnimatorController AnimatorController;
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<Charater> CharaterList = new List<Charater>();

    public Animator PalyerAnimator;
    public Text PlayerName;

    public void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
}
