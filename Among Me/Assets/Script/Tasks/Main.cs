using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    static public Main Instance;

    public int objectiveCount;
    public GameObject finishText;
    private int onCount = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void ObjectiveChange(int points)
    {
        onCount = onCount + points;
        if (onCount == objectiveCount)
        {
            finishText.SetActive(true);
        } else
        {
            finishText.SetActive(false);
        }
    }
}
