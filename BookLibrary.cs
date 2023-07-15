// BookLibrary.cs
using System;

public class BookLibrary
{
    private string[] bookTitles = {
        "Beauty Queens – Libba Bray",
        "Before I Let Go – Marieke Nijkamp",
        "The Belles (#1) – Dhonielle Clayton",
        "Big Bones – Laura Dockrill",
        "Caraval – Stephanie Garber",
        "Coraline – Neil Gaiman",
        "Dangerous Lies – Becca Fitzpatrick",
        "Descendants – Rae Else",
        "Fangirl – Rainbow Rowell",
        "Final Girls – Riley Sager",
        "Girlhood – Cat Clarke",
        "Hades – Alexandra Adornetto",
        "Heaven – Alexandra Adornetto",
        "Home Fire – Kamila Shamsie",
        "Internment – Samira Ahmed",
        "Kindred Spirits – Rainbow Rowell",
        "Milk and Honey – Rupi Kaur",
        "Oleanna – David Mamet",
        "Paintbrush – Hannah Bucchin",
        "Zenn Diagram – Wendy Brant"
    };

    public void DisplayBookList()
    {
        Console.WriteLine("LIST OF BOOKS:");
        for (int i = 0; i < bookTitles.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {bookTitles[i]}");
        }
        Console.WriteLine();
    }
}
