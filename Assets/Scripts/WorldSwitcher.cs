using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSwitcher : MonoBehaviour
{
    public static WorldSwitcher instance;
    public GameObject world1, world2;
    
    void Awake(){
        WorldSwitcher.instance = this;
    }
    
    void Start(){
        world1.SetActive(true);
        world2.SetActive(false);
    }
    
    public void SwitchWorlds(){
        world1.SetActive(!world1.activeInHierarchy);
        world2.SetActive(!world2.activeInHierarchy);
    }
}