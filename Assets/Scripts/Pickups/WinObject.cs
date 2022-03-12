using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinObject : MonoBehaviour
{
    //public bool check;
    void OnTriggerEnter(Collider other)
    {
 
        if (other.gameObject.tag == "Player" && (FindObjectOfType<EnemyAI>().RelicPicked == true)) 
        {
                FindObjectOfType<DeathHandeler>().HandleWin();
                Destroy(gameObject);
        }

    }
}
