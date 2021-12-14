using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideWaysF = 500f;
    // Start is called before the first frame update
  
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sideWaysF* Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysF* Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    
    void OnCollisionEnter(UnityEngine.Collision colInfo)
    {
        if(colInfo.gameObject.tag == "Obstacle")
        {
            Debug.Log("We Hit an obstacle");
            forwardForce = 0f;
            sideWaysF = 0f;

            FindObjectOfType<GameManager>().EndGame();
        }
       
    }
   
}
