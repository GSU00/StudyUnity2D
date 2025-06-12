using UnityEngine;

public class ItemEvent : MonoBehaviour
{
    public enum ColliderType { Pipe, Apple, Both };
    public ColliderType colliderType;

    public GameObject pipe;
    public GameObject apple;
    public GameObject particle;

    public float moveSpeed = 3f;
    public float returnPosX = 15f;
    public float randomPosY;

    private Vector3 initPos;

    private void Awake()
    {
        initPos = transform.localPosition;
    }

    private void OnEnable()
    {
        SetRandomPos(initPos.x);
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= -returnPosX)
        {
            SetRandomPos(returnPosX);
        }
    }

    private void SetRandomPos(float posX)
    {
        randomPosY = Random.Range(-8f, -4.5f);
        transform.position = new Vector3(posX, randomPosY, 7);

        // int 타입을 enum 타입으로 변경, 형변환(Type Casting)
        colliderType = (ColliderType)Random.Range(0, 3);

        pipe.SetActive(false);
        apple.SetActive(false);
        this.GetComponent<BoxCollider2D>().enabled = false;

        switch (colliderType)
        {
            case ColliderType.Pipe:
                pipe.SetActive(true);
                this.GetComponent<BoxCollider2D>().enabled = true;
                break;
            case ColliderType.Apple:
                apple.SetActive(true);
                break;
            case ColliderType.Both:
                pipe.SetActive(true);
                apple.SetActive(true);
                this.GetComponent<BoxCollider2D>().enabled = true;
                break;
        }

    }
}
