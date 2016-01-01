using UnityEngine;
using System.Collections;

public class SendBtnScr : MonoBehaviour {
	public UITextList textList;

	static int count = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return)) {
			this.OnClick();
		}
	}

	void OnClick () {
		// find inputLabel By Name
		GameObject input_Label = GameObject.Find ("Input_Label");
		// init string 
		string text_str = "[8bddfc]Some say:[-] " +"[33ff22]"+ count + input_Label.GetComponent<UILabel> ().text;
		// add string
		textList.Add (text_str);
		count ++;
	}
}
