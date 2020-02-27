using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicRifle : IRifle
{
    private float m_BasicAccuracy = 5.0f;

    public float GetAccuracy()
    {
        return m_BasicAccuracy;
    }
}
