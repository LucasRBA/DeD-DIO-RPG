using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeD_RPG_DIO.src.Entities
{
     public class NonPlayableCharacter : Character
     {
          public NonPlayableCharacter
          (
                 string Name,
                 int Age,
                 int Level,
                 string Title, // If its know for something or not, or is noble
                 bool Combatant, // Civilian or not
                 Enum CharacterType, //NPC
                 Enum Faction, // Enemy, Ally or Neutral
                 Enum? Deity, // Wheter believes or not in any deity or god
                 Enum Alignment, // LE, CG, TN
                 Enum Race, //Human
                 Enum? Class, // Rogue
                 string EyeColor,
                 string SkinColor,
                 bool MultiClass, // If its above level 20 and decided to multiclass
                 int XP // won't be printed by description method
          )
          {

          }
     }
}