﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
  /* public Text moneyTxt; */
  public GameObject gameOverPan;

  public Image[] hitPoints;
  public void UpdateLives(int hp)
  {
    for (int i = 0; i < hitPoints.Length; i++)
    {
      if (hp > i)
      {
        hitPoints[i].color = Color.white;
      }
      else
      {
        hitPoints[i].color = Color.black;
      }
    }
  }

  /* public void UpdateMoney(int money)
  {
    moneyTxt.text = money.ToString();
  } */




  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }
}
