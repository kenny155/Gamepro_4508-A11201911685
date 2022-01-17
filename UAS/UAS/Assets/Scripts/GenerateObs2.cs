using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs2 : MonoBehaviour{
    public GameObject rocks;
    void Start(){
        InvokeRepeating("CreateObstacle",2f,1.5f);
    }
    void CreateObstacle(){
        Instantiate(rocks);
    }
}