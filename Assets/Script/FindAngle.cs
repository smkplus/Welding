	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Es.InkPainter.Sample;
using System;

public class FindAngle : MonoBehaviour {
	 public Transform First;
	 public Transform Second;
	 public GameObject prefab;
	 public bool change;

private void Start() {
		StartCoroutine(CheckAngle());

}

    private IEnumerator CheckAngle()
    {
		while(true){

		 Vector3 relativePos = First.position - Second.position;

         if(Input.GetMouseButton(0)){

		
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray,out hit)){
		if(!change){
			if(relativePos.magnitude > 0.3f){
		Second.transform.position = First.position;
			}
     	First.transform.position = hit.point;
		}else{
			if(relativePos.magnitude > 0.3f){
		Second.transform.position = First.position;
			}
		First.transform.position = hit.point;
		}
		change = !change;
		}
		 

		if(relativePos.magnitude > 0.3f){
     float angle = Mathf.Atan2(relativePos.x,relativePos.z) * Mathf.Rad2Deg;
		print(angle);
		if (angle < 0)
				{
             angle += 360f;
				}
		prefab.transform.rotation = Quaternion.Euler(0,angle,0);
		GetComponent<MousePainter>().brush.RotateAngle = angle;
		}
		}
		yield return new WaitForSeconds(0.1f);
		}
    }



 }