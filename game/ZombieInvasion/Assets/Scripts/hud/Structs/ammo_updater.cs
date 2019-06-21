﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo_updater : MonoBehaviour
{
    private UnityEngine.UI.Text magazineAmmo;
    private UnityEngine.UI.Text reserveValue;
    private void Start()
    {
        magazineAmmo = transform.Find("MagazineAmmo").GetComponent<UnityEngine.UI.Text>();
        reserveValue = transform.Find("ReserveValue").GetComponent<UnityEngine.UI.Text>();
    }
    void Update()
    {
        string ma = "";
        string rv = "";
        if (player_equipment.instance.getSelectedGunIndex() == 3 || player_equipment.instance.getSelectedGunIndex() == 4)
            ma = rv = "∞";
        else
        {
            ma = player_equipment.instance.getSelectedGun().getAmmoInMagazine().ToString();
            rv = player_equipment.instance.getSelectedGun().getReserve().ToString();
        }
        magazineAmmo.text = ma;
        reserveValue.text = rv;        
    }
}
