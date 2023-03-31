using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSell : MonoBehaviour
{
    public GameObject player;
    public ParticleSystem sellemitter;
    public float dist;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < dist && ShipLoadText.shipload > 0)
        {
            MoneyText.money += ShipLoadText.shipload;
            ShipLoadText.shipload = 0;
            sellemitter.Play();
        }
    }
}
