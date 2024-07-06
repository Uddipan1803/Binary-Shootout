using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthController : MonoBehaviour
{
    public int totalHealth = 3;
    public GameObject deathEffect;
    KillCounter killCounterScript;

    private void Start()
    {
        killCounterScript=GameObject.Find("KCO").GetComponent<KillCounter>();
    }
    public void DamageEnemy(int damageAmount)
    {
        totalHealth -= damageAmount;

        if(totalHealth <= 0)
        {
            if(deathEffect != null)
            {
                Instantiate(deathEffect, transform.position, transform.rotation);
            }
            Destroy(gameObject);
            killCounterScript.AddKill();
        }
    }
}
