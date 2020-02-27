using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class RifleDecorator : IRifle
{
    protected IRifle m_DecoratedRifle;

    // constructor
    public RifleDecorator(IRifle rifle)
    {
        m_DecoratedRifle = rifle;
    }

    // can be overridden by children
    public virtual float GetAccuracy()
    {
        return m_DecoratedRifle.GetAccuracy();
    }
}

public class WithScope : RifleDecorator
{
    private float m_ScopeAccuracy = 20.0f;

    // constructor
    public WithScope(IRifle rifle) : base(rifle) { }

    // child will override parent
    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_ScopeAccuracy;
    }
}

public class WithStabilizer : RifleDecorator
{
    private float m_StabilizerAccuracy = 20.0f;

    // constructor
    public WithStabilizer(IRifle rifle) : base(rifle) { }

    // child will override parent
    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_StabilizerAccuracy;
    }
}
