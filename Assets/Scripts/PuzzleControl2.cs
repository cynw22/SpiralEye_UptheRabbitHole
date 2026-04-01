using UnityEngine;

public enum ItemToFind { GUMDROP, MILK, FLOWERS, BOBA, RECIPEBOOK };

public class PuzzleControl2 : MonoBehaviour
{
    public bool gumdrops, milk, flowers, boba, recipes, allItemsCollected = false;

    GameObject booksNotTaken;
    GameObject booksTaken;
    GameObject environmentTall;
    GameObject environmentShort;

    void Start()
    {
        booksNotTaken = GameObject.Find("TallBooks");
        booksTaken = GameObject.Find("TinyBooks (1)");
        booksTaken.GetComponent<SpriteRenderer>().enabled = false;

        environmentTall = GameObject.Find("Ch3_teaParty_Con_BG_bookStack_0");
        environmentShort = GameObject.Find("TinyBooksEnvironment");
        environmentShort.GetComponent<SpriteRenderer>().enabled = false;
    }

    public void books_OnClick()
    {
        booksNotTaken.GetComponent<PolygonCollider2D>().enabled = false;
        booksNotTaken.GetComponent<SpriteRenderer>().enabled = false;
        booksTaken.GetComponent<SpriteRenderer>().enabled = true;
    }

    public void booksEnvironment() {
        environmentTall.GetComponent<SpriteRenderer>().enabled = false;
        environmentShort.GetComponent<SpriteRenderer>().enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (gumdrops && milk && flowers && boba && recipes) { allItemsCollected = true; }

        if (recipes) {
            books_OnClick();
            booksEnvironment();
        }
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
