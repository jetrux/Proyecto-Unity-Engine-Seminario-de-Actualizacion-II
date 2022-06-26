using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float fuerza;
    public float fuerzaLateral;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, fuerza * Time.deltaTime);
        
        if(Input.GetKey("a"))
        {
            rb.AddForce(-fuerzaLateral * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(fuerzaLateral * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(transform.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
