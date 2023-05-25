using System;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private List<Stone> stoneList = new List<Stone>();


    public void AddStoneToList(Stone stone)
    {
        stoneList.Add(stone);
    }


    public List<Stone> GetStoneList()
    {
        return stoneList;
    }
}
