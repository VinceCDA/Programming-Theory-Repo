using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField]
    protected int _health;

    public int Health { get => _health; set => _health = value; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 7.0f);
    }
    protected void DealDamage(Collider collider,int damagePoint)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
          collider.gameObject.GetComponent<Player>().Health -= damagePoint;
            Debug.Log(collider.gameObject.GetComponent<Player>().Health);
        }
        else
        {
            collider.gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
