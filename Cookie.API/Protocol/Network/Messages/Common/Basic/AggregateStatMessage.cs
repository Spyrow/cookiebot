//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Common.Basic
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class AggregateStatMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6669;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_statId;
        
        public virtual ushort StatId
        {
            get
            {
                return m_statId;
            }
            set
            {
                m_statId = value;
            }
        }
        
        public AggregateStatMessage(ushort statId)
        {
            m_statId = statId;
        }
        
        public AggregateStatMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhShort(m_statId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_statId = reader.ReadVarUhShort();
        }
    }
}
