using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
   
    // Find Any objects tagged 'music' and create array
    // if the that is not the object, destroy it, else, dont destroy
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject); //upon changing scenes, cancels the object from being destroyed
    }
}
