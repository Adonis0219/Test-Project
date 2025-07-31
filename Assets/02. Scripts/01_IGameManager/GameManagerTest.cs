using UnityEngine;

public class GameManagerTest : IGameManager
{
    [SerializeField] 
    private int num = 10;
    
    public int testNum
    {
        get => num;
        set => num = value;
    }
    
    public void DebugTest(int num)
    {
        Debug.Log("테스트 실행");
        Debug.Log($"GMT : {num}");
    }
}
