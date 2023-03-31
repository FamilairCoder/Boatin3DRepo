using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobber : MonoBehaviour
{
    public ParticleSystem FishCaughtEmitter;
    public Transform player;
    public static bool hooked;

    public float speed = 10f;
    private List<GameObject> caughtfish = new List<GameObject>();
    private bool isMoving = false;
    void Update()
    {
        if (Input.GetKey(KeyCode.S) && transform.position.y > 0)
        {
            isMoving = true;
            if (Vector3.Distance(transform.position, player.position) < 5)
            {
                Destroy(gameObject);
                foreach (var a in caughtfish)
                {
                    if (QuestManager.fishquest && QuestManager.amount < QuestManager.totalamount) { QuestManager.amount += 1; }
                    ShipLoadText.shipload += a.transform.localScale.x/3;
                    Destroy(a);
                    FishCaughtEmitter.Play();
                }
                
                hooked = false;
            }
        }
        else
        {
            isMoving = false;
        }
    }

    void FixedUpdate()
    {
        if (isMoving)
        {
            Vector3 directionToPlayer = player.position - transform.position;
            GetComponent<Rigidbody>().AddForce(directionToPlayer.normalized * speed, ForceMode.Force);
        }
    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fish") && !caughtfish.Contains(collision.gameObject))
        {
            collision.gameObject.GetComponent<FishMovement>().hookedon = gameObject;
            caughtfish.Add(collision.gameObject);
            hooked = true;
        }
    }
}
