using System.Collections;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField] private GameObject[] monsters; // 몬스터 종류가 이미 정해진 상태

    [SerializeField] private GameObject[] items;

    // n초마다 몬스터를 랜덤으로 생성하는 기능

    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            // 몬스터를 스폰하는기능

            var randomIndex = Random.Range(0, monsters.Length);
            var randomX = Random.Range(-7f, 7f);
            var randomY = Random.Range(-3, 4.5f);

            var createPos = new Vector3 (randomX, randomY, 0);

            Instantiate(monsters[randomIndex], createPos, Quaternion.identity); // 몬스터 생성
        }
    }

    public void DropCoin(Vector3 dropPos)
    {
        var randomIndex = Random.Range(0, items.Length);

        GameObject item = Instantiate(items[randomIndex], dropPos, Quaternion.identity);

        Rigidbody2D itemRb = item.GetComponent<Rigidbody2D>();

        // 좌우로 날아가는 힘
        itemRb.AddForceX(Random.Range(-2, 2), ForceMode2D.Impulse);
        // 위로 날리는 힘
        itemRb.AddForceY(3f, ForceMode2D.Impulse);

        // 회전력
        itemRb.AddTorque(Random.Range(-5f, 5f), ForceMode2D.Impulse);
    }
}
