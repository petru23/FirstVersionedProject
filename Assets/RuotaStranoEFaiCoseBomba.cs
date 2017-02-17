using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuotaStranoEFaiCoseBomba : MonoBehaviour {
    private float accumulator;

    void Awake ()
	{
	}
	
	void Update ()
	{
	    accumulator += Time.deltaTime;
	    transform.forward += Vector3.one * Mathf.Cos(accumulator) * 0.01f;
        transform.localScale += Vector3.one * Mathf.Sin(accumulator) * 0.01f;
    }
}
