using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public float speed = -1;
	private Transform spawnPoint;
	private Camera myCamera;
	// Use this for initialization
	void Start () {
		myCamera = Camera.main;
		GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
		spawnPoint = GameObject.Find("SpawnPoint").transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnBecameInvisible()
	{	
		if (myCamera == null)
			return;
		float yMax = myCamera.orthographicSize - 0.5f;
		transform.position = new Vector3( spawnPoint.position.x, 
		                                 Random.Range(-yMax, yMax), 
		                                 transform.position.z );
	}
}
