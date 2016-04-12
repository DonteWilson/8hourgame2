using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;


public class Data : MonoBehaviour
{


    public Text Amount;
    private int Kills;

    // Use this for initialization
    void Start()
    {

        Kills = 0;
        Amount.text = "Kills: " + Kills.ToString();


    }
    void Update()
    {
        Amount.text = "Kills: " + Kills.ToString();
        
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name.StartsWith("Mob"))
            Destroy(coll.gameObject);

        Kills += 1;

        if (coll.name.StartsWith("Mine"))
            Application.LoadLevel(2);

    }


}