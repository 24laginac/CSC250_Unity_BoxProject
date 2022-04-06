using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    private Player thePlayer;
    public float speed = 20f;
    private Rigidbody rb;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = new Player("Carson");
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    public void DoSomething()
    {
        print("Do something called");
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("enemy"))
        {
            count++;
            if(count == 3)
            {
                this.thePlayer.addKill();
                print("Kill count: " + this.thePlayer.getKillCOunt());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("up"))
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKeyDown("down"))
        {
            rb.velocity = Vector3.back * speed;
        }
        else if (Input.GetKeyDown("left"))
        {
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKeyDown("right"))
        {
            rb.velocity = Vector3.right * speed;
        }
        else if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector3.up * speed;
        }
    }
}
