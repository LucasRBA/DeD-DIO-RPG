using DeD_RPG_DIO.src.Enums; 

namespace DeD_RPG_DIO.src.Entities
{
     public class Character
     {
          public Character
          (
               string Name,
               int Age,
               int Level,
               string Title, // If its know for something or not, or is noble
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
               int XP
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

          public Character() {   

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



          public virtual string Describe() {
               System.Console.WriteLine($"Character was named {this.Name}");
               return "Finished Desciption";
          }
          
     }

     
     
}