﻿using Alito.Classes.Entities;
using Alito.Classes.Entities.Subject;
using System;
using System.IO;

namespace Alito.Classes.Helpers
{
    internal class JSONHelper
    {
        public static JSONHelper Instanse;

        private string path = Path.Combine(Directory.GetParent
            (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName, "Roaming", "Alita.json");
        public DBJSON _json;

        public JSONHelper()
        {
            _json = new DBJSON();
        }

        public void SaveJson()
        {
            JSONSerializeController.SerializeObject(_json, path);
        }

        public void LoadJson()
        {
            if (!System.IO.File.Exists(path))
            {
                _json = new DBJSON();
                return;
            }
            _json = JSONSerializeController.DeserializeObject<DBJSON>(path);
        }

        public bool IsHaveUser(long id)
        {
            foreach (var user in _json.Users)
                if (user.chatID == id)
                    return true;
            return false;
        }

        public void AddUser(long chatId, string nickname, string petName)
        {
            _json.Users.Add(new Entities.ClassUser(chatId, nickname, petName));
        }

        public ClassUser FindUser(long chatId)
        {
            foreach (var user in _json.Users)
                if (user.chatID == chatId)
                    return user;
            return null;
        }

        public Task FindUserTest(long id)
        {
            var user = FindUser(id);
            if (user._selectedTest == null)
                return;

            foreach(var task in _json.Exams.)
        }
    }
}
