using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public ButtonScript1 btnOne;
    public ButtonScript2 btnTwo;
    public ButtonScript3 btnThree;
    public ButtonScript4 btnFour;

      public int number;
    


	// Use this for initialization
	void Start () {

        number = Mathf.Clamp(number, 1, 4);

        number = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

        if (btnOne.Ispressed)
        {
            number =number+1;
            btnOne.Ispressed = false;

            Debug.Log(number);
        }


        if (btnTwo.Ispressed)
        {
            number = number+2;
            btnTwo.Ispressed = false;
           Debug.Log(number);
        }

        if (btnThree.Ispressed)
        {
            number = number + 3;
                btnThree.Ispressed = false;

            Debug.Log(number);



        }

        if (btnFour.Ispressed)
        {
            number =number +4;

            btnFour.Ispressed = false;
            Debug.Log(number);


        }
        
    }
}
