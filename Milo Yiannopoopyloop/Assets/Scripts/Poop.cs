using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : MonoBehaviour 
{
    GameObject poo;
    float time = 0;
	// Use this for initialization
	void Start () 
    {
        PoopSoundEffect();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (time > 4)
            GameObject.Destroy(gameObject);
        time += Time.deltaTime;
	}


    void PoopSoundEffect()
    {
        GameObject sound = Instantiate(Resources.Load("Sound_Fart")) as GameObject;
        Destroy(sound, sound.GetComponent<AudioSource>().clip.length);
    }
}
