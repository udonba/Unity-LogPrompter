using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyLog : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(DummyLogCoroutine());
    }

    private IEnumerator DummyLogCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1F);

            switch (Random.Range(0, 3))
            {
                case 0:
                    Debug.LogError("Dummy Error");
                    break;
                case 1:
                    Debug.LogWarning("Dummy Warning");
                    break;
                default:
                    Debug.Log("Dummy Log");
                    break;
            }
        }
    }
}
