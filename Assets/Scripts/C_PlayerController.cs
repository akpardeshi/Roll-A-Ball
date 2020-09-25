using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro ;

public class C_PlayerController : MonoBehaviour
{
    public float g_FloatSpeed ;
    Rigidbody g_RigidBody ;
    Vector3 g_Movement;
    int g_IntCount ;
    public  TextMeshProUGUI g_CountText ;
    public GameObject g_WinnerText ;
    public int g_IntCubeCount ;

    // Start is called before the first frame update
    void Start()
    {
        g_RigidBody = this.GetComponent<Rigidbody>();
        g_Movement = Vector3.zero;
        g_FloatSpeed = 10.0f ;
        g_IntCubeCount = 8 ;
        g_WinnerText.SetActive( false );
        m_SetCountText ();
    }

    void OnMove( InputValue l_MovementValue )
    {
        Vector2 l_MovementVactor = l_MovementValue.Get<Vector2>();

        g_Movement.x = l_MovementVactor.x ;
        g_Movement.z = l_MovementVactor.y ;     
    }

    void FixedUpdate()
    {
        g_RigidBody.AddForce( g_Movement * g_FloatSpeed );
    }

    void OnTriggerEnter( Collider other )
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            g_IntCount ++ ;
            m_SetCountText ();
            m_DisplayWinner();
        }
    }

    void m_SetCountText ()
    {
        g_CountText.text = "Count : " + g_IntCount.ToString();
    }

    void m_DisplayWinner()
    {
        if ( g_IntCount == g_IntCubeCount )
        {
            // Display winner 
            g_WinnerText.SetActive(true);
        }
    }
}
