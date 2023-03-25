using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    /*    public GameObject fishseed, player;
        public float dist, amount;

        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; i < amount; i++)
            {
                var posx = Random.Range(-dist, dist);
                var posz = Random.Range(-dist, dist);
                var a = Instantiate(fishseed, new(posx, 0, posz), Quaternion.identity);
                a.GetComponent<FishSeed>().player = player;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }*/

    public GameObject fish, player;
    public float spacing = 5f;
    public float spawnDistance = 10f;
    public float dist;
    private Vector3 lastPosition;

    private void Start()
    {
        lastPosition = transform.position;
    }

    private void Update()
    {
        Vector3 currentPosition = transform.position;

        if (Mathf.Abs(currentPosition.x - lastPosition.x) >= spacing ||
            Mathf.Abs(currentPosition.z - lastPosition.z) >= spacing)
        {
            lastPosition = currentPosition;

            if (Vector3.Distance(currentPosition, lastPosition) <= spawnDistance)
            {
                var amount = Random.Range(2, 10);
                for (int i = 0; i < amount; i++)
                {
                    var a = Instantiate(fish, new Vector3(currentPosition.x + Random.Range(-dist, dist), 1.5f, currentPosition.z + Random.Range(-dist, dist)), Quaternion.identity);
                    a.GetComponent<FishMovement>().player = player;
                    var scalex = Random.Range(20f, 50f);
                    var scalez = scalex + Random.Range(-15f, 15f);
                    a.transform.localScale = new(scalex, 1, scalez);
                }
            }
        }
    }

}
