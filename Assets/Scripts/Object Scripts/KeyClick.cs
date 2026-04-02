using UnityEngine;

public class KeyClick : MonoBehaviour
{
    public NurseryBox chest;

    bool isClicked;

    // Update is called once per frame
    void OnMouseDown()
    {
        if (chest.selectedKeys[chest.clickedKeys] == null && isClicked == false)
        {
            chest.selectedKeys[chest.clickedKeys] = gameObject;
            chest.clickedKeys++;
            isClicked = true;

            if (chest.clickedKeys == 3)
            {
                chest.checkKey();
            }
        }
    }

    void Update()
    {
        if (chest.clickedKeys == 0)
        {
            isClicked = false;
        }
    }
}
