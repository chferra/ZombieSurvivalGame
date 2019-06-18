﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] string wName;
    [SerializeField] int price;
    [SerializeField] float fadingCoefficient;
    [SerializeField] int gunType;
    private int level;

    private void Start()
    {
        level = 1;
    }
    
    public virtual void incLevel()
    {
        level++;
    }
    public void setDamage(int dm)
    {
        damage = dm;
    }
    public void incDamage(int d)
    {
        damage = d;
    }      
    public void incPrice(int p)
    {
        price += p;
    }
    public void decFadingCoefficient(int fk)
    {
        fadingCoefficient -= fk;
    }

    public int getLevel()
    {
        return level;
    }
    public int getPrice()
    {
        return price;
    }
    public int getDamage()
    {
        return damage;
    }
    public float getFadingCoefficient()
    {
        return fadingCoefficient;
    }
    public int getGunType()
    {
        return gunType;
    }

    public virtual void fire()
    {

    }
}