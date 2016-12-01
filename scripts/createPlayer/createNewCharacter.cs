using UnityEngine;
using System.Collections;

public class createNewCharacter : MonoBehaviour {

  private basePlayer newPlayer;
  private bool isBerserkerClass;
  private bool isDrowClass;
  private string playerName = "Enter Name";

  //Used for initialization
  void Start () {
    newPlayer = new basePlayer ();
  }

  //
  void Update () {

  }

  void onGUI () {
    playerName = guiLayout.TextArea (playerName);
    isBerserkerClass = guiLayout.Toggle (isBerserkerClass, "Berserker Class");
    isDrowClass = guiLayout.Toggle (isDrowClass, "Drow Class");
    if (guiLayout.Button ("Create")) {
      if (isBerserkerClass) {
        newPlayer.playerClass = new baseBerserkerClass ();
      } else if (isDrowClas) {
        newPlayer.playerClass = new baseDrowClass ();
      }
      newPlayer.playerLevel = 1;
      newPlayer.armourClass = newPlayer.playerClass.armourClass;
      newPlayer.hitPoints = newPlayer.playerClass.hitPoints;
      newPlayer.heroicAction = newPlayer.playerClass.heroicAction;
      newPlayer.strength = newPlayer.playerClass.strength;
      newPlayer.dexterity = newPlayer.playerClass.dexterity;
      newPlayer.constitution = newPlayer.playerClass.constitution;
      newPlayer.intelligence = newPlayer.playerClass.intelligence;
      newPlayer.wisdom = newPlayer.playerClass.wisdom;
      newPlayer.charisma = newPlayer.playerClass.charisma;
      newPlayer.playerName = playerName;

      Debug.Log ("Player Name: " + newPlayer.playerName);
      Debug.Log ("Player Class: " + newPlayer.playerClass.characterClassName);
      Debug.Log ("Player Level: " + newPlayer.playerLevel);
      Debug.Log ("Player Armour Class: " + newPlayer.armourClass);
      Debug.Log ("Player Hit Points: " + newPlayer.hitPoints);
      Debug.Log ("Player Heroic Action: " + newPlayer.heroicAction);
      Debug.Log ("Player Strength: " + newPlayer.strength);
      Debug.Log ("Player Dexterity: " + newPlayer.dexterity);
      Debug.Log ("Player Constitution: " + newPlayer.constitution);
      Debug.Log ("Player Intelligence: " + newPlayer.intelligence);
      Debug.Log ("Player Wisdom: " + newPlayer.wisdom);
      Debug.Log ("Player Charisma: " + newPlayer.charisma);
    }
  }

















}
