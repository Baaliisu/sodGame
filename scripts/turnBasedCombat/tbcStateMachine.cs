using UnityEngine;
using System.Collections;

public class tbcStateMachine : MonoBehaviour {

  public enum battleStates {
    start,
    playerChoice,
    enemyChoice,
    lose,
    win
  }

  private battleStates currentState;

  //Used for initialization
  void Start () {
    currentState = battleStates.start;
  }

  //Used to be called on once per frame
  void Update () {
    Debug.Log (currentState);
    switch (currentState) {
      case (battleStates.start) :
        //Setup battle function
        break;
      case (battleStates.playerChoice) :
        break;
      case (battleStates.enemyChoice) :
        break;
      case (battleStates.lose) :
        break;
      case (battleStates.win) :
        break;
    }
  }

  void onGUI () {
    if (guiLayout.Button ("next state")) {
      if (currentState == battleStates.start) {
        currentState = battleStates.playerChoice;
      } else if (currentState == battleStates.playerChoice) {
        currentState == battleStates.enemyChoice;
      } else if  (currentState == battleStates.enemyChoice) {
        currentState == battleStates.lose;
      } else if (currentState == battleStates.lose) {
        currentState == battleStates.win;
      } else if (currentState == battleStates.win) {
        currentState == battleStates.start;
      }
    }
  }





    
  }
