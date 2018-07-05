using System;
using System.Collections.Generic;

namespace Tamagotchese.Models
{
  public class Tamagotchi
  {
    private string name;
    private int food = 80;
    private int attention = 50;
    private int rest = 80;
    private int id;

    private static List<Tamagotchi> pets = new List<Tamagotchi> {};
    public Tamagotchi(string newName)
    {
      name = newName;
      pets.Add(this);
      id = pets.Count;
    }
    public string GetName()
    {
      return name;
    }
    public int GetFood()
    {
      return food;
    }
    public void SetFood(int foodValue)
    {
      food = foodValue;
    }
    public int GetAttention()
    {
      return attention;
    }
    public void SetAttention(int attentionValue)
    {
      attention = attentionValue;
    }
    public int GetRest()
    {
      return rest;
    }
    public void SetRest(int restValue)
    {
      rest = restValue;
    }
    public int GetId()
    {
      return id;
    }
    public static List<Tamagotchi> GetAll()
    {
      return pets;
    }
    public static Tamagotchi Find(int searchId)
    {
      return pets[searchId-1];
    }
    public static void ClearAll()
    {
      pets.Clear();
    }
  }
}
