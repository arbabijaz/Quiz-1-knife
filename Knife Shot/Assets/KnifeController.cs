using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : MonoBehaviour
{
    public int speed=10;
    bool collied=false;
    int damage = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!collied)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            transform.SetParent(collision.gameObject.transform);
            collision.gameObject.GetComponent<rotateTarget>().getdamage(damage);
            collied = true;
        }
    }
}
