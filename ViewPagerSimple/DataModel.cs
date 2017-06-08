namespace ViewPagerSimple
{
    public class DataModel
    {

        public int ImageId { get; set; }
        public string Title { get; set; }

        public DataModel(int imageId, string title)
        {
            ImageId = imageId;
            Title = title;
        }
    }
}