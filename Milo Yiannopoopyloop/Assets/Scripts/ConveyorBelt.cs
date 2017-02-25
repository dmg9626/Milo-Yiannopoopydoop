using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour 
{
    
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnCollisionStay2D(Collision2D col) 
	{
        if (col.gameObject.name == "Poop")
		{
            col.gameObject.GetComponent<Rigidbody2D>().velocity.Set(-4, 0);
            Debug.Log("collided");
		}

    }

    void OnCollisionExit2D(Collision2D col)
    {
        
    }

}
