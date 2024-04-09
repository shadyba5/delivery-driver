using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] bool hasPackage;
    [SerializeField] float destroyDelayTime=0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(0, 0, 0, 1);
    SpriteRenderer carSpriteRenderer;
    LogicManager manager;

    void Start()
    {
        carSpriteRenderer = GetComponent<SpriteRenderer>();
        manager = GetComponent<LogicManager>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Booom!");
        hasPackage = false;
        carSpriteRenderer.color = noPackageColor;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            carSpriteRenderer.color = hasPackageColor;
        }

        if (other.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered package!");

            // Destroy the Customer GameObject after a delay
            Destroy(other.gameObject, destroyDelayTime);

            carSpriteRenderer.color = noPackageColor;
            hasPackage = false;

          
            // Check if the manager is found
            if (manager != null)
            {
                // Log the customer number before decreasing
                Debug.Log("Customer Number before: " + manager.customerNum);

                // Decrease the customer number
                manager.DecCustomerNum();

                // Log the customer number after decreasing
                Debug.Log("Customer Number after: " + manager.customerNum);
            }
            else
            {
                Debug.Log("LogicManager not found on the collided GameObject.");
            }
        }
    }

}
