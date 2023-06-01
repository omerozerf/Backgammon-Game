using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public static UserInput Instance;
    
    public Slot slot;
    public Stone stone;
    
    private Camera mainCamera;


    private void Awake()
    {
        Instance = this;
    }


    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        GetMouseClick();
    }

    public void GetMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.CompareTag("Slot"))
                {
                    Slot(hitInfo.transform.GetComponent<Slot>());
                }

                else if (hitInfo.collider.CompareTag("White"))
                {
                    White(hitInfo.transform.GetComponent<Stone>());
                }
                
                else if (hitInfo.collider.CompareTag("Black"))
                {
                    Black(hitInfo.transform.GetComponent<Stone>());
                }
            }
        }
    }

    private void Slot(Slot slot)
    {
        print("Clicked on Slot");

        this.slot = slot;
        
        Stack(slot, this.stone);
    }

    private void White(Stone stone)
    {
        print("Clicked on White");

        this.stone = stone;
    }

    private void Black(Stone stone)
    {
        print("Clicked on Black");
        
        this.stone = stone; 
    }
 

    private void Stack(Slot slot, Stone stone)
    {
        print("Stack");
        
        this.stone.transform.parent = slot.transform;
        if (slot.GetStoneList().Count == 0)
        {
            stone.transform.position = slot.transform.position;
        }
        else
        {
            Vector3 lastIndexPos = slot.GetStoneList()[^1].transform.position;
            
            if (lastIndexPos.z > 0)
            {
                stone.transform.position = new Vector3(lastIndexPos.x, lastIndexPos.y, lastIndexPos.z - 5);
            }
            else
            {
                stone.transform.position = new Vector3(lastIndexPos.x, lastIndexPos.y, lastIndexPos.z + 5);
            }
        }
        this.slot.AddStoneToList(this.stone);
    }
}
