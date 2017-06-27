//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Fight
{
    using Cookie.API.Utils.IO;
    using System.Collections.Generic;


    public class FightResultPlayerListEntry : FightResultFighterListEntry
    {
        
        public new const short ProtocolId = 24;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<FightResultAdditionalData> m_additional;
        
        public virtual List<FightResultAdditionalData> Additional
        {
            get
            {
                return m_additional;
            }
            set
            {
                m_additional = value;
            }
        }
        
        private sbyte m_level;
        
        public virtual sbyte Level
        {
            get
            {
                return m_level;
            }
            set
            {
                m_level = value;
            }
        }
        
        public FightResultPlayerListEntry(List<FightResultAdditionalData> additional, sbyte level)
        {
            m_additional = additional;
            m_level = level;
        }
        
        public FightResultPlayerListEntry()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(m_level);
            writer.WriteShort(((short)(m_additional.Count)));
            int additionalIndex;
            for (additionalIndex = 0; (additionalIndex < m_additional.Count); additionalIndex = (additionalIndex + 1))
            {
                FightResultAdditionalData objectToSend = m_additional[additionalIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_level = reader.ReadSByte();
            int additionalCount = reader.ReadUShort();
            int additionalIndex;
            m_additional = new System.Collections.Generic.List<FightResultAdditionalData>();
            for (additionalIndex = 0; (additionalIndex < additionalCount); additionalIndex = (additionalIndex + 1))
            {
                FightResultAdditionalData objectToAdd = ProtocolTypeManager.GetInstance<FightResultAdditionalData>((short)reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_additional.Add(objectToAdd);
            }
        }
    }
}
