using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atılanMenzilli : MonoBehaviour
{
	public int damage = 8;
	Vector3 direction;
	[SerializeField] float speed; //Bunu kesinlikle 0 olarak bırakmayın
	
	public void SetDirection(float dir_x, dir_y)
	{
		direction = new Vector3(dir_x, dir_y);
		
		if(dir_x < 0)
		{
			Vector3 scale = transform.localScale;
			scale.x = scale.x* -1;
			transform.localScale =scale;
		}
	}
	bool vurulma = false;
	void Update()
	{
		transform.position += direction * speed * Time.deltaTime;
		Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, 0.3f);// Bu kısmı saldırının bölgesine göre değiştire biliriz
		
		
		foreach(Collider2D c in hit)
		{
			Düşman düşman = c.GetComponent<Düşman>();
			if(düşman != null)
			{
				düşman.TakeDamage(damage);
				vurulma =true;
				break;
				
			}
		}
		if(vurulma)
		{
			Destroy(gameObject);
		}
	}
}