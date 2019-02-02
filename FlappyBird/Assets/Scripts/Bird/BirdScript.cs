using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public static BirdScript instance;

    [SerializeField]
    private Rigidbody2D myRigidbody2D;

    [SerializeField]
    private Animator anim;

    private float forwardSpeed = 3f;
    private float bounceSpeed = 4f;

    private bool didFlap;
    private bool isAlive;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        isAlive = true;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        // Update is called every frame
        //fixedUpdate is called every 2 -3 frames
	    if (isAlive)
	    {
	        Vector3 temp = transform.position;
	        temp.x += forwardSpeed * Time.deltaTime;
	        transform.position = temp;

	        if (didFlap)
	        {
	            didFlap = false;
                myRigidbody2D.velocity = new Vector2(0, bounceSpeed);
                anim.SetTrigger("Flap");
	        }
	        
	    }
		
	}

    public void FlapTheBird()
    {
        didFlap = true;
    }
}
