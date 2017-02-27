using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour 
{
    private float _bouncePower;
	// Use this for initialization
	void Start () 
    {
        _bouncePower = 15;
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Poop")
        {
            Collider2D collider = collision.collider;
            Vector2 contactPoint = collision.contacts[0].point;
            Vector2 center = collider.bounds.center;
            if (contactPoint.y < center.y)
                Bounce(collision.gameObject);
        }
        
    }

    private void Bounce(GameObject poop)
    {
        //poop.GetComponent<Rigidbody2D>().AddForce(Vector2.up * _bouncePower);
        poop.GetComponent<Rigidbody2D>().velocity = Vector2.up * _bouncePower;
    }
}
