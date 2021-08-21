using ChatLogAnalyzer.TwitchChatReader.TwitchObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;

namespace ChatLogAnalyzer.TwitchChatReader
{
    public static class TwitchHelper
    {
        public static async Task<JObject> GetVideoInfo(long videoId)
        {
            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                client.Headers.Add("Accept", "application/vnd.twitchtv.v5+json");
                client.Headers.Add("Client-ID", "v8kfhyc2980it9e7t5hhc7baukzuj2");
                string response = client.DownloadString("https://api.twitch.tv/kraken/videos/" + videoId);
                JObject result = JObject.Parse(response);
                return result;
            }
        }

        public static async Task<ChatRoot> GetVoDChat(long videoId)
        {
            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                client.Headers.Add("Accept", "application/vnd.twitchtv.v5+json; charset=UTF-8");
                client.Headers.Add("Client-Id", "kimne78kx3ncx6brgo4mv6wki5h1ko");

                List<Comment> comments = new List<Comment>();
                ChatRoot chatRoot = new ChatRoot() { streamer = new Streamer(), video = new VideoTime(), comments = comments };

                double videoStart = 0.0;
                double videoEnd = 0.0;
                double videoDuration = 0.0;
                int errorCount = 0;

                videoId = videoId;
                JObject taskInfo = await GetVideoInfo(videoId);
                chatRoot.streamer.name = taskInfo["channel"]["display_name"].ToString();
                chatRoot.streamer.id = taskInfo["channel"]["_id"].ToObject<int>();
                videoStart = 0.0;
                videoEnd = taskInfo["length"].ToObject<double>();


                chatRoot.video.start = videoStart;
                chatRoot.video.end = videoEnd;
                videoDuration = videoEnd - videoStart;

                double latestMessage = videoStart - 1;
                bool isFirst = true;
                string cursor = "";

                while (latestMessage < videoEnd)
                {
                    string response;

                    try
                    {
                        if (isFirst)
                            response = await client.DownloadStringTaskAsync(String.Format("https://api.twitch.tv/v5/videos/{0}/comments?content_offset_seconds={1}", videoId, videoStart));
                        else
                            response = await client.DownloadStringTaskAsync(String.Format("https://api.twitch.tv/v5/videos/{0}/comments?cursor={1}", videoId, cursor));
                        errorCount = 0;
                    }
                    catch (WebException ex)
                    {
                        errorCount++;

                        if (errorCount >= 10)
                            throw ex;

                        continue;
                    }

                    CommentResponse commentResponse = JsonConvert.DeserializeObject<CommentResponse>(response);

                    foreach (var comment in commentResponse.comments)
                    {
                        if (latestMessage < videoEnd && comment.content_offset_seconds > videoStart)
                            comments.Add(comment);

                        latestMessage = comment.content_offset_seconds;
                    }
                    if (commentResponse._next == null)
                        break;
                    else
                        cursor = commentResponse._next;

                    if (isFirst)
                        isFirst = false;
                }
                    
                return chatRoot;
            }
        }
    }
}