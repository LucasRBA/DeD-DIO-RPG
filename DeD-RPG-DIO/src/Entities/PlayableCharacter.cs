using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeD_RPG_DIO.src.Entities
{
     public class PlayableCharacter : Character
     {
          public PlayableCharacter
          (
                 string Name,
                 int Age,
                 int Level,
                 string Title,// If its know for something or not, or is noble
                 int Health_points,
                 int Mana_Points,
                 bool Combatant, // Civilian or not
                 Enum CharacterType, //NPC
                 Enum Faction, // Enemy, Ally or Neutral
                 Enum? Deity, // Wheter believes or not in any deity or god
                 Enum Alignment, // LE, CG, TN
                 Enum Race, //Human
                 Enum? Class, // Rogue
                 string EyeColor,
                 string SkinColor,
                 string HairColor,
                 bool MultiClass, // If its above level 20 and decided to multiclass
                 int XP,
                 List<String>? Abilities,
                 List<String>? Gear,
                 List<String>? Inventory
          )
          {
               this.Name = Name;
               this.Age = Age;
               this.Level = Level;
               this.Title = Title;
               this.Combatant = Combatant;
               this.CharacterType = CharacterType;
               this.Faction = Faction;
               this.Deity = Deity;
               this.Alignment = Alignment;
               this.Race = Race;
               this.Class = Class;
               this.EyeColor = EyeColor;
               this.SkinColor = SkinColor;
               this.HairColor = HairColor;
               this.MultiClass = MultiClass; //NPC Describe won't have
               this.XP = XP;

          }

          string Name;
          int Age;
          int Level;
          string Title; // If its know for something or not, or is noble
          bool Combatant; // Civilian or not
          Enum CharacterType; //NPC
          Enum Faction; // Enemy, Ally or Neutral
          Enum? Deity; // Wheter believes or not in any deity or god
          Enum Alignment; // LE, CG, TN
          Enum Race; //Human
          Enum? Class; // Rogue
          string EyeColor;
          string SkinColor;
          string HairColor;
          bool MultiClass; // If its above level 20 and decided to multiclass
          int XP;

          List<String> Inventory = new List<string>();
          List<String> Gear = new List<string>();
          List<String> Abilities = new List<string>();

          //método atacar // usar habilidades

          public override string Describe()
          {
               System.Console.WriteLine($"Character was named {this.Name} a reckless killer of any abomination possessing {this.Age} years of bloodspilling anger, for the eyes of an accurate Wizard suach as myself his level was at least {this.Level} , known as {this.Title} he is indeed an {this.Faction} of humanity, but is feared as the Devil itself. \n His belief belongs to Kord and that fact alone explains his silhouette, too strong and full of reflexes for any {this.Class} or spellcaster, once he alone stopped a fight inside a tavern, story tolds that without any magic or drop of sweat two Paladins reached the ground at once and were dragged by him outside the same tavern. \n The fear he causes upon a simple look at his face is mostly because he is a {this.Race} with {this.EyeColor} penetrating eyes and {this.SkinColor} skin combined with its Eerie {this.HairColor} long hair. \n I feel kindness in his heart but by his intentions of exterminating any demon that pure heart is slowly being swallowed by an immense chaos, he has been building up to much power for an until unknown intent, I must reach him before its too late...");
               return "Finished Desciption";
          }

          //método subir de nível

     }
}