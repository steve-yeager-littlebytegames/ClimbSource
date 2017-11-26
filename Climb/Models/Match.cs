﻿using Newtonsoft.Json;

namespace Climb.Models
{
    public class Match
    {
        public int ID { get; set; }
        public int Index { get; set; }
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        public int? Player1CharacterID { get; set; }
        public int? Player2CharacterID { get; set; }
        public int? StageID { get; set; }

        [JsonIgnore]
        public Set Set { get; set; }
        [JsonIgnore]
        public Character Player1Character { get; set; }
        [JsonIgnore]
        public Character Player2Character { get; set; }
        [JsonIgnore]
        public Stage Stage { get; set; }

        public Character WinningCharacter => Player1Score > Player2Score ? Player1Character : Player2Character;
        public bool IsDitto => Player1CharacterID == Player2CharacterID;
    }
}
