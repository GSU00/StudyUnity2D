using UnityEngine;

public class Study_Component : MonoBehaviour
{
    // public 유니티에서 직접 할당가능
    private GameObject obj; // 큐브 게임오브젝트를 가져오고싶다

    public string changeName;






    void Start()
    {
        obj = GameObject.Find("Main Camera");
        
        obj.name = changeName;
    }
}
