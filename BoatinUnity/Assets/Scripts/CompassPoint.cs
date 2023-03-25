using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassPoint : MonoBehaviour
{
    public GameObject player, target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.transform.position - player.transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, -rotation.eulerAngles.y);
    }
}
