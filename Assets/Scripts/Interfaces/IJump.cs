

namespace NutriQuest.Interfaces
{
    public interface IJump
    {
        public void Jump();
        public void FallFaster();

        public bool IsStartJumping { get; }
    }
}
