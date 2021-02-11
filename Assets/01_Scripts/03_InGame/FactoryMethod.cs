using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FactoryMethod : MonoBehaviour
{
    protected GameObject CreateObject(GameObject originalObject, Transform parent)
    {
        return Instantiate(originalObject, parent);
    }
}
