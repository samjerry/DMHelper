using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadJson : MonoBehaviour
{
    [SerializeField] private TextAsset _charNameFile; // this file contains all the character names possible sorted by Race.
    [SerializeField] private TextAsset _charDetailsFile; // this file contains all the detail names possible sorted by Type (Race, Class, Stats).

    // These Text fields represent the content from the Character.cs Arrays.
    [SerializeField] private Text _raceText;
    [SerializeField] private Text _classText;
    [SerializeField] private Text _statText;
    [SerializeField] private Text _nameText;
    [SerializeField] private Text _storyText;

    public string charRace; //this string is used by GetRaceNames() if you change this string to a race you got from the race generator you will get the corresponding character names if you call GetRaceNames().

    public JsonArrays newChar; // this will be used as our current instance of Character.cs.
    public Character newCharDetails;
    public Names newCharNames;


    void Start()
    {
        newChar = new JsonArrays(); // actually creates the new instance of Character.cs

        newCharDetails = newChar._charDetails;
        newCharDetails = JsonUtility.FromJson<Character>(_charDetailsFile.text); // this reads the _charDetailsFile containing (Race, Class, Stats) the Array names in the json must be the EXACT SAME as the var names in Character.cs
        newCharNames = newChar._charNames;
        newCharNames = JsonUtility.FromJson<Names>(_charNameFile.text);// this reads the _charNameFile containing (names for all races) the Array names in the json must be the EXACT SAME as the var names in Character.cs

        // clears the text from the text fields
        _statText.text = "";
        _classText.text = "";
        _raceText.text = "";
        _nameText.text = "";
        _storyText.text = "";

        DetailsToText(); // for each array (except names) puts each index into the corresponding text fields

        //puts all names from the Race = charRace into the _nameText field
        foreach (string _name in GetRaceNames())
        {
            if (_name == "ERROR: INVALID RACE")
            {
                _nameText.text = _name;
                break;
            }

            _nameText.text += _name + "\n";
        }
    }

    private void DetailsToText()
    {
        for (int i = 0; i < newCharDetails.charRaces.Length; i++)
        {
            if (i == newCharDetails.charRaces.Length)
            {
                _raceText.text += newCharDetails.charRaces[i];
                break;
            }
            _raceText.text += newCharDetails.charRaces[i] + "\n";
        }

        for (int i = 0; i < newCharDetails.charClasses.Length; i++)
        {
            if (i == newCharDetails.charClasses.Length)
            {
                _classText.text += newCharDetails.charClasses[i];
                break;
            }
            _classText.text += newCharDetails.charClasses[i] + "\n";
        }

        for (int i = 0; i < newCharDetails.charStats.Length; i++)
        {
            if (i == newCharDetails.charStats.Length)
            {
                _statText.text += newCharDetails.charStats[i];
                break;
            }
            _statText.text += newCharDetails.charStats[i] + "\n";
        }

        //_storyText.text = GameObject.Find("BackstoryGenerator").GetComponent<BackstoryGenerator>().GenerateBackstory(newChar); // randomize the character backstory
    }

    public string[] GetRaceNames()
    {
        string[] _names = new string[255];

        //compares the charRace with all Races and returns the array of the corresponding race.
        switch (charRace)
        {
            case "Aarakocra": _names = newCharNames.Aarakocra; break;
            case "Aasimar": _names = newCharNames.Aasimar; break;
            case "Bugbear": _names = newCharNames.Bugbear; break;
            case "Centaur": _names = newCharNames.Centaur; break;
            case "Changeling": _names = newCharNames.Changeling; break;
            case "Dragonborn": _names = newCharNames.Dragonborn; break;
            case "Dwarf": _names = newCharNames.Dwarf; break;
            case "Elf": _names = newCharNames.Elf; break;
            case "Firbolg": _names = newCharNames.Firbolg; break;
            case "Genasi": _names = newCharNames.Genasi; break;
            case "Gith": _names = newCharNames.Gith; break;
            case "Gnome": _names = newCharNames.Gnome; break;
            case "Goblin": _names = newCharNames.Goblin; break;
            case "Goliath": _names = newCharNames.Goliath; break;
            case "Grung": _names = newCharNames.Grung; break;
            case "Half_Elf": _names = newCharNames.Half_Elf; break;
            case "Half_Orc": _names = newCharNames.Half_Orc; break;
            case "Halfling": _names = newCharNames.Halfling; break;
            case "Hobgoblin": _names = newCharNames.Hobgoblin; break;
            case "Human": _names = newCharNames.Human; break;
            case "Kalashtar": _names = newCharNames.Kalashtar; break;
            case "Kenku": _names = newCharNames.Kenku; break;
            case "Kobold": _names = newCharNames.Kobold; break;
            case "Leonin": _names = newCharNames.Leonin; break;
            case "Lizardfolk": _names = newCharNames.Lizardfolk; break;
            case "Locathah": _names = newCharNames.Locathah; break;
            case "Loxodon": _names = newCharNames.Loxodon; break;
            case "Minotaur": _names = newCharNames.Minotaur; break;
            case "Orc": _names = newCharNames.Orc; break;
            case "Satyr": _names = newCharNames.Satyr; break;
            case "Shifter": _names = newCharNames.Shifter; break;
            case "Simic_Hybrid": _names = newCharNames.Simic_Hybrid; break;
            case "Tabaxi": _names = newCharNames.Tabaxi; break;
            case "Tiefling": _names = newCharNames.Tiefling; break;
            case "Tortle": _names = newCharNames.Tortle; break;
            case "Triton": _names = newCharNames.Triton; break;
            case "Vedalken": _names = newCharNames.Vedalken; break;
            case "Warforged": _names = newCharNames.Warforged; break;
            case "Yuan_ti": _names = newCharNames.Yuan_ti; break;
            default: _names[0] = "ERROR: INVALID RACE"; break;
        }
        return _names;
    }
}