namespace HRManagement
{
    public class FeedbackList
    {   
        public List<Feedback> feedbackList {get; set;}

        public FeedbackList()
        {
            feedbackList = new List<Feedback>();
        }

        //Add Feedback
        public void AddFeedback(Feedback feedback)
        {
            feedbackList.Add(feedback);
            Console.WriteLine($"Feedback with ID {feedback.ID} added successfully.");
        }

        //Remove Feedback
        public void RemoveFeedback(int id)
        {
            Feedback feedbackToRemove = feedbackList.Find(f => f.ID == id);
            if (feedbackToRemove != null)
            {
                feedbackList.Remove(feedbackToRemove);
                Console.WriteLine($"Feedback with ID {id} removed successfully.");
            }
            else
            {
                Console.WriteLine($"Feedback with ID {id} not found.");
            }
        }

        //Display Feedback
        public void DisplayAllFeedbacks()
        {
            if (feedbackList.Count == 0)
            {
                Console.WriteLine("No feedback available.");
                return;
            }

            Console.WriteLine("Feedback List:");
            Console.WriteLine("-------------------------------");
            foreach (Feedback feedback in feedbackList)
            {
                feedback.DisplayFeedback();
            }
            Console.WriteLine();
        }
    }
}
