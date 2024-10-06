using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startgame : MonoBehaviour
{
    [SerializeField]private List<GameObject> removeUI;
    [SerializeField]private GameObject game;
  
  public void startGame()
  {
    game.SetActive(true);
    for(int i=0; i < removeUI.Count; i++)
    {
        removeUI[i].SetActive(false);
    }
  }

}
