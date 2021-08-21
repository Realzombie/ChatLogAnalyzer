using ChatLogAnalyzer.TwitchChatReader;
using ChatLogAnalyzer.TwitchChatReader.TwitchObjects;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ChatLogAnalyzer
{
    public partial class ChatReader : Form
    {
        public ChatRoot chat = new ChatRoot();

        public ChatReader()
        {
            InitializeComponent();
        }

        private async void btnLoadJSON_Click(object sender, EventArgs e)
        {
            txtBxOutput.Text = "";
            txtBxOutput.Visible = false;
            lblLoading.Visible = false;
            lblError.Visible = false;
            btnAnalyzeVoD.Enabled = false;
            lblAnalyzed.Visible = false;
            lblTotalMessages.Text = "x messages total";
            lblTotalMessages.Visible = false;
            lblLengthOfVoD.Text = "x seconds long";
            lblLengthOfVoD.Visible = false;
            lblSeconds.Visible = false;
            numSeconds.Visible = false;

            if (Int64.TryParse(txtBxURL.Text, out long videoId))
            {
                lblLoading.Visible = true;
                chat = await TwitchHelper.GetVoDChat(videoId);
                lblLoading.Visible = false;
                btnAnalyzeVoD.Enabled = true;
                lblAnalyzed.Visible = true;
                var chatsByTime = chat.comments.OrderBy(x => x.created_at).ToList();
                lblTotalMessages.Text = chatsByTime.Count() + " messages total";
                lblTotalMessages.Visible = true;
                lblLengthOfVoD.Text = Convert.ToInt32(Math.Floor((chatsByTime.Last().created_at - chatsByTime.First().created_at).TotalSeconds)) + " seconds total";
                lblLengthOfVoD.Visible = true;
                numSeconds.Visible = true;
                lblSeconds.Visible = true;
            }
            else
            {
                lblError.Visible = true;
                btnAnalyzeVoD.Enabled = false;
            }
        }

        private void btnAnalyzeVoD_Click(object sender, EventArgs e)
        {
            txtBxOutput.Text = "";
            txtBxOutput.Visible = false;
            lblLoading.Visible = false;
            lblError.Visible = false;

            if (chat != null && chat.comments != null && chat.comments.Any())
            {
                lblLoading.Visible = true;

                var chatsByTime = chat.comments.OrderBy(x => x.created_at).ToList();

                var numberOfCommentSeconds = (chatsByTime.Last().created_at - chatsByTime.First().created_at).TotalSeconds;

                var averageComments = chat.comments.Count / (numberOfCommentSeconds / Convert.ToInt32(Math.Floor(numSeconds.Value)));

                var timeIncrements = new List<DateTime>();
                var commentsStartTime = chatsByTime.First().created_at.Trim(TimeSpan.TicksPerSecond);
                var chatBlocks = new List<CommentCounter>();

                while (commentsStartTime < chatsByTime.Last().created_at)
                {
                    var loopEndTime = commentsStartTime.AddSeconds(Convert.ToInt32(Math.Floor(numSeconds.Value)));

                    chatBlocks.Add(new CommentCounter
                    {
                        StartDate = commentsStartTime,
                        Count = chatsByTime.Where(x => x.created_at >= commentsStartTime && x.created_at <= loopEndTime).Count()
                    });

                    commentsStartTime = loopEndTime;
                }

                lblLoading.Visible = false;

                var curatedList = chatBlocks.Where(x => x.Count > (averageComments * Convert.ToInt32(Math.Floor(numTimesOver.Value)))).ToList();
                if (Int64.TryParse(txtBxURL.Text, out long videoId))
                {
                    var url = "https://www.twitch.tv/videos/" + videoId.ToString();

                    if (curatedList.Any())
                    {
                        txtBxOutput.Visible = true;
                    }

                    foreach (var item in curatedList)
                    {
                        if (curatedList.Any(x => x.StartDate >= item.StartDate.AddMinutes(-1) && x.StartDate < item.StartDate))
                            continue;

                        var totalSeconds = (item.StartDate.TimeOfDay.TotalSeconds - chatsByTime.First().created_at.Trim(TimeSpan.TicksPerSecond).TimeOfDay.TotalSeconds) - 20;
                        var hoursIntoVod = Convert.ToInt32(Math.Floor(totalSeconds / 3600));
                        var minutesIntoVod = Convert.ToInt32(Math.Floor((totalSeconds - (hoursIntoVod * 3600)) / 60));
                        var secondsIntoVod = Convert.ToInt32(Math.Floor(totalSeconds - ((minutesIntoVod * 60) + (hoursIntoVod * 3600))));

                        txtBxOutput.Text += url + "?t=" + hoursIntoVod + "h" + minutesIntoVod + "m" + secondsIntoVod + "s" + System.Environment.NewLine;
                    }
                }
            }
        }

        public class CommentCounter
        {
            public int Count { get; set; }

            public DateTime StartDate { get; set; }
        }
    }
}
