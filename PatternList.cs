using UnityEngine;
using System.Collections;

public class PatternList : MonoBehaviour {


	public float projectileSpeed;
	public GameObject bulletPrefabs;

	// Use this for initialization
	private float delayAttack = 3f;
	private float lastAttack = 0;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Test ();
	}

	public void Blast(float projectileSpeed, float angle){
		
		for (float i = 0; i < 360; i += angle) {
			GameObject instance = Instantiate (bulletPrefabs, transform.position, Quaternion.identity) as GameObject;
			float rad = Mathf.Deg2Rad * i;
			instance.GetComponent<Rigidbody2D> ().velocity = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad)) * projectileSpeed;
			/*
				float dir = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad)) * projectileSpeed;		  
				Front(projectileSpeed, dir);
			*/
		}
	}

	public void StarRotation(float projectileSpeed, float count, float rotationSpeed, bool isClockwise){
		count = 360 / count;
		for (float i = 0; i < 360; i -= count) {
			float t = Time.time * rotationSpeed;

			GameObject instance = Instantiate (bulletPrefabs, transform.position, Quaternion.identity) as GameObject;
			float rad = Mathf.Deg2Rad * (i + t);

			if (isClockwise) {
				instance.GetComponent<Rigidbody2D> ().velocity = new Vector2(- Mathf.Cos(rad), - Mathf.Sin(rad)) * projectileSpeed;
			} else {
				instance.GetComponent<Rigidbody2D> ().velocity = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad)) * projectileSpeed;
			}
			/*
			if (isClockwise) {
				vector2 dir = new Vector2(- Mathf.Cos(rad), - Mathf.Sin(rad)) * projectileSpeed;
			} else {
				vector2 dir = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad)) * projectileSpeed;
			}
			Front(projectileSpeed, dir);
			*/
		}
	}

	public void Front(float projectileSpeed, Vector2 dir){

		GameObject instance = Instantiate (bulletPrefabs, transform.position, Quaternion.identity as GameObject;
		instance.GetComponent<Rigidbody2D> ().velocity = dir * projectileSpeed;
	}



	void Test(){
		if (Time.time - lastAttack > delayAttack) {
	//		lastAttack = Time.time;
			StarRotation(10,4, 30, true);
		}
	}
}
