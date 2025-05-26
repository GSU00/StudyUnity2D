using UnityEngine;

public class Study_UnityEvent : MonoBehaviour
{
    void Awake() // ���� ���� 1���� ����
    {
        Debug.Log("Awake");
    }

    void Start() // 1���� ����
    {
        Debug.Log("Start");
    }

    void OnEnable() // GameObject�� Active ���°� On �� ������ ����
    {
        Debug.Log("OnEnable");
    }

    void OnDisable() // GameObject�� Active ���°� Off �� ������ ����
    {
        Debug.Log("DisnEnable");
    }

    void Update()
    {

    }
}
