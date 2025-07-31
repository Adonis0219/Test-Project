using System;
using System.Linq.Expressions;
using UnityEngine;

public enum UnityState { Game, Test }

public class TestChanger : MonoBehaviour
{
    [SerializeField] public UnityState state;

    public Action<UnityState> onStateChange;

    // 에디터에서 상태를 변경했을 때 바로 적용되게 하려면
    private void OnValidate()
    {
        if (Application.isPlaying)
        {
            Debug.Log("state 변경됨!");

            onStateChange?.Invoke(state);
        }
    }
}