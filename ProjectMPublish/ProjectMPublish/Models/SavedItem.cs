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
        int storyId;
        int storyNum;
        string storyText;
        public SavedItem() { }

        public SavedItem(int storyId, int storyNum, string storyText)
        {
            StoryId = storyId;
            StoryNum = storyNum;
            StoryText = storyText;
        }

        public int StoryId { get => storyId; set => storyId = value; }
        public int StoryNum { get => storyNum; set => storyNum = value; }
        public string StoryText { get => storyText; set => storyText = value; }

        public void InsertSave()
        {
            DBServices dbs = new DBServices();
            dbs.SaveItemDetails(this);

        }
    }
}