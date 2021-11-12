using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject startPos;
    public EnemyManager en;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            shoot();
        }
    }
    void Damage(float Edamage)
    {
        en.EnemyHealth -= Edamage;
    }
    void shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(startPos.transform.position,transform.forward,out hit))
        {
            Damage(20);
        }
    }
}
