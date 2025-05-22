using UnityEngine;

public class Study_Component2 : MonoBehaviour
{
    public GameObject obj;

    public Mesh msh;
    public Material mat;

    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        
        CreateCube();
        CreateCube("Hello World");
    }

    // Cube : 디폴트 이름, 별도의 입력없으면 Cube로 생성
    public void CreateCube(string name = "Cube")
    {
        // 큐브 오브젝트 생성 기능
        obj = new GameObject(name);

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();
    }
}
