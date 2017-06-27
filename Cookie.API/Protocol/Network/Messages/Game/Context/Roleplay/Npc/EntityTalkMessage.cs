//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Npc
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class EntityTalkMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6110;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.String> m_parameters;
        
        public virtual List<System.String> Parameters
        {
            get
            {
                return m_parameters;
            }
            set
            {
                m_parameters = value;
            }
        }
        
        private double m_entityId;
        
        public virtual double EntityId
        {
            get
            {
                return m_entityId;
            }
            set
            {
                m_entityId = value;
            }
        }
        
        private ushort m_textId;
        
        public virtual ushort TextId
        {
            get
            {
                return m_textId;
            }
            set
            {
                m_textId = value;
            }
        }
        
        public EntityTalkMessage(List<System.String> parameters, double entityId, ushort textId)
        {
            m_parameters = parameters;
            m_entityId = entityId;
            m_textId = textId;
        }
        
        public EntityTalkMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_parameters.Count)));
            int parametersIndex;
            for (parametersIndex = 0; (parametersIndex < m_parameters.Count); parametersIndex = (parametersIndex + 1))
            {
                writer.WriteUTF(m_parameters[parametersIndex]);
            }
            writer.WriteDouble(m_entityId);
            writer.WriteVarUhShort(m_textId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int parametersCount = reader.ReadUShort();
            int parametersIndex;
            m_parameters = new System.Collections.Generic.List<string>();
            for (parametersIndex = 0; (parametersIndex < parametersCount); parametersIndex = (parametersIndex + 1))
            {
                m_parameters.Add(reader.ReadUTF());
            }
            m_entityId = reader.ReadDouble();
            m_textId = reader.ReadVarUhShort();
        }
    }
}
