using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Es.InkPainter.Sample;
public class BrushHack : MonoBehaviour {
	public List<Texture> sprites;
	int i;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var h = Input.GetAxis("Horizontal");
		var v = Input.GetAxis("Vertical");
		if(h != 0 || v != 0){
			i++;
		}
		if(i == sprites.Count){
			i = 0;
		}
// 		var croppedTexture = new Texture2D( (int)sprites[i].rect.width, (int)sprites[i].rect.height );
// 	print(sprites[i].textureRect.x + " " + sprites[i].textureRect.y);
//  var pixels = sprites[i].texture.GetPixels(  (int)sprites[i].textureRect.x, 
//                                          (int)sprites[i].textureRect.y, 
//                                          (int)sprites[i].textureRect.width, 
//                                          (int)sprites[i].textureRect.height );
//  croppedTexture.SetPixels( pixels );
//  croppedTexture.Apply();

		GetComponent<MousePainter>().brush.brushTexture = sprites[i];

		
	}
}
