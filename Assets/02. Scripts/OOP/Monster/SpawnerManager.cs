using System.Collections;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField] private GameObject[] monsters; // ���� ������ �̹� ������ ����

    [SerializeField] private GameObject[] items;

    // n�ʸ��� ���͸� �������� �����ϴ� ���

    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            // ���͸� �����ϴ±��

            var randomIndex = Random.Range(0, monsters.Length);
            var randomX = Random.Range(-7f, 7f);
            var randomY = Random.Range(-3, 4.5f);

            var createPos = new Vector3 (randomX, randomY, 0);

            Instantiate(monsters[randomIndex], createPos, Quaternion.identity); // ���� ����
        }
    }

    public void DropCoin(Vector3 dropPos)
    {
        var randomIndex = Random.Range(0, items.Length);

        GameObject item = Instantiate(items[randomIndex], dropPos, Quaternion.identity);

        Rigidbody2D itemRb = item.GetComponent<Rigidbody2D>();

        // �¿�� ���ư��� ��
        itemRb.AddForceX(Random.Range(-2, 2), ForceMode2D.Impulse);
        // ���� ������ ��
        itemRb.AddForceY(3f, ForceMode2D.Impulse);

        // ȸ����
        itemRb.AddTorque(Random.Range(-5f, 5f), ForceMode2D.Impulse);
    }
}
