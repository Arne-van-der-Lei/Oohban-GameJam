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
        Physics.Raycast(Camera.main.ScreenToWorldPoint(mousePosition),Camera.main.transform.forward,out hit, Mathf.Infinity);
        pointer.transform.position = hit.point;
        
        if (Input.GetMouseButtonUp(0) && hit.collider != null)
        {
            hit.collider.SendMessage("OnClick",SendMessageOptions.DontRequireReceiver);
        }
    }
}
