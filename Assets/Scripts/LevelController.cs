using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    public Sprite SwitchOn;
    public Sprite SwitchOff;
    public GameObject Switch;
    public GameObject Key;
    public bool GotKey;
    public GameObject door;
    public Animator Anim;
	// Use this for initialization
	void Start () {

       Anim= door.GetComponent<Animator>();
		Switch.GetComponent<SpriteRenderer>().sprite = SwitchOff;

    }
	
	// Update is called once per frame
	void Update () {

    }


    public void TurnSwitchOn()
    { 
        Switch.GetComponent<SpriteRenderer>().sprite = SwitchOn;
		Anim.SetBool ("canOpen", true); 
    }


    public void TurnSwitchOff()
    {
        Switch.GetComponent<SpriteRenderer>().sprite = SwitchOff;
		Anim.SetBool ("canOpen", false);
    }


    public void KeyCollectable()
    {

       
        GotKey = true;


    }
}
