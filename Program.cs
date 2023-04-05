using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace Program;

public static class Program : MonoBehaviour
{         
	Rigidbody2D rigid2d;
	Vector3 movement;
	private float speed=3f;
	
    public void Awake()
	{
		rigid2d = GetComponent<Rigidbody2D>();
		movement = new Vector3();
		
	}
	
	void Update()
	{
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");
		
		rigid2d.velocity = movement*speed*Time.deltaTime;
	}
}
