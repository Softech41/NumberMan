using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;


    private Rigidbody2D myRigidbody;
    public float rayLength;
    public LayerMask collisionLayer;


    public obstaclesript1 theObstacle;
    public obstaclesript2 theObstacle2;
    public GameManager thePickedNumber;








	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);



        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * rayLength, rayLength, collisionLayer);
        if (hit.collider != null){
            if (hit.collider.gameObject.tag == "Obstacles")
            {

                if (theObstacle.PickedNumber == thePickedNumber.number)
                {
                    myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
                    thePickedNumber.number = 0;
                    Debug.Log("working");
                }


                if (theObstacle2.PickedNumber == thePickedNumber.number)
                {
                    myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
                    thePickedNumber.number = 0;
                }
               // Debug.Log("Detected");
            }


        }
        

        Debug.DrawRay(transform.position, Vector2.right * rayLength, Color.black);

	}
}
