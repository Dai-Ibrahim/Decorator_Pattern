using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class CakeDecorator : ICake
{
    protected ICake m_DecoratedCake;

    public CakeDecorator(ICake Cake)
    {
        m_DecoratedCake = Cake;
    }

    public virtual float GetTaste()
    {
        return m_DecoratedCake.GetTaste();
    }

    public virtual GameObject GetGameObject()
    {
        return m_DecoratedCake.GetGameObject();
    }
}

public class WithCream : CakeDecorator
{
    float m_CreamTaste = 20.0f;
    string prefabPath = "Cream";
    GameObject model; // instantiated prefab

    public WithCream(ICake Cake) : base(Cake)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetTaste()
    {
        return base.GetTaste() + m_CreamTaste;
    }
}
public class WithTopper : CakeDecorator
{
    float m_TopperTaste = 20.0f;
    string prefabPath = "Topper";
    GameObject model; // instantiated prefab

    public WithTopper(ICake Cake) : base(Cake)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetTaste()
    {
        return base.GetTaste() + m_TopperTaste;
    }
}
public class WithCandle : CakeDecorator
{
    float m_CandleTaste = 20.0f;
    string prefabPath = "Candle";
    GameObject model; // instantiated prefab

    public WithCandle(ICake Cake) : base(Cake)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetTaste()
    {
        return base.GetTaste() + m_CandleTaste;
    }
}
public class WithTier : CakeDecorator
{
    float m_TierTaste = 10.0f;
    string prefabPath = "NewTier";
    GameObject model; // instantiated prefab

    public WithTier(ICake Cake) : base(Cake)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetTaste()
    {
        return base.GetTaste() + m_TierTaste;
    }
}
