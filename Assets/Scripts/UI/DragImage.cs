using UnityEngine;
using System.Collections;

public class DragImage : MonoBehaviour {

    public Vector3 getOriginalPosition { get { return originalPosition; } }

    private Vector3 originalPosition;

	// Use this for initialization
	void Start () {
	    originalPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnDrag() {
        transform.position = Input.mousePosition;
    }    
}
