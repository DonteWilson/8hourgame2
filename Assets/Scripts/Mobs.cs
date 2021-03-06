﻿using UnityEngine;
using System.Collections;

public class Mobs : MonoBehaviour {

    public GameObject Mob;
    public GameObject Mine;
    public Transform LBorder;
    public Transform RBorder;
    public Transform TBorder;
    public Transform BBorder;
    

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("Zombie", 2, 5);
        InvokeRepeating("Mines", 1, 2);
	}
	
	// Update is called once per frame
	void Zombie ()
    {
        int x = (int)Random.Range(LBorder.position.x, RBorder.position.x);

        int y = (int)Random.Range(TBorder.position.y, BBorder.position.y);

        Instantiate(Mob, new Vector2(x, y), Quaternion.identity);
	}

    void Mines()
    {
        int x = (int)Random.Range(LBorder.position.x, RBorder.position.x);

        int y = (int)Random.Range(TBorder.position.y, BBorder.position.y);

        Instantiate(Mine, new Vector2(x, y), Quaternion.identity);

    }
}
