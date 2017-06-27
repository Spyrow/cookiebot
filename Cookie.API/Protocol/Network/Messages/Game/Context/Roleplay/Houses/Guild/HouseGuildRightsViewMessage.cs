//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Houses.Guild
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class HouseGuildRightsViewMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5700;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_houseId;
        
        public virtual uint HouseId
        {
            get
            {
                return m_houseId;
            }
            set
            {
                m_houseId = value;
            }
        }
        
        private int m_instanceId;
        
        public virtual int InstanceId
        {
            get
            {
                return m_instanceId;
            }
            set
            {
                m_instanceId = value;
            }
        }
        
        public HouseGuildRightsViewMessage(uint houseId, int instanceId)
        {
            m_houseId = houseId;
            m_instanceId = instanceId;
        }
        
        public HouseGuildRightsViewMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_houseId);
            writer.WriteInt(m_instanceId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_houseId = reader.ReadVarUhInt();
            m_instanceId = reader.ReadInt();
        }
    }
}
