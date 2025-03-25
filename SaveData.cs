using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public Inventory inventory = new Inventory();
}

[System.Serializable]
public class Inventory
{
    public int pistol;
    public bool isFull;
    public List<Items> items = new List<Items>();

}

[System.Serializable]
public class Items
{
    public string name;
    public string desc;

}
