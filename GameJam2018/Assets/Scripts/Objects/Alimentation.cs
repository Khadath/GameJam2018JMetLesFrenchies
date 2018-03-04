﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alimentation : BaseObject {

    // Use this for initialization
    void Start()
    {
        baseHeight = gameObject.transform.position.y;
        maxHP = 400;
        isRepared = true;
        repareCooldown = 1.0f;
        itemsWellPlacedandRepared.Add(false);

        itemId = id;
        id++;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();

        if (repareCooldown > 0)
            repareCooldown -= Time.deltaTime;
    }

    public override void Destroy()
    {
        base.Destroy();
    }

    public override void Repare()
    {
        base.Repare();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "AlimentationEmplacement" && transform.parent == null)
        {

            isWellPlaced = true;
            if (isRepared && listCreated)
            {
                itemsWellPlacedandRepared[itemId] = true;
                CheckItemList();
            }
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.tag == "AlimentationEmplacement")
        {

            isWellPlaced = false;
            itemsWellPlacedandRepared[itemId] = false;

        }
    }
}
