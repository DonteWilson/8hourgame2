﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ControlCenter : MonoBehaviour

{
    
    // Use this for initialization
    //Sets Vector2 direction to equal right
    Vector2 d = Vector2.right;

    //Sets bool obtain to false;
    bool obtain = false;

    public GameObject FollowerPrefab;

    public GameObject TBorder;
    //Stores the last position of the follower into a list.
    List<Transform> Follower = new List<Transform>();

    void Start()
    {
        //Repeats this every repeatRate seconds, creates the feel of the object movbin
        InvokeRepeating("Navigate", 0.3f, 0.4f);
        //Navigate();

       

    }

    // Update is called once per frame
    void Update()
    {   
        //if user hits the left arrow key he is move into the left position
        if (Input.GetKey(KeyCode.LeftArrow))
            d = -Vector2.right;
        //Moves the leader is the right position
        else if (Input.GetKey(KeyCode.RightArrow))
            //switches direction to right
            d = Vector2.right;
        //Switches Vector2 up to negative, so it brings the follower down.
        else if (Input.GetKey(KeyCode.DownArrow))
            //switches direction to up
            d = -Vector2.up;
        //Moves the leader is the up position
        else if (Input.GetKey(KeyCode.UpArrow))
            //Switches direction to up
            d = Vector2.up;

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        //Checks to see if Leader collides with Follower
        if (coll.name.StartsWith("Mob"))
            Destroy(coll.gameObject); 
        
        //When the leader collides he obtains a follower.
        
    }
    //function is unused 
    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "TBorder")
        {
           
        }
    }



    //Navigate function to represe
    void Navigate()
    {
        
        Vector2 v = transform.position;
        transform.Translate(d);
        if (obtain)
        {
            GameObject GO = (GameObject)Instantiate(FollowerPrefab, v, Quaternion.identity);

            Follower.Insert(0, GO.transform);
            //sets obtain false
            obtain = false;
        }
        //checks to see if follower count is greater than 0
        else if (Follower.Count > 0)
        {
            Follower.Last().position = v;
            //Inserts the follower into the lasr position of the main player object.
            Follower.Insert(0, Follower.Last());
            Follower.RemoveAt(Follower.Count - 1);
        }
    }

    void OnTriggerEnter(Collider Coll)
    {
        //if(Coll.tag = "")
        //{

        //}
    }

}
