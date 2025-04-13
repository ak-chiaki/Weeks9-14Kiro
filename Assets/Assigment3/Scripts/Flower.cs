using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{

    public float growAmount = 0.2f;       //the grow per ckick
    public float growDuration = 0.1f;      //the time of grow
    // Start is called before the first frame update
    void Start()
    {
       
    }
    public void Grow()
    {
        StartCoroutine(GrowCoroutine());
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator GrowCoroutine()
    {
           Vector3 startScale = transform.localScale;
           Vector3 targetScale = startScale + new Vector3(0f, growAmount, 0f);

           float t = 0f;
        while (t < 1f)
        {
               t += Time.deltaTime / growDuration;
               transform.localScale = Vector3.Lerp(startScale, targetScale, t);//transform the flower
               yield return null;
        }

          transform.localScale = targetScale;
    }
}
