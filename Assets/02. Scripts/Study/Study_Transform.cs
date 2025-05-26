using UnityEngine;

public class Study_Transform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    void Update()
    {
        // ���� �������� �̵��ϴ� ���
        // transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        // transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);

        // ���� ����(ĳ���Ͱ� �ٶ󺸴� ����)���� �̵��ϴ� ���
        // transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // ���� �������� ȸ��
        //transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, 0);
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        // ���� �������� ȸ��
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self ����

        // Ư�� ��ġ�� �ֺ��� ȸ��
        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
        
        // Ư����ġ�� �ٶ󺸸�
        transform.LookAt(Vector3.zero); // ���.transform.position
    }
}
