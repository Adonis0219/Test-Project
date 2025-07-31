using System;
using System.Linq.Expressions;
using UnityEngine;

public enum UnityState { Game, Test }

public class TestChanger : MonoBehaviour
{
    [SerializeField] public UnityState state;

    public Action<UnityState> onStateChange;

    // �����Ϳ��� ���¸� �������� �� �ٷ� ����ǰ� �Ϸ���
    private void OnValidate()
    {
        if (Application.isPlaying)
        {
            Debug.Log("state �����!");

            onStateChange?.Invoke(state);
        }
    }
}