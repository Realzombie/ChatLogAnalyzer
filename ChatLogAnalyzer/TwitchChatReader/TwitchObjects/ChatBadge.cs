using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatLogAnalyzer.TwitchChatReader.TwitchObjects
{
    public class ChatBadge
    {
        public string Name;
        public Dictionary<string, SKBitmap> Versions;
    }
}
