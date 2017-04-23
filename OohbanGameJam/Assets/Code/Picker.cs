using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picker : MonoBehaviour {

    public GameObject pointer;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector3 mousePosition = Input.mousePosition;
        RaycastHit hit;
        Physics.Raycast(Camera.main.ScreenPointToRay(mousePosition),out hit, Mathf.Infinity);
        //pointer.transform.position = hit.point;
        
        if (Input.GetMouseButtonDown(0) && hit.collider != null)
        {
            hit.collider.SendMessage("OnClick",SendMessageOptions.DontRequireReceiver);
        }
    }
}
