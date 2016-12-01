using UnityEngine;
using System.Collections;

public class baseCharacterClass {

  private string characterClassName;
  private string characterClassDescription;

  //Stats
  private int armourClass;
  private int hitPoints;
  private int heroicAction;
  private int strength;
  private int dexterity;
  private int constitution;
  private int intelligence;
  private int wisdom;
  private int charisma;

  public string characterClassName {
    get{return characterClassName;}
    set{characterClassName = value;}
  }
  public string characterClassDescription {
    get{return characterClassDescription;}
    set{characterClassDescription = value;}
  }

  public int armourClass {
    get{return armourClass;}
    set{armourClass = value;}
  }
  public int hitPoints {
    get{return hitPoints;}
    set{hitPoints = value;}
  }
  public int heroicAction {
    get{return heroicAction;}
    set{heroicAction = value;}
  }
  public int strength {
    get{return strength;}
    set{strength = value;}
  }
  public int dexterity {
    get{return dexterity;}
    set{dexterity = value;}
  }
  public int constitution {
    get{return constitution;}
    set{constitution = value;}
  }
  public int intelligence {
    get{return intelligence;}
    set{intelligence = value;}
  }
  public int wisdom {
    get{return wisdom;}
    set{wisdom = value;}
  }
  public int charisma {
    get{return charisma;}
    set{charisma = value;}
  }
  
}
