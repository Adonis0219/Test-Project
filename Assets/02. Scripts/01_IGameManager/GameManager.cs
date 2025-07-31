using System;
using UnityEngine;

public class GameManager : MonoBehaviour, IGameManager
{
    [SerializeField]
    int num = 1;

    public int testNum
    {
        get => num;
        set => num = value;
    }
    
    public void DebugTest(int num)
    {
        Debug.Log($"GM : {num}");
    }
}
