using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stag : Animal
{
    [SerializeField]
    private int _attackPoint = 2;
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
        transform.Translate(Vector3.forward * Time.deltaTime * 7.5f);
    }
    private void OnTriggerEnter(Collider other)
    {
        DealDamage(other, _attackPoint);
    }
}
