﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : ExtendedBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GameplayManager.Instance.FinishGame(true);
        }
        else if (collision.collider.CompareTag("Enemy"))
        {
            GameplayManager.Instance.FinishGame(false);
        }
    }
}