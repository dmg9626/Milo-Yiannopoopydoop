using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : MonoBehaviour 
{
    float time = 0;
	// Use this for initialization
	void Start () 
    {
        PoopSoundEffect();
        gameObject.name = "Poop";
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (time > 6)
            GameObject.Destroy(gameObject);
        time += Time.deltaTime;
	}


    private void PoopSoundEffect()
    {
        GameObject sound = Instantiate(Resources.Load("Sound_Fart")) as GameObject;
        Destroy(sound, sound.GetComponent<AudioSource>().clip.length);
    }
}
