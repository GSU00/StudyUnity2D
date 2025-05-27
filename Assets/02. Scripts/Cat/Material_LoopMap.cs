using UnityEngine;

public class Material_LoopMap : MonoBehaviour
{
    MeshRenderer renderer;

    public float offsetSpeed = 0.1f;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        // 변경된 offset 값
        Vector2 offset = Vector2.right * offsetSpeed * Time.deltaTime;

        // Texture의 Offset을 적용하겠다
        renderer.material.SetTextureOffset("_MainTex", renderer.material.mainTextureOffset + offset);
    }
}
