using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinHilang : MonoBehaviour{
    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.tag == "playerTag"){
            Destroy(gameObject);
        }
    }
}
