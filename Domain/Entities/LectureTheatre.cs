
namespace Domain.Entities
{
    public class LectureTheatre
    {
        public int LectureTheatreId { get; set; }
        public string TheatreName { get; set; }
        public int FloorId { get; set; }
        public int TheatreCapacity { get; set; }
        public List<Lecture> Lectures { get; set; }
    }
}
