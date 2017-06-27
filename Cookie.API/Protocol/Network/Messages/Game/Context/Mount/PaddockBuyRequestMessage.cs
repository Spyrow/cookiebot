//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Mount
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class PaddockBuyRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5951;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_proposedPrice;
        
        public virtual ulong ProposedPrice
        {
            get
            {
                return m_proposedPrice;
            }
            set
            {
                m_proposedPrice = value;
            }
        }
        
        public PaddockBuyRequestMessage(ulong proposedPrice)
        {
            m_proposedPrice = proposedPrice;
        }
        
        public PaddockBuyRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhLong(m_proposedPrice);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_proposedPrice = reader.ReadVarUhLong();
        }
    }
}
