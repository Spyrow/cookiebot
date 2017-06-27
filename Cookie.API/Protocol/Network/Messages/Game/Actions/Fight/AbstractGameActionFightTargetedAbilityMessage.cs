//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Actions.Fight
{
    using Cookie.API.Protocol.Network.Messages.Game.Actions;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class AbstractGameActionFightTargetedAbilityMessage : AbstractGameActionMessage
    {
        
        public new const uint ProtocolId = 6118;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_silentCast;
        
        public virtual bool SilentCast
        {
            get
            {
                return m_silentCast;
            }
            set
            {
                m_silentCast = value;
            }
        }
        
        private bool m_verboseCast;
        
        public virtual bool VerboseCast
        {
            get
            {
                return m_verboseCast;
            }
            set
            {
                m_verboseCast = value;
            }
        }
        
        private double m_targetId;
        
        public virtual double TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }
        
        private short m_destinationCellId;
        
        public virtual short DestinationCellId
        {
            get
            {
                return m_destinationCellId;
            }
            set
            {
                m_destinationCellId = value;
            }
        }
        
        private byte m_critical;
        
        public virtual byte Critical
        {
            get
            {
                return m_critical;
            }
            set
            {
                m_critical = value;
            }
        }
        
        public AbstractGameActionFightTargetedAbilityMessage(bool silentCast, bool verboseCast, double targetId, short destinationCellId, byte critical)
        {
            m_silentCast = silentCast;
            m_verboseCast = verboseCast;
            m_targetId = targetId;
            m_destinationCellId = destinationCellId;
            m_critical = critical;
        }
        
        public AbstractGameActionFightTargetedAbilityMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            byte flag = new byte();
            BooleanByteWrapper.SetFlag(0, flag, m_silentCast);
            BooleanByteWrapper.SetFlag(1, flag, m_verboseCast);
            writer.WriteByte(flag);
            writer.WriteDouble(m_targetId);
            writer.WriteShort(m_destinationCellId);
            writer.WriteByte(m_critical);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            byte flag = reader.ReadByte();
            m_silentCast = BooleanByteWrapper.GetFlag(flag, 0);
            m_verboseCast = BooleanByteWrapper.GetFlag(flag, 1);
            m_targetId = reader.ReadDouble();
            m_destinationCellId = reader.ReadShort();
            m_critical = reader.ReadByte();
        }
    }
}
