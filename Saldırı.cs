using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AttackKod;

public class Saldırı : MonoBehaviour
{
	public int saldırıGücü = 40;
	public Transform saldırıNoktası;
	public LayerMask düşmanLayers;
	public Animator animator;
	public float saldırıAlanı = 0.5f;  //Ben şimdilik 0.5 olarak ayarladım ama spritelar ile ilgilenen kişi değiştire bilir.
	
	
	
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space)) //Şimdilik space yaptım zıplama özelliği düşünmediğimiz için.
		{
			Saldır();
		}
	}
	
	void Saldır()
	{
		animator.SetTrigger("Saldır");
		
		Collider2D[] vurulDüşman = Physics2D.OverlapCircleAll(saldırıNoktası.position,saldırıAlanı,düşmanLayers);
		
		foreach(Collider2D düşman in vurulDüşman)
		{
			düşman.GetComponent<Düşman>().TakeDamage(saldırıGücü);
		}
	}
	
	void OnDrawGizmosSelected()
	{
		if(saldırıNoktası == null)
		{
			return
		}
		
		Gizmos.DrawWireSphere(saldırıNoktası.position,saldırıAlanı);
	}
}
