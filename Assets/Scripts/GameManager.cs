using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public static GameManager gameMan;
  // Start is called before the first frame update

  private void Awake()
  {
    if (gameMan == null)
    {
      gameMan = this;
    }
    else if (gameMan != this)
    {
      Destroy(gameObject);
    }

    DontDestroyOnLoad(gameObject);
  }


  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void GameStart()
  {
    SceneManager.LoadScene("Game");
  }
  public void GameEnd()
  {
    SceneManager.LoadScene("Menu");
  }
}
