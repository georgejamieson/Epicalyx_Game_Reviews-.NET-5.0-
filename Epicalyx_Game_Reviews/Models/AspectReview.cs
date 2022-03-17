using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Epicalyx_Game_Reviews.Models
{
    public class AspectReview
    {
        public int AspectReviewID { get; set; }
        public int StoryRating { get; set; }
        public int SoundtrackRating { get; set; }
        public int GraphicsRating { get; set; }
        public int GameplayRating { get; set; }
        public int? MultiplayerRating { get; set; }
        public decimal StoryCompletion { get; set; }
        public decimal TotalCompletion { get; set; }
        public int UserID { get; set; }
        public int GameID { get; set; }


        public User User { get; set; }
        public Game Game { get; set; }


    }
}