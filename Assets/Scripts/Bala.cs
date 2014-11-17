using UnityEngine;
using System.Collections;

public class bala : MonoBehaviour {
	
	public Vector2 velocity = new Vector2(5,0);
	public GameObject particulas;
	public GameObject blood;
	public int damage = 5;
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = velocity * transform.localScale.x;
		//Invoke ("explotaBala", 0.2f);
	}
	
	
	
	void explotaBala(Color? color = null ){				
		var clone = Instantiate(particulas,transform.position,Quaternion.identity) as GameObject;
		clone.transform.parent = null;
		clone.particleSystem.startColor = color ?? Color.grey;
		Destroy(clone,1);
		Destroy(gameObject);
	}
	
	void OnCollisionEnter2D(Collision2D target){
		/*
		if (target.transform.tag == "Zombie") {
			explotaBala(Color.green);
			var clone2 =Instantiate(blood,transform.position,Random.rotation) as GameObject;
		} else {
		}*/
		
		explotaBala();
	}
	
}