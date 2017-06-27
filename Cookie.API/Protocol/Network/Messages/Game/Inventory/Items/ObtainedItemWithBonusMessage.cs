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
    
    
    public class ObtainedItemWithBonusMessage : ObtainedItemMessage
    {
        
        public new const uint ProtocolId = 6520;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_bonusQuantity;
        
        public virtual uint BonusQuantity
        {
            get
            {
                return m_bonusQuantity;
            }
            set
            {
                m_bonusQuantity = value;
            }
        }
        
        public ObtainedItemWithBonusMessage(uint bonusQuantity)
        {
            m_bonusQuantity = bonusQuantity;
        }
        
        public ObtainedItemWithBonusMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhInt(m_bonusQuantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_bonusQuantity = reader.ReadVarUhInt();
        }
    }
}
