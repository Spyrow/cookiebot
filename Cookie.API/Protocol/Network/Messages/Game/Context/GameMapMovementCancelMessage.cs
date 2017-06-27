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
    
    
    public class GameMapMovementCancelMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 953;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_cellId;
        
        public virtual ushort CellId
        {
            get
            {
                return m_cellId;
            }
            set
            {
                m_cellId = value;
            }
        }
        
        public GameMapMovementCancelMessage(ushort cellId)
        {
            m_cellId = cellId;
        }
        
        public GameMapMovementCancelMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhShort(m_cellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_cellId = reader.ReadVarUhShort();
        }
    }
}
