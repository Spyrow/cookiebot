//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Havenbag
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class HavenBagFurnituresRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6637;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_cellIds;
        
        public virtual List<System.UInt16> CellIds
        {
            get
            {
                return m_cellIds;
            }
            set
            {
                m_cellIds = value;
            }
        }
        
        private List<System.Int32> m_funitureIds;
        
        public virtual List<System.Int32> FunitureIds
        {
            get
            {
                return m_funitureIds;
            }
            set
            {
                m_funitureIds = value;
            }
        }
        
        private List<System.Byte> m_orientations;
        
        public virtual List<System.Byte> Orientations
        {
            get
            {
                return m_orientations;
            }
            set
            {
                m_orientations = value;
            }
        }
        
        public HavenBagFurnituresRequestMessage(List<System.UInt16> cellIds, List<System.Int32> funitureIds, List<System.Byte> orientations)
        {
            m_cellIds = cellIds;
            m_funitureIds = funitureIds;
            m_orientations = orientations;
        }
        
        public HavenBagFurnituresRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_cellIds.Count)));
            int cellIdsIndex;
            for (cellIdsIndex = 0; (cellIdsIndex < m_cellIds.Count); cellIdsIndex = (cellIdsIndex + 1))
            {
                writer.WriteVarUhShort(m_cellIds[cellIdsIndex]);
            }
            writer.WriteShort(((short)(m_funitureIds.Count)));
            int funitureIdsIndex;
            for (funitureIdsIndex = 0; (funitureIdsIndex < m_funitureIds.Count); funitureIdsIndex = (funitureIdsIndex + 1))
            {
                writer.WriteInt(m_funitureIds[funitureIdsIndex]);
            }
            writer.WriteShort(((short)(m_orientations.Count)));
            int orientationsIndex;
            for (orientationsIndex = 0; (orientationsIndex < m_orientations.Count); orientationsIndex = (orientationsIndex + 1))
            {
                writer.WriteByte(m_orientations[orientationsIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int cellIdsCount = reader.ReadUShort();
            int cellIdsIndex;
            m_cellIds = new System.Collections.Generic.List<ushort>();
            for (cellIdsIndex = 0; (cellIdsIndex < cellIdsCount); cellIdsIndex = (cellIdsIndex + 1))
            {
                m_cellIds.Add(reader.ReadVarUhShort());
            }
            int funitureIdsCount = reader.ReadUShort();
            int funitureIdsIndex;
            m_funitureIds = new System.Collections.Generic.List<int>();
            for (funitureIdsIndex = 0; (funitureIdsIndex < funitureIdsCount); funitureIdsIndex = (funitureIdsIndex + 1))
            {
                m_funitureIds.Add(reader.ReadInt());
            }
            int orientationsCount = reader.ReadUShort();
            int orientationsIndex;
            m_orientations = new System.Collections.Generic.List<byte>();
            for (orientationsIndex = 0; (orientationsIndex < orientationsCount); orientationsIndex = (orientationsIndex + 1))
            {
                m_orientations.Add(reader.ReadByte());
            }
        }
    }
}
