using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class InputController : MonoBehaviour
{
    private GameObject poop;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            poop = Instantiate(Resources.Load("Poop")) as GameObject;
            poop.transform.position = new Vector2(6.84F, 2.88F);
            poop.name = "Poop";
            float mass = Random.Range(1, 3);
            poop.GetComponent<Rigidbody2D>().mass = mass;
        }
        
    }
    
}
