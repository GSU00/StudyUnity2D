using UnityEngine;

public class Study_Material : MonoBehaviour
{
    public Material mat;

    public string hexCode;

    void Start()
    {
        // this.GetComponent<Material>() = mat; // Material�� �ٲٴ� ���X

        // this.GetComponent<MeshRenderer>().material = mat; // MeshRenderer�� �����ؼ� �ٲٴ� ���

        // this.GetComponent<MeshRenderer>().sharedMaterial = mat; // MeshRenderer�� �����ؼ� �ٲٴ� ���

        // this.GetComponent<MeshRenderer>().material.color = Color.green;

        // this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.gray; //����

        // this.GetComponent<MeshRenderer>().sharedMaterial.color = new Color(130f / 255f, 20f / 255f, 70 / 255f, 1);

        mat = this.GetComponent<MeshRenderer>().material;
        Color outputColor;

        if (ColorUtility.TryParseHtmlString(hexCode, out outputColor))
        {
            mat.color = outputColor;
        }
    }
}
