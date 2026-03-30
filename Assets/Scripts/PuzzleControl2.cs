using UnityEngine;

public enum ItemToFind { GUMDROP, MILK, FLOWERS, BOBA, RECIPEBOOK };

public class PuzzleControl2 : MonoBehaviour
{
    public bool gumdrops, milk, flowers, boba, recipes, allItemsCollected = false;

    // Update is called once per frame
    void Update()
    {
        if (gumdrops && milk && flowers && boba && recipes) { allItemsCollected = true; }
    }

    public void findObject(ItemToFind item)
    {
        switch (item)
        {
            case ItemToFind.GUMDROP:
                gumdrops = true;
                break;
            case ItemToFind.MILK:
                milk = true;
                break;
            case ItemToFind.FLOWERS:
                flowers = true;
                break;
            case ItemToFind.BOBA:
                boba = true;
                break;
            case ItemToFind.RECIPEBOOK:
                recipes = true;
                break;
        }
    }
}
