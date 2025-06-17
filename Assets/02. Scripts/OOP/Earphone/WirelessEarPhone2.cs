using UnityEngine;

public class WirelessEarPhone2 : WirelessEarPhone
{
    //public float batterySize;
    //public bool isWirelessCharged;
    public bool isNoiseCanceling;

    //public void Charged()
    //{
    //    string msg = isWirelessCharged ? "���� ����" : "���� ����";
    //    Debug.Log(msg);
    //}

    private void Start()
    {
        name = "AirPod2";
        price = 120f;
        releaseYear = 2013;
        batterySize = 100f;
    }

    public virtual void NoiseCanceling()
    {
        string msg = isNoiseCanceling ? "������ ĵ���� On" : "������ ĵ���� Off";
        Debug.Log(msg);
    }
}
