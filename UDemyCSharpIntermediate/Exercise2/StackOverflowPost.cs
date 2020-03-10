using System;
using System.Collections.Generic;
using System.Text;

namespace UDemyCSharpIntermediate
{
    class StackOverflowPost
    {
        public string Title { get; private set; }
        public string Body { get; private set; }
        public DateTime CreationDate { get; private set; }

        private int _upvoteCount;
        private int _downvoteCount;

        public StackOverflowPost(string title, string body)
        {
            this.Title = title;
            this.Body = title;
            CreationDate = DateTime.Now;
        }

        public void UpvotePost()
        {
            _upvoteCount++;
        }

        public void DownvotePost()
        {
            _downvoteCount++;
        }

        public void DisplayVote()
        {
            int voteCount = _upvoteCount - _downvoteCount;
            Console.WriteLine("Current vote value: " + voteCount);
        }

    }
}
