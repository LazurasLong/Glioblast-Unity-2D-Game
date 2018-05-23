using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
	private int dir;
	public int count=1;
	private float step =0.01f;
	public float currx,curry;

	// Use this for initialization
	void Start ()
	{

		dir = 0;


	}

	// Update is called once per frame
	void Update ()
	{
		UpdateDir ();

		Move ();
	}


	void setEnemyOrientation(int d )
	{

		transform.rotation = Quaternion.Euler (0, 0, - d * 90);
		dir = d;

	}
	void Move ()
	{
		if (dir == 0)
			transform.position = new Vector3 (transform.position.x  , transform.position.y - step , transform.position.z);
		else if (dir == 1)
			transform.position = new Vector3 (transform.position.x +step , transform.position.y  , transform.position.z);
		else if (dir == 2 )
			transform.position = new Vector3 (transform.position.x  , transform.position.y +step , transform.position.z);
		else if (dir == 3)
			transform.position = new Vector3 (transform.position.x -step , transform.position.y  , transform.position.z);
	}
	void UpdateDir(){
		currx = transform.localPosition.x;
		curry = transform.localPosition.y;

		if (curry <= 107.3f && count==1){
			setEnemyOrientation (1);
			count++;
		}

		if(currx>=12.88069f && count==2){
			setEnemyOrientation (0);
			count++;
		}

		if (curry <= 47.8f && count==3){
			setEnemyOrientation (3);
			count++;
		}
		if(currx<=-89.7f && count==4){
			setEnemyOrientation (0);
			count++;
		}

		if (curry <= -14.1f && count==5){
			setEnemyOrientation (1);
			count++;
		}
		if(currx>=-67.7f && count==6){
			setEnemyOrientation (0);
			count++;
		}
		if (curry <= -43.7f && count==7){
			setEnemyOrientation (1);
			count++;
		}
		if(currx>=11.88069f && count==8){
			setEnemyOrientation (2);
			count++;
		}
		if (curry >= -14.5f && count==9){
			setEnemyOrientation (1);
			count++;
		}
		if(currx>=64.2f && count==10){
			setEnemyOrientation (0);
			count++;
		}
		if (curry <= -102f && count==11){
			setEnemyOrientation (3);
			count++;
		}
		if(currx<=-12.6f && count==12){
			setEnemyOrientation (0);
			count++;
		}


	}

}
