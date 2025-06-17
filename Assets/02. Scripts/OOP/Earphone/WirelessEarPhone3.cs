using UnityEngine;

public class WirelessEarPhone3 : WirelessEarPhone2
{
    public enum NoiseCancelingType { On, Off, Around }
    public NoiseCancelingType noiseCancelingType;

    public void SetNoiseCancelingType(NoiseCancelingType type)
    {
        noiseCancelingType = type;
    }

    public override void NoiseCanceling()
    {
        SetNoiseCancelingType(noiseCancelingType);

        base.NoiseCanceling();
    }
}
