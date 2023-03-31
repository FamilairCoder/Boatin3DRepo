using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BobberBar : MonoBehaviour
{
    public bool max;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (PlayerMovement.bobberforce < 75) { transform.localScale += new Vector3(0, 4, 0) * Time.deltaTime; }
            GetComponent<Image>().enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.localScale = new Vector3(transform.localScale.x, 0, transform.localScale.z);
            GetComponent<Image>().enabled = false;
        }
    }
}
