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

    public Animator PlayerAnimator;
    public Text PlayerName;

    public void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void SetChracter(CharacterType characterType,string name)
    {
        var character = GameManager.Instance.CharaterList.Find(item => item.CharacterType == characterType);

        PlayerAnimator.runtimeAnimatorController = character.AnimatorController;
        PlayerName.text = name;
    }
}
