using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_CameraController : MonoBehaviour
{

    public Transform g_PlayerTransform;
    Vector3 g_V3Offset ;

    // Start is called before the first frame update
    void Start()
    {
        g_V3Offset = this.transform.position - g_PlayerTransform.transform.position;
    }

    void LateUpdate()
    {
        m_FollowPlayer() ;
    }

    void m_FollowPlayer()
    {
        this.transform.position = g_V3Offset + g_PlayerTransform.transform.position ;
    }
}
