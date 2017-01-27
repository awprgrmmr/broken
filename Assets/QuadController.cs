using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuadController : MonoBehaviour {

    public Text LapCounter;
    private int _lapCounter;

    // Use this for initialization
    void Start () {
        _lapCounter = 0;
        LapCounter = LapCounter.GetComponent<Text>();
        LapCounter.text = "Laps: " + _lapCounter.ToString();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        _lapCounter = _lapCounter + 1;
        LapCounter.text = "Laps: " + _lapCounter.ToString();
    }
}
