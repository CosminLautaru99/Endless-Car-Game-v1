using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

  public Transform CarObject;
  public Text scoreText;
  private float score;


  // Update is called once per frame
  void Update()
  {
    score = CarObject.position.z + 24;
    scoreText.text = score.ToString("0");
  }
}
