using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCake : ICake
{
    float m_Taste = 5.0f;
    string prefabPath = "Cake";
    public GameObject model; // instantiated prefab

    public float GetTaste()
    {
        return m_Taste;
    }

    public GameObject GetGameObject()
    {
        return model;
    }

    public BasicCake()
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(model);
    }

    public BasicCake(Vector3 worldPos)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab, worldPos, prefab.transform.rotation);
    }
}
