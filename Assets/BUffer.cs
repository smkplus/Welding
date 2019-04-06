using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUffer : MonoBehaviour {
	public RenderTexture RT;
	public Material mat;

private void OnRenderImage(RenderTexture src, RenderTexture dest) {
	Graphics.Blit(src,dest,mat);
}
}
