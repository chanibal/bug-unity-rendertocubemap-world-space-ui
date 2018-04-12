using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTRenderer : MonoBehaviour {

	public RenderTexture rtCubemap;
	public RenderTexture rtNormal;


	void Update () {
		var cam = GetComponent<Camera>();

		cam.RenderToCubemap(rtCubemap);

		var oldTarget = cam.targetTexture;
		cam.targetTexture = rtNormal;
		cam.Render();
		cam.targetTexture = oldTarget;
	}

}
