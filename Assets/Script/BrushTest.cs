using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Es.InkPainter.Sample;

public class BrushTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var h = Input.GetAxis("Horizontal");
		var v = Input.GetAxis("Vertical");
		if(h != 0 || v != 0){

		
float angle = Mathf.Atan2(v,h) * Mathf.Rad2Deg;
if(angle < 0){
	angle += 360;
}
GetComponent<MousePainter>().brush.RotateAngle = angle;
print(angle);
}
transform.Translate(v*Time.deltaTime*2,0, -h*Time.deltaTime*2);

	}
}
