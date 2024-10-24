using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEnd : MonoBehaviour
{
    public GameObject EndText;

    public void PlayEndText()
    {
        EndText.SetActive(true);
        EndText.GetComponent<Animator>().Play("EndText");
    }
}
