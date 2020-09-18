using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Timers;

public class Particle : MonoBehaviour
{

  public Transform particle1;
  public GameObject obstacle;

  // Start is called before the first frame update
  void Start()
  {
    particle1.GetComponent<ParticleSystem>().enableEmission = false;

  }

  // Update is called once per frame
  private void OnTriggerEnter(Collider other)
  {

    if (other.CompareTag("Car"))
    {
      particle1.GetComponent<ParticleSystem>().Emit(100);
      Destroy(obstacle);
    }
  }


}

