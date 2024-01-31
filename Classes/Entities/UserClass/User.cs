using Alito.Classes.Entities.UserClasses;
using System;

namespace Alito.Classes.Entities
{
    [Serializable]
    internal class User
    {
        public User(long id, string name, string petName)
        {
            chatID = id;
            nickname = name;
            Money = 0;
            Statistic = new UserStatistic();
            Pet = new Pet(petName);
        }
        public SelectedTest _selectedTest;
        public long chatID;
        public string nickname;
        public int Money;
        public UserStatistic Statistic;
        public Pet Pet;
    }
}
