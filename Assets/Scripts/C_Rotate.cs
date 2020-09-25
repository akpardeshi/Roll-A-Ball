using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Rotate : MonoBehaviour
{

    Vector3 g_V3Rotation ;

    // Start is called before the first frame update
    void Start()
    {
        g_V3Rotation = new Vector3 ( 15, 30, 45 );
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate( g_V3Rotation * Time.deltaTime );
    }
}
