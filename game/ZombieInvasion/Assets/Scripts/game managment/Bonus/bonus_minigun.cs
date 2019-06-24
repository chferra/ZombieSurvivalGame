﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonus_minigun : bonus
{
    #region Singleton
    public static bonus_minigun instance;
    void Awake()
    {
        instance = this;
    }
    #endregion

    [SerializeField] int duration;
    [SerializeField] GameObject timerPrefab;
    private Timer time;
    private bool minigunActive;
    private int temp;

    private void Start()
    {
        time = Instantiate(timerPrefab).GetComponent<Timer>();
        minigunActive = false;
        isSpawned = false;
        temp = 0;
    }
    public override void tryToSpawn(Vector3 zombiePos)
    {
        if (!bonus_grenade_launcher.instance.IsSpawned())
            base.tryToSpawn(zombiePos);
    }
    public void run()
    {
        if (isSpawned)
        {
            temp = player_equipment.instance.getSelectedGunIndex();
            Debug.Log("temp: " + temp);
            player_equipment.instance.switchToBonus(3);            
            minigunActive = true;
        }
    }
    private void Update()
    {
        if (minigunActive)
        {
            if (time.triggerValue() == 0)
                time.await(duration);
            else if (time.triggerValue() == 2)
            {
                player_equipment.instance.switchGun(temp, true);
                Debug.Log("finito minigun");
                minigunActive = false;
                isSpawned = false;
            }
        }
    }
}
