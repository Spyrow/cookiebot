//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Startup
{
    using Cookie.API.Protocol.Network.Types.Game.Startup;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class StartupActionsListMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 1301;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<StartupActionAddObject> m_actions;
        
        public virtual List<StartupActionAddObject> Actions
        {
            get
            {
                return m_actions;
            }
            set
            {
                m_actions = value;
            }
        }
        
        public StartupActionsListMessage(List<StartupActionAddObject> actions)
        {
            m_actions = actions;
        }
        
        public StartupActionsListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_actions.Count)));
            int actionsIndex;
            for (actionsIndex = 0; (actionsIndex < m_actions.Count); actionsIndex = (actionsIndex + 1))
            {
                StartupActionAddObject objectToSend = m_actions[actionsIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int actionsCount = reader.ReadUShort();
            int actionsIndex;
            m_actions = new System.Collections.Generic.List<StartupActionAddObject>();
            for (actionsIndex = 0; (actionsIndex < actionsCount); actionsIndex = (actionsIndex + 1))
            {
                StartupActionAddObject objectToAdd = new StartupActionAddObject();
                objectToAdd.Deserialize(reader);
                m_actions.Add(objectToAdd);
            }
        }
    }
}
