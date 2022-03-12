using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateTarget : MonoBehaviour
{
    Rigidbody target;
    int speed = 20;
    int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        target.AddTorque(Vector3.forward * speed * Time.deltaTime);
    }
    public void getdamage(int damage)
    {
        if (healthChecker() == true)
        {
            health -= damage;
        }
        
    }
    bool healthChecker()
    {
        if (health <= 0)
        {
            Debug.Log("Target Destroy");
            Destroy(gameObject);
            return false;
        }
        return true;
    }
}
