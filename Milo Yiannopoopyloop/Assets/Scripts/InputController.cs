using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class InputController : MonoBehaviour
{
    private GameObject _poop;
    private CanvasRenderer _quitText;
    void Start()
    {
        _quitText = GameObject.Find("Text_PressQ").GetComponent<CanvasRenderer>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            InstantiatePoop();
        }
        if (Input.GetKeyDown(KeyCode.Q))
            Application.Quit();
        
    }

    private void InstantiatePoop()
    {
        Vector2 mrPoopyButtPos = GameObject.Find("MrPoopyButt").transform.position;

        _poop = Instantiate(Resources.Load("Poop")) as GameObject;
        _poop.transform.position = new Vector2(mrPoopyButtPos.x + 1, mrPoopyButtPos.y - 1.5F);
        _poop.name = "Poop";
        float mass = Random.Range(.5F, 1.75F);
        _poop.GetComponent<Rigidbody2D>().mass = mass;

        
    }
}
