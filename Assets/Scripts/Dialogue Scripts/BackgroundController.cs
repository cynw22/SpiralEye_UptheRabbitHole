using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public SpriteRenderer backgroundRenderer;

    public Sprite aliceFullBG;
    public Sprite aliceEmptyBG;

    public bool isAlicePerspective = true;

    public void SetAliceEmpty()
    {
        if (isAlicePerspective)
        {
            backgroundRenderer.sprite = aliceEmptyBG;
        }
    }
}
