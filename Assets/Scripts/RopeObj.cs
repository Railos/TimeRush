using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;

public class RopeObj : MonoBehaviour, IActivateable
{
    [SerializeField] private ConfigurableJoint CJ;
    public void Activate()
    {
        Destroy(CJ);
        Destroy(transform.parent.gameObject,.1f);
    }
}
