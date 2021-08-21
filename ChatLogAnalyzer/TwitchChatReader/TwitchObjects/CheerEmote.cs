﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatLogAnalyzer.TwitchChatReader.TwitchObjects
{
    public class CheerEmote
    {
        public string prefix { get; set; }
        public List<KeyValuePair<int, TwitchEmote>> tierList { get; set; } = new List<KeyValuePair<int, TwitchEmote>>();

        public KeyValuePair<int, TwitchEmote> getTier(int value)
        {
            KeyValuePair<int, TwitchEmote> returnPair = tierList.First();
            foreach (KeyValuePair<int, TwitchEmote> tierPair in tierList)
            {
                if (tierPair.Key > value)
                    break;
                returnPair = tierPair;
            }

            return returnPair;
        }
    }
}
