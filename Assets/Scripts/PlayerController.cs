using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public LevelController Lm;
    public Color c;
    public bool canTurnSwitchOn; 
	public bool switchOn; 
    // Use this for initialization
    void Start () {
        c = gameObject.GetComponent<SpriteRenderer>().color;
        
    }

    // Update is called once per frame
    void Update() {

        float hAxis = Input.GetAxisRaw("Horizontal");

        if (hAxis == 1)
        {


            gameObject.transform.Translate(Vector2.right * Time.deltaTime * speed); 

        }


        if (hAxis == -1)
        {


            gameObject.transform.Translate(Vector2.right * Time.deltaTime * -speed);

        }

		if (Input.GetKeyDown(KeyCode.Space) && canTurnSwitchOn == true && Lm.GotKey == true && switchOn==false)
        {

            Lm.TurnSwitchOn();
			switchOn = true;

        }


		else if (Input.GetKeyDown(KeyCode.Space) && canTurnSwitchOn == true  && switchOn==true)
		{

			Lm.TurnSwitchOff();
			switchOn = false;

		}


        gameObject.GetComponent<SpriteRenderer>().color = c;





    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Switch")
        { 
            c.a = 0.5f;
            canTurnSwitchOn = true;
        }
    }



    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Switch")
        {
            c.a = 1f;
            canTurnSwitchOn = false;
        }
    }
}
