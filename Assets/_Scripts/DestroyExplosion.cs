using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Destroy(gameObject,3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
