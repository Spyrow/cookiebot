//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Alliance
{
    using Cookie.API.Protocol.Network.Types.Game.Context.Roleplay;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class KohUpdateMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6439;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<AllianceInformations> m_alliances;
        
        public virtual List<AllianceInformations> Alliances
        {
            get
            {
                return m_alliances;
            }
            set
            {
                m_alliances = value;
            }
        }
        
        private List<System.UInt16> m_allianceNbMembers;
        
        public virtual List<System.UInt16> AllianceNbMembers
        {
            get
            {
                return m_allianceNbMembers;
            }
            set
            {
                m_allianceNbMembers = value;
            }
        }
        
        private List<System.UInt32> m_allianceRoundWeigth;
        
        public virtual List<System.UInt32> AllianceRoundWeigth
        {
            get
            {
                return m_allianceRoundWeigth;
            }
            set
            {
                m_allianceRoundWeigth = value;
            }
        }
        
        private List<System.Byte> m_allianceMatchScore;
        
        public virtual List<System.Byte> AllianceMatchScore
        {
            get
            {
                return m_allianceMatchScore;
            }
            set
            {
                m_allianceMatchScore = value;
            }
        }
        
        private BasicAllianceInformations m_allianceMapWinner;
        
        public virtual BasicAllianceInformations AllianceMapWinner
        {
            get
            {
                return m_allianceMapWinner;
            }
            set
            {
                m_allianceMapWinner = value;
            }
        }
        
        private uint m_allianceMapWinnerScore;
        
        public virtual uint AllianceMapWinnerScore
        {
            get
            {
                return m_allianceMapWinnerScore;
            }
            set
            {
                m_allianceMapWinnerScore = value;
            }
        }
        
        private uint m_allianceMapMyAllianceScore;
        
        public virtual uint AllianceMapMyAllianceScore
        {
            get
            {
                return m_allianceMapMyAllianceScore;
            }
            set
            {
                m_allianceMapMyAllianceScore = value;
            }
        }
        
        private double m_nextTickTime;
        
        public virtual double NextTickTime
        {
            get
            {
                return m_nextTickTime;
            }
            set
            {
                m_nextTickTime = value;
            }
        }
        
        public KohUpdateMessage(List<AllianceInformations> alliances, List<System.UInt16> allianceNbMembers, List<System.UInt32> allianceRoundWeigth, List<System.Byte> allianceMatchScore, BasicAllianceInformations allianceMapWinner, uint allianceMapWinnerScore, uint allianceMapMyAllianceScore, double nextTickTime)
        {
            m_alliances = alliances;
            m_allianceNbMembers = allianceNbMembers;
            m_allianceRoundWeigth = allianceRoundWeigth;
            m_allianceMatchScore = allianceMatchScore;
            m_allianceMapWinner = allianceMapWinner;
            m_allianceMapWinnerScore = allianceMapWinnerScore;
            m_allianceMapMyAllianceScore = allianceMapMyAllianceScore;
            m_nextTickTime = nextTickTime;
        }
        
        public KohUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_alliances.Count)));
            int alliancesIndex;
            for (alliancesIndex = 0; (alliancesIndex < m_alliances.Count); alliancesIndex = (alliancesIndex + 1))
            {
                AllianceInformations objectToSend = m_alliances[alliancesIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteShort(((short)(m_allianceNbMembers.Count)));
            int allianceNbMembersIndex;
            for (allianceNbMembersIndex = 0; (allianceNbMembersIndex < m_allianceNbMembers.Count); allianceNbMembersIndex = (allianceNbMembersIndex + 1))
            {
                writer.WriteVarUhShort(m_allianceNbMembers[allianceNbMembersIndex]);
            }
            writer.WriteShort(((short)(m_allianceRoundWeigth.Count)));
            int allianceRoundWeigthIndex;
            for (allianceRoundWeigthIndex = 0; (allianceRoundWeigthIndex < m_allianceRoundWeigth.Count); allianceRoundWeigthIndex = (allianceRoundWeigthIndex + 1))
            {
                writer.WriteVarUhInt(m_allianceRoundWeigth[allianceRoundWeigthIndex]);
            }
            writer.WriteShort(((short)(m_allianceMatchScore.Count)));
            int allianceMatchScoreIndex;
            for (allianceMatchScoreIndex = 0; (allianceMatchScoreIndex < m_allianceMatchScore.Count); allianceMatchScoreIndex = (allianceMatchScoreIndex + 1))
            {
                writer.WriteByte(m_allianceMatchScore[allianceMatchScoreIndex]);
            }
            m_allianceMapWinner.Serialize(writer);
            writer.WriteVarUhInt(m_allianceMapWinnerScore);
            writer.WriteVarUhInt(m_allianceMapMyAllianceScore);
            writer.WriteDouble(m_nextTickTime);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int alliancesCount = reader.ReadUShort();
            int alliancesIndex;
            m_alliances = new System.Collections.Generic.List<AllianceInformations>();
            for (alliancesIndex = 0; (alliancesIndex < alliancesCount); alliancesIndex = (alliancesIndex + 1))
            {
                AllianceInformations objectToAdd = new AllianceInformations();
                objectToAdd.Deserialize(reader);
                m_alliances.Add(objectToAdd);
            }
            int allianceNbMembersCount = reader.ReadUShort();
            int allianceNbMembersIndex;
            m_allianceNbMembers = new System.Collections.Generic.List<ushort>();
            for (allianceNbMembersIndex = 0; (allianceNbMembersIndex < allianceNbMembersCount); allianceNbMembersIndex = (allianceNbMembersIndex + 1))
            {
                m_allianceNbMembers.Add(reader.ReadVarUhShort());
            }
            int allianceRoundWeigthCount = reader.ReadUShort();
            int allianceRoundWeigthIndex;
            m_allianceRoundWeigth = new System.Collections.Generic.List<uint>();
            for (allianceRoundWeigthIndex = 0; (allianceRoundWeigthIndex < allianceRoundWeigthCount); allianceRoundWeigthIndex = (allianceRoundWeigthIndex + 1))
            {
                m_allianceRoundWeigth.Add(reader.ReadVarUhInt());
            }
            int allianceMatchScoreCount = reader.ReadUShort();
            int allianceMatchScoreIndex;
            m_allianceMatchScore = new System.Collections.Generic.List<byte>();
            for (allianceMatchScoreIndex = 0; (allianceMatchScoreIndex < allianceMatchScoreCount); allianceMatchScoreIndex = (allianceMatchScoreIndex + 1))
            {
                m_allianceMatchScore.Add(reader.ReadByte());
            }
            m_allianceMapWinner = new BasicAllianceInformations();
            m_allianceMapWinner.Deserialize(reader);
            m_allianceMapWinnerScore = reader.ReadVarUhInt();
            m_allianceMapMyAllianceScore = reader.ReadVarUhInt();
            m_nextTickTime = reader.ReadDouble();
        }
    }
}
