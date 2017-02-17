using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MattiaScript : MonoBehaviour {

    private float timer;
    private float scaleMultiplier;

    void Awake()
    {
        timer = 2;
        scaleMultiplier = 2;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.localScale += Vector3.one * scaleMultiplier * Time.deltaTime;

        if (timer > 0)
            timer -= Time.deltaTime;
        if(timer <= 0)
        {
            timer = 2;
            scaleMultiplier *= -1;
        }
	}
}
