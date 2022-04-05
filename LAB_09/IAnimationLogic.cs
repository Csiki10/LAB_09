namespace LAB_09
{
    public interface IAnimationLogic
    {
         Ball Ball { get; set; }
         Pong PongBoard { get; set; }
         Wall Wall { get; set; }

    }
}