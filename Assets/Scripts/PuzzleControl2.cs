using UnityEngine;

public enum ItemToFind { GUMDROP, MILK, FLOWERS, BOBA, RECIPEBOOK };

public class PuzzleControl2 : MonoBehaviour
{
    public bool gumdrops, milk, flowers, boba, recipes, allItemsCollected = false;

    //User Feedback
    [SerializeField] public GameObject gumdropsCollectedPopup;
    [SerializeField] public GameObject milkCollectedPopup;
    [SerializeField] public GameObject flowersCollectedPopup;
    [SerializeField] public GameObject bobaCollectedPopup;
    [SerializeField] public GameObject recipesCollectedPopup;

    private bool milkPopupDone = false;
    private bool gumdropsPopupDone = false;
    private bool flowersPopupDone = false;
    private bool bobaPopupDone = false;
    private bool recipesPopupDone = false;

    //Books Popup
    GameObject booksNotTaken;
    GameObject booksTaken;

    //Books Environment
    GameObject environmentTall;
    GameObject environmentShort;

    //Flowers Environment
    int numFlowers;
    //GameObject[] flowersEnvironment;
    GameObject flowersEnvironment0;
    GameObject flowersEnvironment1;
    GameObject flowersEnvironment2;
    GameObject flowersEnvironment3;
    GameObject flowersEnvironment4;
    GameObject flowersEnvironment5;
    GameObject flowersEnvironment6;
    GameObject flowersEnvironment7;
    GameObject flowersEnvironment8;


    void Start()
    {
        //User Feedback
        //milkCollected.SetActive(false);

        //Environment Assigning Values
        booksNotTaken = GameObject.Find("TallBooks");
        booksTaken = GameObject.Find("TinyBooks (1)");
        booksTaken.GetComponent<SpriteRenderer>().enabled = false;

        environmentTall = GameObject.Find("Ch3_teaParty_Con_BG_bookStack_0");
        environmentShort = GameObject.Find("TinyBooksEnvironment");
        environmentShort.GetComponent<SpriteRenderer>().enabled = false;

        //numFlowers = 8;
        //thought maybe can do arrays but I dont understand arrays
        //flowersEnvironment = GameObject.Find(flowersEnvironment.ToString("b"+numFlowers));

        flowersEnvironment0 = GameObject.Find("f0");
        flowersEnvironment0.GetComponent<SpriteRenderer>().enabled = true;
        flowersEnvironment1 = GameObject.Find("f1");
        flowersEnvironment1.GetComponent<SpriteRenderer>().enabled = true;
        flowersEnvironment2 = GameObject.Find("f2");
        flowersEnvironment2.GetComponent<SpriteRenderer>().enabled = true;
        flowersEnvironment3 = GameObject.Find("f3");
        flowersEnvironment3.GetComponent<SpriteRenderer>().enabled = true;
        flowersEnvironment4 = GameObject.Find("f4");
        flowersEnvironment4.GetComponent<SpriteRenderer>().enabled = true;
        flowersEnvironment5 = GameObject.Find("f5");
        flowersEnvironment5.GetComponent<SpriteRenderer>().enabled = true;
        flowersEnvironment6 = GameObject.Find("f6");
        flowersEnvironment6.GetComponent<SpriteRenderer>().enabled = true;
        flowersEnvironment7 = GameObject.Find("f7");
        flowersEnvironment7.GetComponent<SpriteRenderer>().enabled = true;
        flowersEnvironment8 = GameObject.Find("f8");
        flowersEnvironment8.GetComponent<SpriteRenderer>().enabled = true;

        //User feedback
        gumdropsCollectedPopup.SetActive(false);
        flowersCollectedPopup.SetActive(false);
        bobaCollectedPopup.SetActive(false);
        recipesCollectedPopup.SetActive(false);
        milkCollectedPopup.SetActive(false);

        milkPopupDone = false;
        gumdropsPopupDone = false;
        flowersPopupDone = false;
        bobaPopupDone = false;
        recipesPopupDone = false;
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

    public void flowersCollected() {
        flowersEnvironment0.GetComponent<SpriteRenderer>().enabled = false;
        flowersEnvironment1.GetComponent<SpriteRenderer>().enabled = false;
        flowersEnvironment2.GetComponent<SpriteRenderer>().enabled = false;
        flowersEnvironment3.GetComponent<SpriteRenderer>().enabled = false;
        flowersEnvironment4.GetComponent<SpriteRenderer>().enabled = false;
        flowersEnvironment5.GetComponent<SpriteRenderer>().enabled = false;
        flowersEnvironment6.GetComponent<SpriteRenderer>().enabled = false;
        flowersEnvironment7.GetComponent<SpriteRenderer>().enabled = false;
        flowersEnvironment8.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gumdrops && milk && flowers && boba && recipes) { allItemsCollected = true; }

        //Changing Background
        if (recipes) {
            books_OnClick();
            booksEnvironment();
        }

        if (flowers) {
            flowersCollected();
        }

        //User Feedback
        if (gumdrops && !gumdropsPopupDone)
        {
            gumdropsCollectedPopup.SetActive(true);
            gumdropsPopupDone = true;
        }
        if (flowers && !flowersPopupDone)
        {
            flowersCollectedPopup.SetActive(true);
            flowersPopupDone = true;
        }
        if (boba && !bobaPopupDone)
        {
            bobaCollectedPopup.SetActive(true);
            bobaPopupDone = true;
        }
        if (recipes && !recipesPopupDone)
        {
            recipesCollectedPopup.SetActive(true);
            recipesPopupDone = true;
        }
        if (milk && !milkPopupDone) {
            milkCollectedPopup.SetActive(true);
            milkPopupDone = true;
        }

    }

    public void CloseGumdrop() => gumdropsCollectedPopup.SetActive(false);
    public void CloseMilk() => milkCollectedPopup.SetActive(false);
    public void CloseFlowers() => flowersCollectedPopup.SetActive(false);
    public void CloseBoba() => bobaCollectedPopup.SetActive(false);
    public void CloseRecipes() => recipesCollectedPopup.SetActive(false);
    

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
