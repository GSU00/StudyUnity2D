using UnityEngine;

public class WirelessEarPhone2 : WirelessEarPhone
{
    //public float batterySize;
    //public bool isWirelessCharged;
    public bool isNoiseCanceling;

    //public void Charged()
    //{
    //    string msg = isWirelessCharged ? "무선 충전" : "유선 충전";
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
        string msg = isNoiseCanceling ? "노이즈 캔슬링 On" : "노이즈 캔슬링 Off";
        Debug.Log(msg);
    }
}
