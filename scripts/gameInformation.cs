using UnityEngine;
using System.Collections;

public class gameInformation : MonoBehaviour {

  void Awake () {
    DontDestroyOnLoad (transform.gameObject);
  }

  public static string playerName {
    get{return playerName;}
    set{playerName = value;}
  }
  public static int playerLevel {
    get{return playerLevel;}
    set{playerLevel = value;}
  }
  public static baseCharacterClass playerClass {
    get{return playerClass;}
    set{playerClass = value;}
  }
  
  public static int armourClass {
    get{return armourClass;}
    set{armourClass = value;}
  }
  public static int hitPoints {
    get{return hitPoints;}
    set{hitPoints = value;}
  }
  public static int heroicAction {
    get{return heroicAction;}
    set{heroicAction = value;}
  }
  public static int strength {
    get{return strength;}
    set{strength = value;}
  }
  public static int dexterity {
    get{return dexterity;}
    set{dexterity = value;}
  }
  public static int constitution {
    get{return constitution;}
    set{constitution = value;}
  }
  public static int intelligence {
    get{return intelligence;}
    set{intelligence = value;}
  }
  public static int wisdom {
    get{return wisdom;}
    set{wisdom = value;}
  }
  public static int charisma {
    get{return charisma;}
    set{charisma = value;}
  }

}
