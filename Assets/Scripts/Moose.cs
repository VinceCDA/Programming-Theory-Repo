using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moose : Animal
{
    [SerializeField]
    private int _attackPoint = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
    }
    protected override void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 8.0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triger");
        DealDamage(other, _attackPoint);
    }
}
