//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Inventory.Items
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class InventoryWeightMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 3009;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_weight;
        
        public virtual uint Weight
        {
            get
            {
                return m_weight;
            }
            set
            {
                m_weight = value;
            }
        }
        
        private uint m_weightMax;
        
        public virtual uint WeightMax
        {
            get
            {
                return m_weightMax;
            }
            set
            {
                m_weightMax = value;
            }
        }
        
        public InventoryWeightMessage(uint weight, uint weightMax)
        {
            m_weight = weight;
            m_weightMax = weightMax;
        }
        
        public InventoryWeightMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_weight);
            writer.WriteVarUhInt(m_weightMax);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_weight = reader.ReadVarUhInt();
            m_weightMax = reader.ReadVarUhInt();
        }
    }
}
