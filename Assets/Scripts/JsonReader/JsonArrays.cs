using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class JsonArrays 
{
    public Names _charNames;
    public Character _charDetails;
}
public class Character 
{
    public string[] charRaces;
    public string[] charClasses;
    public string[] charStats;
    public string[] storyAdjective;
    public string[] storyLocation;
    public string[] storyDetails;
}

[System.Serializable]
public class Names
{
    public string[] Aarakocra;
    public string[] Aasimar;
    public string[] Bugbear;
    public string[] Centaur;
    public string[] Changeling;
    public string[] Dragonborn;
    public string[] Dwarf;
    public string[] Elf;
    public string[] Firbolg;
    public string[] Genasi;
    public string[] Gith;
    public string[] Gnome;
    public string[] Goblin;
    public string[] Goliath;
    public string[] Grung;
    public string[] Half_Elf;
    public string[] Half_Orc;
    public string[] Halfling;
    public string[] Hobgoblin;
    public string[] Human;
    public string[] Kalashtar;
    public string[] Kenku;
    public string[] Kobold;
    public string[] Leonin;
    public string[] Lizardfolk;
    public string[] Locathah;
    public string[] Loxodon;
    public string[] Minotaur;
    public string[] Orc;
    public string[] Satyr;
    public string[] Shifter;
    public string[] Simic_Hybrid;
    public string[] Tabaxi;
    public string[] Tiefling;
    public string[] Tortle;
    public string[] Triton;
    public string[] Vedalken;
    public string[] Warforged;
    public string[] Yuan_ti;
}