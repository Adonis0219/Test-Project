using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private IGameManager _gm;
    
    private void Update()
    {
        // _gm에 주입되었는지 확인
        if (_gm != null && Input.anyKey)
        {
            _gm.DebugTest(_gm.testNum);
        }
    }

    public void SetGameManager(IGameManager gm)
    {
        _gm = gm;
    }
}
