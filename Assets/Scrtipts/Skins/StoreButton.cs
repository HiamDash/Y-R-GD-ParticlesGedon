using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreButton : MonoBehaviour
{

    public GameObject SkinStore;

    public void ActiveSkinStore()
    {
        SkinStore.SetActive(true);
    }
    public void DisactiveSkinStore()
    {
        SkinStore.SetActive(false);        
    }
    
}
