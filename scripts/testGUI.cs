using UnityEngine;
using System.Collections;

public class testGUI : MonoBehaviour {

  private baseCharacterClass classOne = new baseDrowClass ();
  private baseCharacterClass classTwo = new baseBerserkerClass ();

  //Used for initialization
  void Start () {

  }

  //Used to be called on once per frame
  void Update () {

  }

  void onGUI () {
    guiLayout.Label(classOne.characterClassName);
    guiLayout.Label(classOne.characterClassDescription);


    guiLayout.Label(classTwo.characterClassName);
    guiLayout.Label(classTwo.characterClassDescription);
  }







}
