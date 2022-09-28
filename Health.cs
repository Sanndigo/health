using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public float maxHealth;
    private float health;

    public Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.maxValue = maxHealth;
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = health;

        health -= Time.deltaTime * 2;

        if(health > maxHealth)
        {
        health = maxHealth;
        }
        if(health < 0)
        {
            health = 0;
        }
    }

    

    public void healthAdd()
    {
        health++;
    }
}
