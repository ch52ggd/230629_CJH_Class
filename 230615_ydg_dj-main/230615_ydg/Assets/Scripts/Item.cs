using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(0, 1 * Time.deltaTime, 0);
    }

    public void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.tag == "Rocket")
        {
            Debug.Log("아이템 먹었다");

            Destroy(this.gameObject);
        }
    }
}
