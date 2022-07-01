using DeD_RPG_DIO.src.Entities;
using DeD_RPG_DIO.src.Enums;

PlayableCharacter myCharacter = new PlayableCharacter(
     "Akhamenom",
     34,
     20,
     "The Demon Hunter",
     160,
     100,
     true,
     CharacterTypeEnum.PlayableCharacter,
     FactionEnum.Ally,
     DeityEnum.Kord,
     AlignmentEnum.Chaotic_Good,
     RaceEnum.Tiefling,
     ClassEnum.Warlock,
     "Blueish Silver",
     "Pale Gray",
     "Light Purple",
     false,
     60000, 
     null, 
     null, 
     null
     
);
     

     

myCharacter.Describe();

//NonPlayableCharacter Foodseller = new NonPlayableCharacter();