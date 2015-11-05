using UnityEngine;
using System.Collections;

public class ImageButtonScr : MonoBehaviour {
	protected bool flag = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick () {
		if (this.flag) {
			this.GetComponent<UISprite>().spriteName = "checkButton_2";
			this.GetComponent<UIButton>().normalSprite = "checkButton_2";
			this.flag = false;
		} else {
			this.GetComponent<UISprite>().spriteName = "checkButton_1";
			this.GetComponent<UIButton>().normalSprite = "checkButton_1";
			this.flag = true;
		}
	}

}
