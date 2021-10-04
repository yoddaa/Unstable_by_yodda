using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Removing : MonoBehaviour
{
    public float seconds = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("RemovingIt", seconds);
    }

    void RemovingIt()
    {
        Destroy(gameObject);

    }

}
