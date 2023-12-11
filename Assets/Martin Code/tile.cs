using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tile : MonoBehaviour
{
   public int count;
   public TextMeshPro _count;

    void start(){

     _count.text=count.ToString();
    }
    void FixedUpdate(){

         _count.text=count.ToString();
    }

}
