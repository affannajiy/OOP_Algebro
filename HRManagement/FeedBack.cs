//Contributor: Adham, Affan
namespace HRManagement
{
    public class Feedback
    {
        public int ID { get; set; }
        public string FeedbackText { get; set; }

        //Constructor
        public Feedback(int id, string feedback)
        {
            ID = id;
            FeedbackText = feedback;
        }

        public void DisplayFeedback()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Feedback: " + FeedbackText);
            Console.WriteLine("-------------------------------");
        }
    }
}
