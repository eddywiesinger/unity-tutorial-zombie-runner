using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Image damageImage;
    [SerializeField] float fadeOutTime = 0.5f;
    private float elapsedTime;

    public void Go()
    {
        StartCoroutine(FadeOutImage());
    }
    
    IEnumerator FadeOutImage()
    {
        Color c;
        elapsedTime = 0;
        while (elapsedTime < fadeOutTime)
        {
            float newAlpha = Mathf.Lerp(1f, 0, elapsedTime/fadeOutTime);
            c = damageImage.color;
            c.a = newAlpha;
            damageImage.color = c;
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        c = damageImage.color;
        c.a = 0;
        damageImage.color = c;
    }
}
