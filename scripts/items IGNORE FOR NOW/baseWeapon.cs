using UnityEngine;
using System.Collections;

public class baseWeapon : baseStatItem { //baseWeapon <- baseStatItem <-baseItem

  public enum weaponTypes {
    sword,
    shield,
    staff,
  }
  private weaponTypes weaponType;
  private int spellEffectID;

  public weaponTypes weaponType {
    get{return weaponType;}
    set{weaponType = value;}
  }
  public int spellEffectID {
    get{return spellEffectID;}
    set{spellEffectID = value;}
  }



}
