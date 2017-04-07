using UnityEngine;
using System.Collections;

public class randomCode : MonoBehaviour {


    public float horizontalSpeed;
    public float verticalSpeed;
    public float altitude;


   // public float miniHori = 0.01f;
   // public float maxhori = -0.01f;


    public Vector3 tempPosition;


	// Use this for initialization
	void Start () {

        tempPosition = transform.position;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

       // horizontalSpeed = Random.Range(miniHori, maxhori);
        tempPosition.x = Mathf.Sin(Time.realtimeSinceStartup * horizontalSpeed) * altitude;
        tempPosition.y = Mathf.Cos(Time.realtimeSinceStartup * verticalSpeed) * altitude;
        transform.position = tempPosition;

	}
}
