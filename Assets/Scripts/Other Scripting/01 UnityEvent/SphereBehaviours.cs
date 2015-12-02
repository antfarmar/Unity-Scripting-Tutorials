using UnityEngine;
using System.Collections;
using System;
using UnityEngine.Events;

public class SphereBehaviours : MonoBehaviour
{

    public int Health;
    public Color ColorHealth;



    public void Reset()
    {
        Health = 10;
        ColorHealth = Color.green;
        GetComponent<Renderer>().sharedMaterial.color = ColorHealth;
    }

    public void Start()
    {
        Reset();
    }


    public void IncreaseHealth(int amount)
    {
        Health += amount;

        if(Health > 10)
            Health = 10;
    }


    public void ReduceHealth(int amount)
    {
        Health -= amount;

        if(Health < 0)
            Health = 0;
    }


    public void DrawHealth()
    {
        ColorHealth.r = 1 - Health / 10f;
        ColorHealth.g = Health / 10f;
        GetComponent<Renderer>().sharedMaterial.color = ColorHealth;
    }


    public void RandomPosition()
    {
        transform.position = UnityEngine.Random.insideUnitCircle;
    }

}