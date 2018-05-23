using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonhandler : MonoBehaviour {
	public Transform Botbar;
	public Transform bullet,bullet2;
	public bool tri = false;
	public bool sq = false;
	public bool dash = false;
	public bool hex = false;
	public bool cir = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void fire(){
		if(tri && hex && !sq && !dash && !cir){
			var x =Instantiate(bullet,Botbar);
			Destroy (x.gameObject, 1.0f);
			GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
	   foreach(GameObject enemy in enemies){
			 if(67f>enemy.transform.localPosition.y && enemy.transform.localPosition.y > 37f)
			 GameObject.Destroy(enemy.gameObject);
	   }


		}
		if(!tri && !hex && sq && dash && cir){
			var y=Instantiate(bullet2,Botbar);
			Destroy (y.gameObject, 1.0f);

			GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
   foreach(GameObject enemy in enemies){
		 if(-23f>enemy.transform.localPosition.y && enemy.transform.localPosition.y > -56f)
		 GameObject.Destroy(enemy.gameObject);}

		}
		 tri = false;
		 sq = false;
		 dash = false;
	 hex = false;
		 cir = false;
	}
	public void setTri(){
		tri = !tri;
	}
	public void setSq(){
		sq = !sq;
	}
	public void setDash(){
		dash = !dash;
	}
	public void setHex(){
		hex = !hex;
	}
	public void setCir(){
		cir = !cir;
	}


}
