using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour 
{
    private float _moveSpeed;
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
            _moveSpeed = Random.Range(3.5F, 6.25F);
            Debug.Log(_moveSpeed);
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(col.gameObject.transform.position.x + _moveSpeed, col.gameObject.transform.position.y));
		}

    }
}
