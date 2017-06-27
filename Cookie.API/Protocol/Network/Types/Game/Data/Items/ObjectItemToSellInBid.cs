//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Data.Items
{
    using Cookie.API.Protocol.Network.Types.Game.Data.Items.Effects;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ObjectItemToSellInBid : ObjectItemToSell
    {
        
        public new const short ProtocolId = 164;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_unsoldDelay;
        
        public virtual int UnsoldDelay
        {
            get
            {
                return m_unsoldDelay;
            }
            set
            {
                m_unsoldDelay = value;
            }
        }
        
        public ObjectItemToSellInBid(int unsoldDelay)
        {
            m_unsoldDelay = unsoldDelay;
        }
        
        public ObjectItemToSellInBid()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(m_unsoldDelay);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_unsoldDelay = reader.ReadInt();
        }
    }
}
