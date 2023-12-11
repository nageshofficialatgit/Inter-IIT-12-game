using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tile : MonoBehaviour
{
    public int count;
    public TextMeshPro _count;
    bool isupdated = false;
    public Transform playercheck;
    public LayerMask playerlayer;
    bool collid;

    void start()
    {

        _count.text = count.ToString();
    }
    void FixedUpdate()
    {

        _count.text = count.ToString();
        collid = Physics2D.OverlapCapsule(playercheck.position, new Vector2(0f, 0f), CapsuleDirection2D.Horizontal, 0, playerlayer);
        if (collid)
        {
            if (isupdated == false)
            {
                count--;
                isupdated = true;
            }
            
            Debug.Log("collided");
        }
        else
        {
            isupdated = false;
        }
    }

}
