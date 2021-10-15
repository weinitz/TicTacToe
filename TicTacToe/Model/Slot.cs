namespace TicTacToe.Model
{
    public class Slot
    {
        public bool IsAvailable => Value == Marker.None;

        public Marker Value { get; set; } = Marker.None;

        public override string ToString()
        {
            return ((char) Value).ToString();
        }

        public static bool operator ==(Slot a, Marker b)
        {
            return a.Value == b;
        }

        public static bool operator !=(Slot a, Marker b)
        {
            return a.Value != b;
        }
    }
}