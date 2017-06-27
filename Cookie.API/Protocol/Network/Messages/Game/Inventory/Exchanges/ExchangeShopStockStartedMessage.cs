//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Inventory.Exchanges
{
    using Cookie.API.Protocol.Network.Types.Game.Data.Items;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ExchangeShopStockStartedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5910;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<ObjectItemToSell> m_objectsInfos;
        
        public virtual List<ObjectItemToSell> ObjectsInfos
        {
            get
            {
                return m_objectsInfos;
            }
            set
            {
                m_objectsInfos = value;
            }
        }
        
        public ExchangeShopStockStartedMessage(List<ObjectItemToSell> objectsInfos)
        {
            m_objectsInfos = objectsInfos;
        }
        
        public ExchangeShopStockStartedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_objectsInfos.Count)));
            int objectsInfosIndex;
            for (objectsInfosIndex = 0; (objectsInfosIndex < m_objectsInfos.Count); objectsInfosIndex = (objectsInfosIndex + 1))
            {
                ObjectItemToSell objectToSend = m_objectsInfos[objectsInfosIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int objectsInfosCount = reader.ReadUShort();
            int objectsInfosIndex;
            m_objectsInfos = new System.Collections.Generic.List<ObjectItemToSell>();
            for (objectsInfosIndex = 0; (objectsInfosIndex < objectsInfosCount); objectsInfosIndex = (objectsInfosIndex + 1))
            {
                ObjectItemToSell objectToAdd = new ObjectItemToSell();
                objectToAdd.Deserialize(reader);
                m_objectsInfos.Add(objectToAdd);
            }
        }
    }
}
