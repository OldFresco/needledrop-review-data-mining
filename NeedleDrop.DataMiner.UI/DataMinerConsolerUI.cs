﻿using System;
using System.Collections.Generic;

namespace NeedleDrop.DataMiner.UI
{
    public class DataMinerConsoleUI
    {
        public int SectionPadding { get; set; }
        public UIBannerSection MainBanner { get; set; }
        public string IntroSectionText { get; set; }
        public List<string> UserActionList { get; set; }

        public void UseDefaultLayout()
        {
            var title = @"
 ========================================================  
  _   _               _ _      ____                  
 | \ | | ___  ___  __| | | ___|  _ \ _ __ ___  _ __  
 |  \| |/ _ \/ _ \/ _` | |/ _ \ | | | '__/ _ \| '_ \ 
 | |\  |  __/  __/ (_| | |  __/ |_| | | | (_) | |_) |
 |_|_\_|\___|\___|\__,_|_|\___|____/|_|  \___/| .__/ 
 |  _ \  __ _| |_ __ _  |  \/  (_)_ __   ___ _|_|    
 | | | |/ _` | __/ _` | | |\/| | | '_ \ / _ \ '__|   
 | |_| | (_| | || (_| | | |  | | | | | |  __/ |      
 |____/ \__,_|\__\__,_| |_|  |_|_|_| |_|\___|_|      
 
 =========================================================
                                                     ";

            SectionPadding = 1;
            MainBanner = new UIBannerSection(1, 1, title, true);
            IntroSectionText = "Ay! Welcome to the NeedleDrop Data Mining Console App. \n \nPlease Select one of the following options: \n";
            UserActionList = new List<string> {" Action 1", " Action 2", " Action 3", " Exit \n"};
        }
        public void DisplayMainBanner()
        {
            Console.WriteLine(MainBanner.BannerContent);
        }

        public void DisplayIntroSection()
        {
            Console.WriteLine(IntroSectionText);
        }

        public void DisplayUserActionList()
        {
            var actionId = 1;
            foreach (var action in UserActionList)
            {
                Console.WriteLine(actionId + action + "\n");
                actionId++;
            }
        }

        public void RefresView()
        {
            Console.Clear();
            DisplayMainBanner();
            DisplayIntroSection();
            DisplayUserActionList();
        }
    }
}