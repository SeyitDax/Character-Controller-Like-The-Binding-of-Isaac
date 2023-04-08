using System.Collections;
using System.Collections.Generic;
using UnityEngine


public class menzilAtış : MonoBehaviour

{	
	Program controller;
	
	[SerializeField] float saldırıZamanı;
	
	float timer;
	
	[SerializeField] GameObject menzilliPrefab;
	//Bu kısıma ateş topu falan düşünüyorum prefab olarak
	
	private void Awake()
	{
		controller = GetComponentInParent<Program>();
		//Bu kısımda herhangi bir sıkıntı çıkarsa bana söyleyin
	}
	
	private void Update()
	{
		if(timer < saldırıZamanı)
		{
			timer += Time.deltaTime;
			return;
		}
		
		timer = 0;
		SpawnMenzilli();
	}
	
	private void SpawnMenzilli()
	{
		GameObject thrownMenzilli = Insantiate(menzilliPrefab);
		thrownMenzilli.transform.position = transform.position;
		thrownMenzilli.GetComponent<atılanMenzilli>().SetDirection(controller.lastHorizontalVector,0f);
		
		//Menzilli saldırı prefabinin 0,0,0 da olduğundan emin olun
	}
}
