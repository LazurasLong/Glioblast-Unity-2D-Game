using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour {

	public RectTransform[] Tiles;

	public Transform MapBar;
	public Vector2 TileSize;
	public Transform Enemy;
	static public int[] Xs1;//= {1,1,2,3,4,4,4,3,2,1,0,0,0,1,1,2,3,4,4,5,6,6,6,6,5,4,3,3 };
	static public int[] Ys1;// = {9,8,8,8,8,7,6,6,6,6,6,5,4,4,3,3,3,3,4,4,4,3,2,1,1,1,1,0 };
	static public int[] Js1;// = {2,5,3,3,0,2,4,3,3,3,1,2,5,0,5,3,3,4,1,3,0,2,2,4,3,3,1,2 };
	private int[] Xs;
	private int[] Ys;
	private int[] Js;
	public float spawnTime = 5f;
	float startx,starty;
	int isfirst=0;
	// Use this for initialization
	void Start ()
	{


		Xs = new int[]{1,1,2,3,4,4,4,3,2,1,0,0,0,1,1,2,3,4,4,5,6,6,6,6,5,4,3,3 };
		Ys = new int[]{9,8,8,8,8,7,6,6,6,6,6,5,4,4,3,3,3,3,4,4,4,3,2,1,1,1,1,0 };
		Js = new int[]{2,5,3,3,0,2,4,3,3,3,1,2,5,0,5,3,3,4,1,3,0,2,2,4,3,3,1,2 };

		Xs1 = Xs;
		Ys1 = Ys;
		Js1 = Js;
		CreateFunction (Xs, Ys, Js);

		InvokeRepeating ("CreateEnemy",spawnTime, spawnTime);
	}

	// Update is called once per frame
	void Update () {
		GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
	 foreach(GameObject enemy in enemies){
		 if(enemy.transform.localPosition.y < -168f)
		 GameObject.Destroy(enemy.gameObject);
	 }

	}



	void CreateFunction (int[] xs , int[] ys , int[] js)
	{
		for(int i = 0 ; i < xs.Length ; i++)
		{
			RectTransform NewTile = Instantiate (Tiles [js[i]], MapBar);
			NewTile.position=new Vector3 (NewTile.position.x + xs[i]*0.5625143f, NewTile.position.y + ys[i]*0.65f, NewTile.position.z);
			if(isfirst==0){
				startx = NewTile.localPosition.x;
				starty = NewTile.localPosition.y;
				isfirst=1;
			}

		}

	}
	void CreateEnemy()
	{
		Transform Enemy1 = Instantiate (Enemy, MapBar);

		Enemy1.localPosition = new Vector3 (startx, starty, -4f);
		Enemy1.rotation = Quaternion.Euler (0,0,180);

	}
}
