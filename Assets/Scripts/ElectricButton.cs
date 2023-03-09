using UnityEngine;
using UnityEngine.Events;

public class ElectricButton : MonoBehaviour, IActivateable
{
    public UnityEvent OnUse;
    
    public void Activate()
    {
        OnUse.Invoke();
    }
}
