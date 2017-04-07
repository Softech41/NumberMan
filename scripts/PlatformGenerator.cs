using UnityEngine;
using System.Collections;

public class PlatformGenerator : MonoBehaviour {

    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;


    private float platformWidth;


   // public GameObject[] thePlatforms;
    private int platformSelector;

    private float[] platformWidths;

    public ObjectPooler[] theObjectPools;



    public float randomObstacleThreshold;
    public ObjectPooler obstaclePool;


	// Use this for initialization
	void Start () {


        platformWidths = new float[theObjectPools.Length];

        for(int i=0;i < theObjectPools.Length; i++)
        {
            platformWidths[i] = theObjectPools[i].pooledObject. GetComponent<BoxCollider2D>().size.x;
        }

       //platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
	
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x < generationPoint.position.x)
        {
            platformSelector = Random.Range(0, theObjectPools.Length);
            transform.position = new Vector3(transform.position.x + platformWidths[platformSelector] + distanceBetween, transform.position.y, transform.position.z);

            



            //Instantiate(/*thePlatform*/thePlatforms[platformSelector], transform.position, transform.rotation); 

            GameObject newPlatform =theObjectPools[platformSelector].GetPooledObject();
            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);


            if (Random.Range(0f, 100f) < randomObstacleThreshold)
            {
                GameObject newObbstacle = obstaclePool.GetPooledObject();


                float obstacleXposition = Random.Range(-platformWidths[platformSelector] / 2, platformWidths[platformSelector] / 2);

                Vector3 obstaclePosition = new Vector3(0f, 0.5f, 0f);

                newObbstacle.transform.position = transform.position;
                newObbstacle.transform.rotation = transform.rotation;
                newObbstacle.SetActive(true);
            }


        }
	
	}
}
