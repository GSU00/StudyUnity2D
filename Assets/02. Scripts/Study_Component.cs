using System.Runtime.Serialization;
using UnityEngine;

//����������          Ŭ������ : ����Ƽ�� ������ ����� ����ִ�
public class Study_Component : MonoBehaviour
{
    // public ����Ƽ���� ���� �Ҵ簡��, �ܺο��� ���ٰ���
    // private Ŭ���� ���ο����� ���ٰ���

    // ���������� Ÿ��  ������
    private GameObject obj; // ť�� ���ӿ�����Ʈ�� ��������ʹ�

    public Transform objTf;

    public string changeName;


    void Start()
    {
        // ��� ��ü�� �����Ͽ� �̸�Ȯ��
        // obj = GameObject.Find("Main Camera");

        // �±׸� ���� ��ü���� ����
        // Player��� Tag�� ���� ���ӿ�����Ʈ�� ã�Ƽ� obj�� �Ҵ�
        obj = GameObject.FindGameObjectWithTag("Player");

        objTf = GameObject.FindGameObjectWithTag("Player").transform;
        // GameObject ������ Ÿ��, gameObject ����
        // objTf.gameObject == obj
        objTf.gameObject.SetActive(false);

        obj.name = changeName;

        Debug.Log($"<color=#FFFF00>�̸� : {obj.name}</color>"); // ���ӿ�����Ʈ�� �̸�
        Debug.Log($"�±� : {obj.tag}"); // ���ӿ�����Ʈ�� �±�
        Debug.Log($"��ġ : {obj.transform.position}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ��ġ
        Debug.Log($"ȸ�� : {obj.transform.rotation}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ȸ��
        Debug.Log($"ũ�� : {obj.transform.localScale}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ũ��

        // MeshFilter ������Ʈ�� �����ؼ� mesh�� Log �޼����� ����ϴ� ���
        Debug.Log($"Mesh ������ : {obj.GetComponent<MeshFilter>().mesh}");

        // MeshRenderer ������Ʈ�� �����ؼ� material�� Log �޼����� ����ϴ� ���
        Debug.Log($"Material ������ : {obj.GetComponent<MeshRenderer>().material}");

        // obj�� MeshRenderer�� �����ؼ� Ȱ�����¸� false�� �����ϰڴ�.
        obj.GetComponent<MeshRenderer>().enabled = false;

        // obj�� GameObject Ȱ�����¸� false�� �����ϰڴ�.
        obj.SetActive(false);
    }
}
