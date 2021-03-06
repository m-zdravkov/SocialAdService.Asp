﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Review : Comment
    {
        User user = new User();

        public int Stars { get; set; }

        public ushort RatingScore { get; set; }

        // public string ReviewerId { get; private set; }

        public Review() : base() { }

        public Review(ushort ratingScore, string comment) : base()
        {
            this.user.Id = user.Id;
            if (!this.IsRatingScoreValid(ratingScore))
            {
                throw new ReviewException(
                    string.Format("Rating score {0} falls outside the bounds of acceptable rating score between {1} and {2}",
                    ratingScore,
                    MinRatingScore,
                    MaxRatingScore));
            }

            this.RatingScore = ratingScore;
            this.Content = comment;
        }

        private const ushort MinRatingScore = 0;

        private const ushort MaxRatingScore = 5;

        private bool IsRatingScoreValid(ushort ratingScore)
        {
            return (ratingScore >= MinRatingScore && ratingScore <= MaxRatingScore);
        }
        //Comment attribute is inherited from Post Class, through Comment class.


    }
}
