using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyScript;

public class Düşman : MonoBehaviour
{
	public Animator animator;
	public int maxHealth = 100;
	int currentHealth;
	
	void Start()
	{
		currentHealth = maxHealth;
	}
	
	public void TakeDamage(int zarar)
	{
		currentHealth -= zarar;
		
		animator.SetTrigger("Vurul");
		
		if(currentHealth <= 0)
		{
			Öl();
		}
	}
	
	void Öl()
	{
		animator.SetBool("Ölü", true);
		GetComponent<Collider2D>().enabled = false;
		this.enabled = false;
	}
	
}
