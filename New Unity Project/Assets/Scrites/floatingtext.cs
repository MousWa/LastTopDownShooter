using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatingtext : MonoBehaviour
{
    public float DestroyTime = 1f;
    public Vector3 Offset = new Vector3(0, 2, 0);
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyTime);
        transform.localPosition += Offset;
    }


    
}