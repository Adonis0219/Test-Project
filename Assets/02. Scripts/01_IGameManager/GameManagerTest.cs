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
        Debug.Log("�׽�Ʈ ����");
        Debug.Log($"GMT : {num}");
    }
}
