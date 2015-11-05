using UnityEngine;
using System.Collections;

public class ButtonScr : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick () {
		Debug.Log ("button clicked!");
		this.GetComponent<UIButton> ();
	}
}
