using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAllChildren : MonoBehaviour
{
    public GameObject parentGameObj;

    public void DisableChildren()
    {
        // for every child on game obj
        for (int i = 0; i < parentGameObj.transform.childCount; i++)
        {
            var child = parentGameObj.transform.GetChild(i).gameObject;
            
            // if child exists
            if(child != null)
            {
                // disable
                child.SetActive(false);
            }
        }
    }
}
