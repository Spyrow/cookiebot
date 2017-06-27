﻿using Cookie.API.Utils.IO;

namespace Cookie.API.Protocol.Network.Types.Game.Character
{
    public class CharacterMinimalInformations : CharacterBasicMinimalInformations
    {
        public new const short ProtocolId = 110;

        public CharacterMinimalInformations()
        {
        }

        public CharacterMinimalInformations(byte level)
        {
            Level = level;
        }

        public override short TypeID => ProtocolId;

        public byte Level { get; set; }

        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(Level);
        }

        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            Level = reader.ReadByte();
        }
    }
}