using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectEggRed : MonoBehaviour
{
    public GameObject Door;
    public GameObject Door2;
    public float y=5;
    public float x=5;
    public float z=5;
    public float door2x = 5;
    public float door2y = 5;
    public float door2z = 5;


    private bool isCollected = false;

    // Start is called before the first frame update
   void OnTriggerEnter(Collider other) 
    {
        if (!isCollected)
        {
            Door.gameObject.transform.position = new Vector3(x, y, z);
            Door2.gameObject.transform.position = new Vector3(door2x, door2y, door2z);
            ScoringSystem.theScore += 1;
            Debug.Log(gameObject.name + " + 1" + other.name);
            Destroy(gameObject);
            isCollected = true;
        }

    }
}
