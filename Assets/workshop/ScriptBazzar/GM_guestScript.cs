﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Section //this is a wing
{
    public List<GameObject> installations = new List<GameObject>();

    public Transform entrance;

	public static List<Art> arts = new List<Art>();
}

public class GM_guestScript : MonoBehaviour {

    public static GM_guestScript instance = null;

    public List<Section> Wings = new List<Section>();

    private void Awake()
    {
        instance = this;
    }
    // Use this for initialization
    void Start () {
        for(int i = 0; i < Wings.Count; i++)
        {
            Debug.Log("i: " + i);
           // for(int j =0; j < Wings[i].arts.Count; j++)
           // {
                //Debug.Log("j: " + j);
                //Instantiate(Wings[i].arts[j].artObject, Wings[i].installations[j].transform.position, Quaternion.identity);
            //}
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
