using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicManager : MonoBehaviour
{   
    [SerializeField] public int customerNum=2;
    
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void DecCustomerNum()
    {
        this.customerNum--;
        Debug.Log("GoodJob");
        if (customerNum == 0)
        {
            Debug.Log("Game Over");
        }
    }
}
