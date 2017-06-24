﻿using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cookie.Datacenter;
using Cookie.Gamedata.D2o;
using Cookie.Gamedata.D2p;

namespace Cookie.Gamedata
{
    public class D2OParsing
    {
        public static Point GetMapCoordinates(int mapId)
        {
            var value = ObjectDataManager.Instance.Get<MapPosition>(mapId);
            return new Point(value.PosX, value.PosY);
        }

        public static string GetChallengeName(int Id)
        {
            var objectValue = RuntimeHelpers.GetObjectValue(ObjectDataManager.Instance.Get<Challenge>(Id).NameId);
            return FastD2IReader.Instance.GetText(Convert.ToInt32(objectValue));
        }

        public static string GetServerName(ushort id)
        {
            var objectValue = RuntimeHelpers.GetObjectValue(ObjectDataManager.Instance.Get<Server>(id).NameId);
            return FastD2IReader.Instance.GetText(Convert.ToInt32(objectValue));
        }

        public static string GetJobName(int jobId)
        {
            var objectValue = RuntimeHelpers.GetObjectValue(ObjectDataManager.Instance.Get<Job>(jobId).NameId);
            return FastD2IReader.Instance.GetText(Convert.ToInt32(objectValue));
        }

        public static string GetSpellName(int spellId)
        {
            var objectValue = RuntimeHelpers.GetObjectValue(ObjectDataManager.Instance.Get<Spell>(spellId).NameId);
            return FastD2IReader.Instance.GetText(Convert.ToInt32(objectValue));
        }

        public static object GetNameCity(int idArea)
        {
            var objectValue = RuntimeHelpers.GetObjectValue(ObjectDataManager.Instance.Get<SubArea>(idArea).NameId);
            return FastD2IReader.Instance.GetText(Convert.ToInt32(objectValue));
        }

        public static string GetItemName(uint guid)
        {
            var id = RuntimeHelpers.GetObjectValue(ObjectDataManager.Instance.Get<Item>(guid).NameId);
            return FastD2IReader.Instance.GetText(Convert.ToInt32(id));
        }

        public static Image GFXItem(uint GID)
        {
            var id = RuntimeHelpers.GetObjectValue(ObjectDataManager.Instance.Get<Item>(GID).IconId);
            return ImageManager.GetImage(Convert.ToInt32(id));
        }
    }
}