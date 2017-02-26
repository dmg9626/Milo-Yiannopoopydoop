using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class InputController : MonoBehaviour
{
    private GameObject _poop;
    private MeshRenderer _quitText;
    void Start()
    {
        _quitText = GameObject.Find("Text_PressQ").GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _poop = Instantiate(Resources.Load("Poop")) as GameObject;
            _poop.transform.position = new Vector2(6.84F, 3.88F);
            _poop.name = "Poop";
            float mass = Random.Range(.5F, 2);
            _poop.GetComponent<Rigidbody2D>().mass = mass;

            _quitText.enabled = true;
        }
        
    }
    
}
