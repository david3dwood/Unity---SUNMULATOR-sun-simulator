using System.Collections;
using System.Collections.Generic;
using UnityEngine;



	public class TargetClick : MonoBehaviour {

	public GameObject activePrefab;
	Vector3 targetPosition;

	void Start () {

		targetPosition = transform.position;
	}
	void Update(){

		if (Input.GetMouseButtonDown(1)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit)){
				targetPosition = hit.point;
				activePrefab.transform.position = targetPosition;
			}
		}
	}
}