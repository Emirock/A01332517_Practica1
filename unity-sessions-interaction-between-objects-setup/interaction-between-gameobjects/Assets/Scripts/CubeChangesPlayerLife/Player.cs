using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public int life = 10;
    // Use this for initialization
    void Start () {
		
	}

    void OnGUI()
    {
        GUILayout.Label("LP: " + life);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
