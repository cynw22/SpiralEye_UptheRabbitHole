using UnityEngine;

[System.Serializable]
public class RelationshipPoints
{
    public string characterName; // Name of the character
    public int points; // Relationship points with the character (can be positive or negative)

    // Constructor to initialize relationship points for a character
    public RelationshipPoints(string name, int startingPoints = 0)
    {
        characterName = name;
        points = startingPoints;
    }

    // Method to adjust points based on choices
    public void AdjustPoints(int amount)
    {
        points += amount;
        // Optional: Clamp the points to a range if needed (e.g., -100 to +100)
        points = Mathf.Clamp(points, -100, 100);
        Debug.Log(characterName + "'s relationship points: " + points);
    }
}