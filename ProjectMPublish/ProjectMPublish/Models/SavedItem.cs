using ProjectMPublish.Controllers;
using ProjectMPublish.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectMPublish.Models
{
    public class SavedItem
    {
        string showName;
        int showNum;
        string storyTitle;
        string stotyText;
        int storyNum;
        string userName;

        public SavedItem(string showName, int showNum, string storyTitle, string stotyText, int storyNum, string userName)
        {
            ShowName = showName;
            ShowNum = showNum;
            StoryTitle = storyTitle;
            StotyText = stotyText;
            StoryNum = storyNum;
            UserName = userName;
        }

        public string ShowName { get => showName; set => showName = value; }
        public int ShowNum { get => showNum; set => showNum = value; }
        public string StoryTitle { get => storyTitle; set => storyTitle = value; }
        public string StotyText { get => stotyText; set => stotyText = value; }
        public int StoryNum { get => storyNum; set => storyNum = value; }
        public string UserName { get => userName; set => userName = value; }

        public SavedItem() { }

        //public void InsertSave()
        //{
        //    DBServices dbs = new DBServices();
        //    dbs.SaveItemDetails(this);
            
        //}
    }
}