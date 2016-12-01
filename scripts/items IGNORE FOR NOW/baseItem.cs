using UnityEngine;
using System.Collections;

public class baseItem {

  private string itemName;
  private string itemDescription;
  private int itemID;
  public enum itemTypes {
    equipment,
    weapons,
    scrolls,
    potions,
  }
  private itemTypes itemType;

  public string itemName {
    get{return itemName;}
    set{itemName = value;}
  }
  public string itemDescription {
    get{itemDescription;}
    set{itemDescription = value;}
  }
  public string itemID {
    get{return itemID;}
    set{itemID = value;}
  }
  public itemTypes itemType {
    get{return itemType;}
    set{itemType = value;}
  }








}
