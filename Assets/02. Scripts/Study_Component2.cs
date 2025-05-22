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

    // Cube : ����Ʈ �̸�, ������ �Է¾����� Cube�� ����
    public void CreateCube(string name = "Cube")
    {
        // ť�� ������Ʈ ���� ���
        obj = new GameObject(name);

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();
    }
}
