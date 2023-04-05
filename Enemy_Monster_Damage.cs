using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameJam;

public static class Enemy_Monster_Damage : MonoBehaviour
{
	public int damage;
	public PlayerHealth playerhealth;
	
	// bundan önceki player health scriptine bağlanması gerekiyor ki damahe fonksiyonu işe yarasın
	
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "Player")
		{
			playerhealth.TakeDamage(damage)
			
			//Bu script düşmana bağlı olacak ve çalışması için karaktere "Player" tag ini koymanız gerek
		}
	}
}
