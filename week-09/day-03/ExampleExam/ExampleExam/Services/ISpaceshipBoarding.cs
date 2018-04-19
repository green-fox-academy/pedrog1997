using ExampleExam.ViewModel;

namespace ExampleExam.Services
{
    public interface ISpaceshipBoarding
    {
        PlanetsShip Model { get;}

        void MoveHere(int id);
        void ToShip(int id);
        void ToPlanet(int id);
    }
}