using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour 
{
    private float _moveSpeed = .2F;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	
	void Update () 
	{
        
	}

	void OnCollisionStay2D(Collision2D col) 
	{
        if (col.gameObject.name == "Poop")
		{
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(col.gameObject.transform.position.x + _moveSpeed, col.gameObject.transform.position.y));
            Debug.Log("shitfuck");
		}

    }

    void OnCollisionExit2D(Collision2D col)
    {
        
    }

}
