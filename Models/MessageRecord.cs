namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        public MessageRecord(int roomID, string authorName, string text)
        {
            //I am editing this code -Hunter Seabolt
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }

        public int RoomID
        {
            get;
            private set;
        }

        public string Text
        {
            get;
            private set;
        }

        public string AuthorName
        {
            //I am editing this code -Hunter Seabolt
            get;
            private set;
        }
    }
}
