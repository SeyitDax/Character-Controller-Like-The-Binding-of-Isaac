using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AItakip : MonoBehaviour
{
    public float aradakiMesafe; //Bunu ne kadar uzaktan fark edilmek istiyorsak ona göre ayarlayın
    public GameObject player; //Buraya Inspectordan Plaher Karekterini sürükleyip koyun
    public float speed;
    public int damage; //Ben Herhangi bir hasar değeri koymadım bulduğumuz düşmanlara göre koyun siz
    public float attackDistance; // Ne kadar yaklaşınca saldırıya başlayacağını göstermek için 

    private float mesafe;
    private bool isAttacking = false;

    void Start()
    {
    }

    void Update()
    {
        mesafe = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position; //Bu kısımı rotasyon eklersek diye yazdım ama olurda eklemezsek silin gitsin

        if (mesafe < aradakiMesafe && !isAttacking)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            if (mesafe <= attackDistance)
            {
                isAttacking = true;
                StartCoroutine(AttackPlayer());
            }
        }
    }

    IEnumerator AttackPlayer()
    {
        while (isAttacking)
        {
            player.GetComponent<PlayerHealth>().TakeDamage(damage);
            yield return new WaitForSeconds(1.0f);
        }
    }
}