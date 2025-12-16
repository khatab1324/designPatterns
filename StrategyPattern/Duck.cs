class Duck
{
    private IFlyBehaviour _FlyBehaviour;
    private IQauckbleBehaviour _QauckbleBehaviour;
    private IDisplayBehaviour _DisplayBehaviour;
    public Duck(IFlyBehaviour flyBehaviour, IQauckbleBehaviour qauckbleBehaviour, IDisplayBehaviour displayBehaviour)
    {
        _FlyBehaviour = flyBehaviour;
        _DisplayBehaviour = displayBehaviour;
        _QauckbleBehaviour = qauckbleBehaviour;
    }
    public void Display()
    {
        _DisplayBehaviour.Display();
    }
    public void Fly()
    {
        _FlyBehaviour.Fly();
    }
    public void Quack()
    {
        _QauckbleBehaviour.Quack();
    }

}