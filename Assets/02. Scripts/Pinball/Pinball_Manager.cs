using UnityEngine;

public class Pinball_Manager : MonoBehaviour
{
    public Rigidbody2D leftBarRb;
    public Rigidbody2D rightBarRb;

    public int totalScore = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            leftBarRb.AddTorque(50f);
        else
            leftBarRb.AddTorque(-35f);

        if (Input.GetKey(KeyCode.RightArrow))
            rightBarRb.AddTorque(-50f);
        else
            rightBarRb.AddTorque(35f);
    }
}
