using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  Player3 subhi;
  Player3 ali;
  Player3 joha;
  void Start()
  {
    subhi = new Player3("Subhi", 100);
    ali = new Player3("Ali", 70);
    joha = new Player3();

    Debug.Log("count=" + " " + Player3.playerCount);

    // subhi.IntializePalyer("Subhi", 100); 
    // Debug.Log(subhi.name + " " + subhi.health);
    // // hjksdfhkjsdfhkjhsdf
    // // sdhjkdshfkjdshf
    // // sdfhgjkdshfjkdshf
    // // subhi.IntializePalyer("Subhi", 95);
    // // ali.IntializePalyer("Ali", 95);
    // Debug.Log(subhi.name + " " + subhi.health);
    //Debug.Log("Player Count: " + Player3.playerCount);
    // Debug.Log(joha.name + " " + joha.health);   
  }
}