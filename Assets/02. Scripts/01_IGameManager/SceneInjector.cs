using System;
using UnityEngine;

public class SceneInjector : MonoBehaviour
{
    [SerializeField]
    private GameManager gm;
    
    [SerializeField]
    private Player player;
    
    [SerializeField]
    TestChanger tChanger;

    private void Awake()
    {
        InjectDependencies();
        tChanger.onStateChange += (state) => InjectDependencies();
    }

    /// <summary>
    /// ������ ���� �Լ�
    /// </summary>
    void InjectDependencies()
    {
        IGameManager managerToInject;

        if (tChanger.state == UnityState.Game)
        {
            managerToInject = gm;
        }
        else
        {
            managerToInject = new GameManagerTest();
        }
        
        player.SetGameManager(managerToInject);
    }
}
