﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCtrl : MonoBehaviour{
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player")){
            GameCtrl.instance.playerDied(other.gameObject);
        } else{
            Destroy(other.gameObject);
        }
    }
}