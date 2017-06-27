//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GameMapNoMovementMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 954;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private short m_cellX;
        
        public virtual short CellX
        {
            get
            {
                return m_cellX;
            }
            set
            {
                m_cellX = value;
            }
        }
        
        private short m_cellY;
        
        public virtual short CellY
        {
            get
            {
                return m_cellY;
            }
            set
            {
                m_cellY = value;
            }
        }
        
        public GameMapNoMovementMessage(short cellX, short cellY)
        {
            m_cellX = cellX;
            m_cellY = cellY;
        }
        
        public GameMapNoMovementMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(m_cellX);
            writer.WriteShort(m_cellY);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_cellX = reader.ReadShort();
            m_cellY = reader.ReadShort();
        }
    }
}
