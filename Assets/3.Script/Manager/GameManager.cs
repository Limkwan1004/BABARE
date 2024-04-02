using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct GameData
{
    int flowerCount;
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = new GameManager();


    private void Awake()
    {
        if (Instance != null)
        {
            DontDestroyOnLoad(Instance);
            Instance = this;
        }
        else
        {
            return;
        }
    }
}
