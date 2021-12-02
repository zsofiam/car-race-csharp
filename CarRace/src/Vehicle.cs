
using System.Text;


namespace CarRace.src
{
    public abstract class Vehicle
    {
        protected readonly int NormalSpeed;
        protected readonly string Name;
        protected int ActualSpeed;
        protected int DistanceTravelled;

        protected Vehicle(int normalSpeed)
        {
            Name = GenerateName();
            NormalSpeed = 100;
        }

        protected abstract string GenerateName();
        public abstract void PrepareForLap(Race race);

        public void MoveForAnHour()
        {
            DistanceTravelled += ActualSpeed;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("{type: ")
    .Append(GetType().Name)
    .Append(", ")
    .Append("name: ")
    .Append(Name)
    .Append(", ")
    .Append("distance travelled: ")
    .Append(DistanceTravelled)
    .Append("}");
            return sb.ToString();
        }
    }
}
