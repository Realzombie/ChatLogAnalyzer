using System;

public class ChatMessages
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Streamer
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Commenter
    {
        public string display_name { get; set; }
        public string _id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string bio { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string logo { get; set; }
    }

    public class Emoticon
    {
        public string emoticon_id { get; set; }
        public string emoticon_set_id { get; set; }
    }

    public class Fragment
    {
        public string text { get; set; }
        public Emoticon emoticon { get; set; }
    }

    public class UserBadge
    {
        public string _id { get; set; }
        public string version { get; set; }
    }

    public class UserNoticeParams
    {
        [JsonProperty("msg-id")]
        public object MsgId { get; set; }
    }

    public class Emoticon2
    {
        public string _id { get; set; }
        public int begin { get; set; }
        public int end { get; set; }
    }

    public class Message
    {
        public string body { get; set; }
        public int bits_spent { get; set; }
        public List<Fragment> fragments { get; set; }
        public bool is_action { get; set; }
        public List<UserBadge> user_badges { get; set; }
        public string user_color { get; set; }
        public UserNoticeParams user_notice_params { get; set; }
        public List<Emoticon> emoticons { get; set; }
    }

    public class Comment
    {
        public string _id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string channel_id { get; set; }
        public string content_type { get; set; }
        public string content_id { get; set; }
        public double content_offset_seconds { get; set; }
        public Commenter commenter { get; set; }
        public string source { get; set; }
        public string state { get; set; }
        public Message message { get; set; }
        public bool more_replies { get; set; }
    }

    public class Video
    {
        public double start { get; set; }
        public double end { get; set; }
    }

    public class Root
    {
        public Streamer streamer { get; set; }
        public List<Comment> comments { get; set; }
        public Video video { get; set; }
        public object emotes { get; set; }
    }
}