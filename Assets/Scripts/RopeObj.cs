using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeObj : MonoBehaviour, IActivateable
{
    public void Activate()
    {
        Destroy(gameObject);
    }
}
