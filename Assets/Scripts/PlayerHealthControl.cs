using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthControl : MonoBehaviour
{
    public static  PlayerHealthControl instance;

    private void Awake(){
        instance=this;
    }

    public int currentHealth;
    public int maxHealth;
    // Start is called before the first frame update
     void Start()
    {
        currentHealth=maxHealth;
        UIControl.instance.UpdateHealth(currentHealth,maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DamagePlayer(int damageAmount)
    {
        currentHealth-=damageAmount;
        if(currentHealth<=0){
            currentHealth=0;
            gameObject.SetActive(false);

        }
        UIControl.instance.UpdateHealth(currentHealth,maxHealth);
    }
}
