﻿using UnityEngine;

public class Cursor : MonoBehaviour
{
    CameraRaycaster cameraRayCaster;

    // Use this for initialization
    void Start ()
    {
        cameraRayCaster = GetComponent<CameraRaycaster>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        // print(cameraRayCaster.currentLayerHit);		
	}
}
